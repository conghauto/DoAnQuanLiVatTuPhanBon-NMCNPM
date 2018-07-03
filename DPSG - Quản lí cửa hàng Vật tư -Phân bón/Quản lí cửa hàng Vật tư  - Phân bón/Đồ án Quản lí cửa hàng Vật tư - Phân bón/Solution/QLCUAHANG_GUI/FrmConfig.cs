using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
       
        private void LoadServerName(string strCon)
        {
            SqlConnection con = new SqlConnection(strCon);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT SERVERPROPERTY('SERVERNAME') AS sqlexpress , SERVERPROPERTY('MACHINENAME') AS local", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataColumn dataColumn in dt.Columns)
                    if (cbServer.Items.Contains(dt.Rows[0][dataColumn]) == false)
                        cbServer.Items.Add(dt.Rows[0][dataColumn]);
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi load server name:" + ex.Message + "\n Load lai lan nua", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                strCon = @"server=.;database=master; integrated security=true;";
                LoadServerName(strCon);
            }
            if (cbServer.Items.Count > 0)
                cbServer.SelectedIndex = 0;
        }
      
        private void LoadDatabaseName()
        {
            try
            {
                string server = cbServer.Text.Trim();
                SqlConnection SqlCon = new SqlConnection(@"server=.;integrated security=true;");
                SqlCon.Open();
                SqlCommand SqlCom = new SqlCommand();
                SqlCom.Connection = SqlCon;
                SqlCom.CommandType = CommandType.StoredProcedure;
                SqlCom.CommandText = "sp_databases";

                SqlDataReader SqlDR;
                SqlDR = SqlCom.ExecuteReader();
                string strSystemDB = "master,model,msdb,tempdb";
                cbDatabase.Items.Clear();
                while (SqlDR.Read())
                {
                    string dbName = SqlDR.GetString(0);
                   if (strSystemDB.Contains(dbName) == false)
                        cbDatabase.Items.Add(dbName);
                }

                if (cbDatabase.Items.Count > 0)
                {
                    cbDatabase.SelectedIndex = 0;
                    btnSave.Enabled = true;
                }
                else
                {
                    cbDatabase.Items.Add("Không có CSDL nào");
                    cbDatabase.SelectedIndex = 0;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi:" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
            }

        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDatabase.Items.Clear();
            cbDatabase.Text = "";
            LoadDatabaseName();
        }
        private void AutoAttachDB(string strCon, string strDBName)
        {
            if (txtPath.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn đường dẫn để lưu cơ sở dữ liệu. Vui lòng kích Browser để chọn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                //get dynamic path later
                string strMDF = txtPath.Text + @"QUANLICUAHANG1.MDF";
                string strLDF = txtPath.Text + @"QUANLICUAHANG1_log.LDF";
                string DBPath = Application.StartupPath;// +@"\Database";
                File.Copy(DBPath + @"\QUANLICUAHANG1.MDF", strMDF, true);
                File.Copy(DBPath + @"\QUANLICUAHANG1_log.LDF", strLDF, true);
                command.CommandText = string.Format("EXEC sp_attach_db @dbname = '" + strDBName + "', @filename1 = '{0}', @filename2 = '{1}'", strMDF, strLDF);
                command.ExecuteNonQuery();
                XtraMessageBox.Show("Quá trình attach database vào Server thành công rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi trong khi kết nối tới Server.\r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool test = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                    string path = Application.StartupPath + "\\Connection.DAT";
                    StreamWriter sw = new StreamWriter(path, false);
                    string server = cbServer.Text.Trim();
                    string dbName = cbDatabase.Text.Trim();
                    string strCon = "server=.; database=" + dbName + ";integrated security=true;";
                    sw.WriteLine(strCon);
                    sw.Close();
                    XtraMessageBox.Show("Ghi chuỗi kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmLogin f = new frmLogin();
                    f.ShowDialog();
                    
              
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (foderPath.ShowDialog() == DialogResult.OK)
                txtPath.Text = foderPath.SelectedPath;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            string strCon = @"server=.;database=master;integrated security=true;";
            AutoAttachDB(strCon, "QUANLICUAHANG1");
            test = true;
        }

        private void btnCancelClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string strCon = @"server=.;database=master; integrated security=true;";
            LoadServerName(strCon);
            LoadDatabaseName();
        }

        private void tabServer_Click(object sender, EventArgs e)
        {

        }
    }
}
