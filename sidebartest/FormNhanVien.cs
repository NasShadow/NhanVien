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
    public partial class FormNhanVien : Form
    {
        formDashboard dashboard;
        formSub1 LoaiHang;
        formSubmenu2 sub2;
        formAbout about;
        formSettings settings;
        FormQuanLyKhachHang khachhang;
        FormQuanLyDonHang donhang;
        FormDonHang nhandonhang;
        FormPhuTrachDonHang phuTrachDonHang;
        FormQuanLyShipper quanLyShipper;
        public FormNhanVien(string email, string MaNV)
        {
            InitializeComponent();
            btn_User.Text = email;
            lbl_MaNV.Text = MaNV;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_LoaiHang_Click(object sender, EventArgs e)
        {
            if (LoaiHang == null)
            {
                LoaiHang = new formSub1();
                LoaiHang.FormClosed += loaiHang_FormClosed;
                LoaiHang.MdiParent = this;
                LoaiHang.Dock = DockStyle.Fill;
                LoaiHang.Show();
            }
            else
            {
                LoaiHang.Activate();
            }
        }

        private void loaiHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoaiHang = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (donhang == null)
                {
                    donhang = new FormQuanLyDonHang();
                    donhang.FormClosed += donHang_FormClosed;
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

        private void donHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            donhang = null;
        }

        private void submenu2_Click(object sender, EventArgs e)
        {
        }
        private void btn_User_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                MenuContainer.Height += 10;
                //Lon nhat
                if (MenuContainer.Height >= 298)
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

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (nhandonhang == null)
                {
                    nhandonhang = new FormDonHang(btn_User.Text,lbl_MaNV.Text);
                    nhandonhang.FormClosed += nhanDonHang_FormClosed;
                    nhandonhang.MdiParent = this;
                    nhandonhang.Dock = DockStyle.Fill;
                    nhandonhang.Show();
                }
                else
                {
                    nhandonhang.Activate();
                }
            }
        }

        private void nhanDonHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            nhandonhang = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (phuTrachDonHang == null)
                {
                    phuTrachDonHang = new FormPhuTrachDonHang(btn_User.Text, lbl_MaNV.Text);
                    phuTrachDonHang.FormClosed += phuTrachDonHang_FormClosed;
                    phuTrachDonHang.MdiParent = this;
                    phuTrachDonHang.Dock = DockStyle.Fill;
                    phuTrachDonHang.Show();
                }
                else
                {
                    phuTrachDonHang.Activate();
                }
            }
        }

        private void phuTrachDonHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            phuTrachDonHang = null;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            {
                if (settings == null)
                {
                    settings = new formSettings(btn_User.Text, lbl_MaNV.Text);
                    settings.FormClosed += Settings_FormClosed;
                    settings.MdiParent = this;
                    settings.Dock = DockStyle.Fill;
                    settings.Show();
                }
                else
                {
                    settings.Activate();
                }
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_KhachHang_Click(object sender, EventArgs e)
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
            khachhang = null;
        }

        private void btn_QLShipper_Click(object sender, EventArgs e)
        {
            if (quanLyShipper == null)
            {
                quanLyShipper = new FormQuanLyShipper();
                quanLyShipper.FormClosed += quanLyShipper_FormClosed;
                quanLyShipper.MdiParent = this;
                quanLyShipper.Dock = DockStyle.Fill;
                quanLyShipper.Show();
            }
            else
            {
                quanLyShipper.Activate();
            }
        }

        private void quanLyShipper_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanLyShipper = null;
        }

        private void lbl_MaNV_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
