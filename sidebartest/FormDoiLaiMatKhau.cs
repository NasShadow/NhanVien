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
    public partial class FormDoiLaiMatKhau : Form
    {
        NhanVien nhanvien = new NhanVien();
        static TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        //Kết nối
        static SqlConnection conn = TKBLL.Load();
        public string Email { get; set; }
        public FormDoiLaiMatKhau(string email)
        {
            InitializeComponent();
            this.Email = email;
        }
        private void FormDoiLaiMatKhau_Load(object sender, EventArgs e)
        {
            TaoMa();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        string maNV = "";
        private void TaoMa()
        {
            try
            {
                conn.Open();

                //Tạo vòng lặp và lấy dữ liệu từ csdl
                SqlCommand sqlCommand = new SqlCommand($"SELECT Ma_Nhan_Vien FROM dbo.NhanVien WHERE Email = N'{this.Email}'", conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    maNV = "";
                    maNV += reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btn_ĐangNhap_Click(object sender, EventArgs e)
        {
            nhanvien.Ma_Nhan_Vien = maNV;
            nhanvien.MatKhau = txtPass.Text;
            nhanvien.XacNhanMatKhau = txtConfirmPass.Text;
            string get = TKBLL.CapNhat_MKThanhCong(nhanvien);

            switch (get)
            {
                case "requeid_botrong":
                    {
                        MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ!!!", "THÔNG BÁO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case "requeid_matkhau":
                    {
                        MessageBox.Show("MẬT KHẨU CẦN CÓ ÍT NHẤT 1 KÝ TỰ ĐẶC BIỆT!!!", "THÔNG BÁO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case "requeid_short":
                    {
                        MessageBox.Show("MẬT KHẨU CỦA BẠN QUÁ NGẮN!!!", "THÔNG BÁO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case "requeid_khongbang":
                    {
                        MessageBox.Show("MẬT KHẨU KHÔNG TRÙNG KHỚP NHAU!!!", "THÔNG BÁO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("CẬP NHẬT MẬT KHẨU THÀNH CÔNG!!!", "THÔNG BÁO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormDangNhapNhanVien form = new FormDangNhapNhanVien();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
