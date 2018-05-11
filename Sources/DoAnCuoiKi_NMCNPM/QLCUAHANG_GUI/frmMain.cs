using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Threading;
using DevExpress.XtraSplashScreen;

namespace QLCUAHANG_GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        internal static List<byte> typePages = new List<byte>();
        public void addTabPages(UserControl uct,byte typeControl,string tenTab)
        {
            // Kiểm tra tồn tại trang này chưa
            for(int i=0;i<tabDisplay.TabPages.Count;i++)
            {
                if(tabDisplay.TabPages[i].Contains(uct)==true)
                {
                    tabDisplay.SelectedTab = tabDisplay.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabDisplay.Size;
            tab.Text = tenTab;
            tabDisplay.TabPages.Add(tab);
            tabDisplay.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        // Đóng tab hiện tại
        public void CloseTabDisplayCurrent()
        {
            tabDisplay.TabPages.Remove(tabDisplay.SelectedTab);
        }
        // Đóng tất cả các Tab
        public void CloseAllTab()
        {
            while (tabDisplay.TabPages.Count > 0)
            {
                CloseTabDisplayCurrent();
            }
            //tabDisplay.TabPages.Clear();
        }
        private void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
        }

        //private void frmMain_Load(object sender, EventArgs e)
        //{
        //    //Thread.Sleep(2000);
        //    skins();
        //}

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnInfoAgency_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctDaiLi.uctDL,40, "Thông tin Đại lí");
        }

        private void btnProductOfAgency_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            addTabPages(uctSanPhamDL.uctSPDL,30, "Sản Phẩm Đại Lí");
        }

        private void btnInfoOfCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctKhachHang.uctKH,30, "Thông tin Khách hàng");
        }

        private void btnBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctPhieuHoaDon.uctPHD,25, "Hóa đơn");
        }


        private void colseAllTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTab();
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CloseTabDisplayCurrent();
        }


        private void btnProductOfStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctSanPhamCH.uctSPCH, 10, "Sản phẩm trong Cửa hàng");
        }

        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItem3.Caption = DateTime.Now.ToLongDateString();
        }
        //private TabControl tabDisplay;

        //private void frmMain_Click(object sender, EventArgs e)
        //{
        //    tabDisplay = new TabControl();
        //   // tabDisplay.Controls.Add(ctxtMenuTapDispaly);
            
        //    tabDisplay.Dock = DockStyle.Fill;
        //    this.Controls.Add(tabDisplay);


        //    //    TabPage tab = new TabPage();
        //    //typePages.Add(typeControl);
        //    //tab.Name = uct.Name;
        //    //tab.Size = tabDisplay.Size;
        //    //tab.Text = tenTab;
        //    //tabDisplay.TabPages.Add(tab);
        //    //tabDisplay.SelectedTab = tab;
        //    //uct.Dock = DockStyle.Fill;
        //    //tab.Controls.Add(uct);
        //    //uct.Focus();
        //}

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(2000);
            skins();
        }

        //private void frmMain_Click(object sender, EventArgs e)
        //{
        //    tabDisplay = new TabControl();
        //    tabDisplay.Controls.Add(ctxtMenuTapDispaly);

        //    tabDisplay.Dock = DockStyle.Fill;
        //    this.Controls.Add(tabDisplay);


        //    TabPage tab = new TabPage();
        //    typePages.Add(typeControl);
        //    tab.Name = uct.Name;
        //    tab.Size = tabDisplay.Size;
        //    tab.Text = tenTab;
        //    tabDisplay.TabPages.Add(tab);
        //    tabDisplay.SelectedTab = tab;
        //    uct.Dock = DockStyle.Fill;
        //    tab.Controls.Add(uct);
        //    uct.Focus();
        //}

        private void tabDisplay_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Microsoft Sans Serif", 10);
            g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);
            e.Graphics.DrawString("X", drawFont, Brushes.Red, e.Bounds.Right - 14, e.Bounds.Top);
            e.Graphics.DrawString(this.tabDisplay.TabPages[e.Index].Text, e.Font, Brushes.White, e.Bounds.Left, e.Bounds.Top + 6);
            e.DrawFocusRectangle();
        }

        private void tabDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabDisplay.TabPages.Count; i++)

            {
                Rectangle r = tabDisplay.GetTabRect(i);
                //Getting the position of the “x” mark.
                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 20, 20);

                if (closeButton.Contains(e.Location))

                {
                    if (MessageBox.Show("Bạn có muốn đóng Tab hiện tại hay không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        this.tabDisplay.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
    }
}