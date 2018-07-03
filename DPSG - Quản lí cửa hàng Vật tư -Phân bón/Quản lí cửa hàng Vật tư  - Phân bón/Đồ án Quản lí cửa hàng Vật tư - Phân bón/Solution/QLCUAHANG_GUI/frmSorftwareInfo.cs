using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_GUI
{
    public partial class frmSorftwareInfo : Form
    {
        public frmSorftwareInfo()
        {
            InitializeComponent();
        }
        private void nbiDescribe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            txtSorftwareInfo.Text = "Phần mềm quản lý bán hàng vật tư được viết ra nhằm mục đích giúp các đại lý kinh doanh vật tư nhỏ có thể quản lý công việc kinh doanh của mình nhanh, dễ dàng và thuận tiện.";
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            txtSorftwareInfo.Text = "\t\t\tCấu trúc của phần mềm                                          " +
            "\nPhần mềm được thiết kế thân thiện với người dùng, có cấu trúc gồm:                           " +
                        "\n 1. Phần đăng nhập vào phần mềm với tài khoản admin để bảo mật hơn khi quản lý công việc.                                              " +
            "\n                                                                                      2. Các chức năng quản lý việc kinh doanh:                                                                             " +
                        "\no Nhập hàng:                                                                                                                  " +
            "\n         + Nhận phiếu hàng khi nhập hàng mới.                                                                 " +
            "\n              + Xuất tiền nợ với các đại lý.                                                                                          " +
            "\n o Xuất hàng                                                                                                                             " +
            "\n + Xuất phiếu hóa đơn khi bán hàng." +                                                                                                          
            "\n                                                                                    + Báo cáo số lượng hàng tồn trong kho.               " +
            "\n                                                              + Báo cáo doanh số.                                                                                                     " + 
            "\n     3. Ngoài ra còn có các chức năng phụ như: Đăng xuất, đổi mật khẩu, đăng ký tài khoản mới,...";
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
                 txtSorftwareInfo.Text = "• Ngôn ngữ lập trình: C#.                                                                                                   " +
                                " • Phần mềm lập trình: Visual Studio 2015.                                                                        " +
                                "  • Hệ quản trị cơ sở dữ liệu: SQL Sever 2014 Management Studio.                                   " +
                                "• DevExpress 17.1";
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            txtSorftwareInfo.Text = "Để cài đặt và sử dụng tốt phần mềm, ta cần các yếu tố sau                                              " +
                            "  • Phần cứng:                                                                                                                          " +
                            " o Bộ xử lý 32 bit(x86) hoặc 64 bit(x64) có tốc độ 1 gigahertz(GHz) hoặc nhanh hơn.       " +      
                            " o RAM 1 gigabyte(GB)(32 bit) hoặc RAM 2 GB(64 bit).                                                  " +
                            "  o Đĩa cứng có dung lượng trống 16 GB(32 bit) hoặc 20 GB(64 bit).                                  " +
                            " o Thiết bị đồ họa DirectX 9 có trình điều khiển WDDM 1.0 trở lên.                                " +
                            "• Phần mềm:                                                                                                                          " +
                            " o Sử dụng từ win 7 hoặc mới hơn                                                                                        " +
                            "  o Microsoft.Net framework từ 3.0 trở lên";
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            txtSorftwareInfo.Text = "• Sau khi tải tệp cài đặt của phần mềm, kích đúp vào tệp này và bạn có thể nhấn yes liên tục để hoàn thành cài đặt hoặc có thể thay đổi tham số đường dẫn cài đặt chương trình tùy theo ý muốn. Ở giao diện cuối cùng, chọn Close để kết thúc quá trình cài đặt." +
"          • Sau khi công việc cài đặt được hoàn thành, trên giao diện Desktop của bạn sẽ xuất hiện biểu tượng của phần mềm. Kích đúp vào biểu tượng này để chạy chương trình.";
        }
        private void frmSorftwareInfo_Load(object sender, EventArgs e)
        {
            txtSorftwareInfo.Text = "Phần mềm quản lý bán hàng vật tư được viết ra nhằm mục đích giúp các đại lý kinh doanh vật tư nhỏ có thể quản lý công việc kinh doanh của mình nhanh, dễ dàng và thuận tiện.";
        }
    }
}
