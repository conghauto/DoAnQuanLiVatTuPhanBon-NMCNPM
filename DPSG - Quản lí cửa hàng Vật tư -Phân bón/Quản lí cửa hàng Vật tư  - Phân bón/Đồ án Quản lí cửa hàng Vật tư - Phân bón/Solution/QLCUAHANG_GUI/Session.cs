using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace QLCUAHANG_GUI
{
    class Session
    {
        public static string strCon = "";
        public static void GetStrConnection()
        {
            try
            {
                string path = Application.StartupPath + "\\Connection.DAT";
                if (File.Exists(path) == false) return;
                StreamReader reader = new StreamReader(path);
                string strTest = reader.ReadLine();
                if (strTest != "")
                    strCon = strTest;
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message); 

             }
        }
    }
}
