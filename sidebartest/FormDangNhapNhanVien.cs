using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebartest
{
    public partial class FormDangNhapNhanVien : Form
    {
        NhanVien nhanvien = new NhanVien();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        string roleLogin ="";
        string roleNhanVien = "Nhan Vien";
        string TTON = "1";
        string roleQuanLy = "Quan Ly";


        public FormDangNhapNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER2017;Initial Catalog=QuanLyBanHang;Integrated Security=True");
            string Email = txtEmail.Text;
            string Pass = txtPass.Text;
            conn.Open();
            string query = "Select Ma_Nhan_Vien,Email,MatKhau,VaiTro from NhanVien where (Email=@Email) and (MatKhau=@MatKhau) and (TinhTrang=@TinhTrang)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@MatKhau", Pass);
            cmd.Parameters.AddWithValue("@TinhTrang", TTON);
            SqlDataReader rd = cmd.ExecuteReader();
            if (txtPass.Text == "123456789ABCD@")
            {
                string Email_NV = txtEmail.Text;
                Hide();
                FormDoiLaiMatKhau form1 = new FormDoiLaiMatKhau(Email_NV);
                form1.ShowDialog();
                return;
            }
            else
            {
                if (rd.HasRows)
                {
                    rd.Read();
                    roleLogin = rd["VaiTro"].ToString(); // "Đăng nhập thành công 
                    if (roleLogin == roleNhanVien)
                    {
                        MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG!");
                        string MaNV_Data = rd["Ma_Nhan_Vien"].ToString();
                        string Email_NV = txtEmail.Text;
                        FormNhanVien formNV = new FormNhanVien(Email_NV, MaNV_Data);
                        formNV.ShowDialog();
                        this.Close();
                    }
                    else if(roleLogin==roleQuanLy)
                    {
                        MessageBox.Show("Quản lý");
                    }
                }
                else
                {
                    MessageBox.Show("SAI THÔNG TIN NGƯỜI DÙNG! \n HOẶC TÀI KHOẢN CỦA BẠN ĐÃ BỊ KHÓA","THÔNG BÁO!!!");
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
