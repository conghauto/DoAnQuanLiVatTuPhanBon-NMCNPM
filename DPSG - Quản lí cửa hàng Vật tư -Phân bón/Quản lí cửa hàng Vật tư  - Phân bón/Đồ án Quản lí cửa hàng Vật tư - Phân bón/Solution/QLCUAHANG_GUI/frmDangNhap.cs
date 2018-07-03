using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLCUAHANG_DAL;

namespace QLCUAHANG_GUI
{

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        static public string NameLog;
        public frmLogin()
        {
            InitializeComponent();
            pictureEdit3.Click += new EventHandler(pictureEdit3_Click);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            hide = !hide;
            if (hide == true)
            {
                this.txtPassword.Properties.PasswordChar = '\0';
            }
            else
            {
                this.txtPassword.Properties.PasswordChar = '*';
            }
        }
        public static string UserName;
        private void hyperlinkLCRegister_Click(object sender, EventArgs e)
        {

            frmRegister registerAccount = new frmRegister();
            this.Hide();
            registerAccount.ShowDialog();
            this.Show();
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool hide = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.user;
            txtPassword.Text = Properties.Settings.Default.pass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == string.Empty || txtPassword.Text == string.Empty)
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        SqlConnection cnn = DataProvider.KetNoi();
                        var cmd = new SqlCommand("users_getid", cnn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtUser.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
                        UserName = txtUser.Text;
                        SqlDataReader dt = cmd.ExecuteReader();
                        if (dt.Read() == true)
                        {
                            if (checkSave.Checked)
                            {
                                Properties.Settings.Default.user = txtUser.Text;
                                Properties.Settings.Default.pass = txtPassword.Text;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.user = "";
                                Properties.Settings.Default.pass = "";
                                Properties.Settings.Default.Save();
                            }
                            cnn.Close();
                            XtraMessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Properties.Settings.Default.NameLog = txtUser.Text;
                            Properties.Settings.Default.PassLog = txtPassword.Text;
                            this.Hide();
                            frmMain main = new frmMain();
                            main.ShowDialog();

                            txtUser.Text = "";
                            txtPassword.Text = "";
                            this.Show();

                        }
                        else
                        {
                            XtraMessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cnn.Close();
                            return;
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đăng nhập thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("Đăng nhập thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}