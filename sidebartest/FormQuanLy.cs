using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebartest
{
    public partial class FormQuanLy : Form
    {
        formDashboard dashboard;
        formSub1 LoaiHang;
        formSubmenu2 sub2;
        formAbout about;
        formSettings settings;
        FormQuanLyKhachHang khachhang;
        FormQuanLyDonHang donhang;
        FormDangKyNhanVien dangkynv;
        FormQuanLyNhanVien quanlynv;
        public FormQuanLy(string email,string manv)
        {
            InitializeComponent();
            
        }
        bool menuExpand = false;
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void submenu1_Click(object sender, EventArgs e)
        {
            if (dangkynv == null)
            {
                dangkynv = new FormDangKyNhanVien();    
                dangkynv.FormClosed += dangKyNV_FormClosed;
                dangkynv.MdiParent = this;
                dangkynv.Dock = DockStyle.Fill;
                dangkynv.Show();
            }
            else
            {
                dangkynv.Activate();
            }
        }

        private void dangKyNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            dangkynv = null;
        }

        private void Sub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoaiHang = null;
        }

        private void submenu2_Click(object sender, EventArgs e)
        {
            {
                if (sub2 == null)
                {
                    sub2 = new formSubmenu2();
                    sub2.FormClosed += Sub2_FormClosed;
                    sub2.MdiParent = this;
                    sub2.Dock = DockStyle.Fill;
                    sub2.Show();
                }
                else
                {
                    sub2.Activate();
                }
            }
        }
        private void Sub2_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (khachhang == null)
                {
                    khachhang = new FormQuanLyKhachHang();
                    khachhang.FormClosed += KhachHang_FormClosed;
                    khachhang.MdiParent = this;
                    khachhang.Dock = DockStyle.Fill;
                    khachhang.Show();
                }
                else
                {
                    khachhang.Activate();
                }
            }
        }

        private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            khachhang=null;
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*            {
                if (about == null)
                {
                    settings = new formSettings();
                    settings.FormClosed += Settings_FormClosed;
                    settings.MdiParent = this;
                    settings.Dock = DockStyle.Fill;
                    settings.Show();
                }
                else
                {
                    about.Activate();
                }
            }*/
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                MenuContainer.Height += 10;
                //Lon nhat
                if (MenuContainer.Height >= 509)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 69)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnDashboard.Width = sidebar.Width;
                    MenuContainer.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                //
                if (sidebar.Width >= 282)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    pnDashboard.Width = sidebar.Width;
                    MenuContainer.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }

        //KhachHang
        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (quanlynv == null)
                {
                    quanlynv = new FormQuanLyNhanVien();
                    quanlynv.FormClosed += quanLyNhanVien_FormClosed;
                    quanlynv.MdiParent = this;
                    quanlynv.Dock = DockStyle.Fill;
                    quanlynv.Show();
                }
                else
                {
                    quanlynv.Activate();
                }
            }
        }

        private void quanLyNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanlynv = null;
        }

        private void khachhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            khachhang = null;
        }

        //DonHang
        private void button4_Click_1(object sender, EventArgs e)
        {
            {
                if (donhang == null)
                {
                    donhang = new FormQuanLyDonHang();
                    donhang.FormClosed += donhang_FormClosed;
                    donhang.MdiParent = this;
                    donhang.Dock = DockStyle.Fill;
                    donhang.Show();
                }
                else
                {
                    donhang.Activate();
                }
            }
        }

        private void donhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            donhang = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (LoaiHang == null)
            {
                LoaiHang = new formSub1();
                LoaiHang.FormClosed += Sub1_FormClosed;
                LoaiHang.MdiParent = this;
                LoaiHang.Dock = DockStyle.Fill;
                LoaiHang.Show();
            }
            else
            {
                LoaiHang.Activate();
            }
        }

        /*private void button4_Click_1(object sender, EventArgs e)
        {

        }*/
    }
}
