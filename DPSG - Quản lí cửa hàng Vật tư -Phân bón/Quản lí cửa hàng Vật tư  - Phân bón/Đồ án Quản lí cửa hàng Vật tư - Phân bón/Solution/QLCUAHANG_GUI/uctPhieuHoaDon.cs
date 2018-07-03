using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_GUI
{
    public partial class uctPhieuHoaDon : UserControl
    {
        public uctPhieuHoaDon()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void addTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            // Kiểm tra tồn tại trang này chưa
            for (int i = 0; i < tabControlBill.TabPages.Count; i++)
            {
                if (tabControlBill.TabPages[i].Contains(uct) == true)
                {
                    tabControlBill.SelectedTab = tabControlBill.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabControlBill.Size;
            tab.Text = tenTab;
            tabControlBill.TabPages.Add(tab);
            tabControlBill.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public static uctPhieuHoaDon uctPHD = new uctPhieuHoaDon();
        private void btnSaleManager_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addTabPages(uctPhieuHoaDonBan.uctPHDB, 4, "Phiếu hóa đơn bán hàng");
        }

        private void btnPurchaseManager_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addTabPages(uctPhieuHoaDonNhap.uctPHN, 4, "Phiếu hóa đơn nhập hàng");
        }

        private void btnTotalDebtOfCutomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addTabPages(uctQuanLiTienNoKhachHang.uctQLTienNoKH, 4, "Quản lí tiền nợ Khách hàng");
        }

        private void btnTotalDebtOfAgency_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addTabPages(uctQuanLiTienNoDaiLi.uctQLTienNoDL, 4, "Quản lí tiền nợ Đại lí");
        }
    }
}
