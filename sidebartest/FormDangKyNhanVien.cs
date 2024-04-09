using BLL;
using DTO;
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
    public partial class FormDangKyNhanVien : Form
    {
        NhanVien nhanvien = new NhanVien();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public FormDangKyNhanVien()
        {
            InitializeComponent();
            ComboBoxItems();
        }
        private void ComboBoxItems()
        {
            //Vai trò
            cbo_VaiTro.Items.Add("Nhân viên");
            cbo_VaiTro.Items.Add("Shipper");
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đăng ký tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                nhanvien.Ten_Nhan_Vien = txt_tenNV.Text;
                nhanvien.Email = txt_Email.Text;
                nhanvien.MatKhau = txt_MatKhau.Text;
                nhanvien.XacNhanMatKhau = txt_XacNhanMK.Text;
                if (rdo_Nu.Checked)
                {
                    nhanvien.GioiTinh = "0";
                }
                else if (rdo_Nam.Checked)
                {
                    nhanvien.GioiTinh = "1";
                }
                else
                {
                    nhanvien.GioiTinh = "2";
                }
                nhanvien.VaiTro = cbo_VaiTro.Text;
                nhanvien.TinhTrang = "1"; //mặc định là đang hoạt động
                nhanvien.DiaChi = txt_DiaChi.Text;
                string getuser = TKBLL.CheckInsert(nhanvien);
                switch (getuser)
                {
                    case "requeid_tennhanvien":
                        {
                            MessageBox.Show("Tên nhân viên không được để trống");
                            break;
                        }
                    case "wrong_name":
                        {
                            MessageBox.Show("Vui lòng tên chỉ nhập chữ!");
                            break;
                        }
                    case "requeid_email1":
                        {
                            MessageBox.Show("Địa chỉ Email không hợp lý!");
                            break;
                        }
                    case "requeid_email":
                        {
                            MessageBox.Show("Email không được để trống");
                            break;
                        }
                    case "requeid_matkhau":
                        {
                            MessageBox.Show("Mật khẩu không được để trống");
                            break;
                        }
                    case "requeid_matkhau1":
                        {
                            MessageBox.Show("Mật khẩu phải có ít nhất 1 kí tự đặc biệt!");
                            break;
                        }
                    case "select_sex":
                        {
                            MessageBox.Show("Vui lòng chọn giới tính!");
                            break;
                        }
                    case "requeid_xacnhanmk":
                        {
                            MessageBox.Show("Xác nhận mật khẩu không được để trống");
                            break;
                        }
                    case "requeid_vaitro":
                        {
                            MessageBox.Show("Vai trò không được để trống");
                            break;
                        }
                    case "requeid_diachi":
                        {
                            MessageBox.Show("Địa chỉ không được để trống");
                            break;
                        }
                    case "match_pass":
                        {
                            MessageBox.Show("Vui lòng mật khẩu giống với xác nhận mật khẩu!");
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Thêm thành công");
                            FormDangKyNhanVien_Load(null, null);
                            break;
                        }
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void FormDangKyNhanVien_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
