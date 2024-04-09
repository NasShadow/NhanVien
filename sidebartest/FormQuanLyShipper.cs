using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebartest
{
    public partial class FormQuanLyShipper : Form
    {
        NhanVien nhanvien = new NhanVien();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        DataTable dataTable = new DataTable("NhanVienGiaoHang");
        public FormQuanLyShipper()
        {
            InitializeComponent();
        }
        private void FormQuanLyShipper_Load(object sender, EventArgs e)
        {
            dataTable.Clear();
            txt_TinhTrang.Enabled = false;
            txt_maNV.Enabled = false;
            this.ControlBox = false;
            string query = "SELECT Ma_nhan_vienGH N'Mã_Nhân_Viên', Ten_NV_GH N'Tên_Nhân_Viên', Email N'Email',MatKhau N'Mật_Khẩu',XacNhanMatKhau N'Xác_Nhận_Mật_Khẩu', IIF(Gioi_Tinh=1, 'Nam', N'Nữ') as N'Giới_Tính',IIF(TinhTrang=1, N'Hoạt_Động', N'Ngừng_Hoạt_Động') as N'Tình_Trạng', DiaChi N'Địa_Chỉ' FROM dbo.NhanVienGiaoHang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, TKBLL.Load());
            adapter.Fill(dataTable);
            dgv_nhanvien.DataSource = dataTable;
        }
        private void CheckDisable()
        {
            if (txt_TinhTrang.Text == "Hoạt_Động")
            {
                btn_vohieuhoa.Text = "Vô Hiệu Hóa";
            }
            else if (txt_TinhTrang.Text == "Ngừng_Hoạt_Động")
            {
                btn_vohieuhoa.Text = "Mở Tài Khoản";
            }
        }
        private void EnableButton()
        {
            btn_sua.Enabled = true;
            btn_vohieuhoa.Enabled = true;
        }
        private void ClearText()
        {
            txt_maNV.Text = "";
            txt_tenNV.Text = "";
            txt_Email.Text = "";
            txt_MK.Text = "";
            txt_XacNhanMK.Text = "";
            txt_TinhTrang.Text = "";
            txt_DiaChi.Text = "";
        }
        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strGioiTinh = "";
            int i = dgv_nhanvien.CurrentRow.Index;
            txt_maNV.Text = dgv_nhanvien.Rows[i].Cells[0].Value.ToString();
            txt_tenNV.Text = dgv_nhanvien.Rows[i].Cells[1].Value.ToString();
            txt_Email.Text = dgv_nhanvien.Rows[i].Cells[2].Value.ToString();
            txt_MK.Text = dgv_nhanvien.Rows[i].Cells[3].Value.ToString();
            txt_XacNhanMK.Text = dgv_nhanvien.Rows[i].Cells[4].Value.ToString();
            strGioiTinh = dgv_nhanvien.Rows[i].Cells[5].Value.ToString();
            txt_TinhTrang.Text = dgv_nhanvien.Rows[i].Cells[6].Value.ToString();
            txt_DiaChi.Text = dgv_nhanvien.Rows[i].Cells[7].Value.ToString();
            CheckDisable();
            if (string.Equals(strGioiTinh, "Nam"))
            {
                rdo_Nam.Checked = true;
            }
            else
            {
                rdo_Nu.Checked = true;
            }
            EnableButton();
        }
        private string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    sb.Append(hashedBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            // Access Text property of txt_search
            dv.RowFilter = string.Format("Mã_Nhân_Viên LIKE '%{0}%' OR Email LIKE '%{0}%'", txt_search.Text);
            dgv_nhanvien.DataSource = dv.ToTable();
        }

        private void dgv_nhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgv_nhanvien.Columns["Mật_Khẩu"].Index || e.ColumnIndex == dgv_nhanvien.Columns["Xác_Nhận_Mật_Khẩu"].Index)
            {
                // Kiểm tra giá trị của ô không phải là null
                if (e.Value != null)
                {
                    // Mã hóa giá trị và hiển thị giá trị đã mã hóa thay vì giá trị thực tế
                    e.Value = EncryptPassword(e.Value.ToString());
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cập nhật thông tin của tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            nhanvien.Ma_Nhan_Vien = txt_maNV.Text;
            nhanvien.Ten_Nhan_Vien = txt_tenNV.Text;
            nhanvien.Email = txt_Email.Text;
            nhanvien.MatKhau = txt_MK.Text;
            nhanvien.XacNhanMatKhau = txt_XacNhanMK.Text;
            if (rdo_Nu.Checked)
            {
                nhanvien.GioiTinh = "0";
            }
            else
            {
                nhanvien.GioiTinh = "1";
            }
            nhanvien.DiaChi = txt_DiaChi.Text;

            string getuser = TKBLL.CheckUpdateShipper(nhanvien);
            switch (getuser)
            {
                case "requeid_manhanvien":
                    {
                        MessageBox.Show("Mã nhân viên không được để trống");
                        break;
                    }
                case "requeid_tennhanvien":
                    {
                        MessageBox.Show("Tên nhân viên không được để trống");
                        break;
                    }
                case "wrong_name":
                    {
                        MessageBox.Show("Vui lòng chỉ nhập chữ!");
                        break;
                    }
                case "requeid_email":
                    {
                        MessageBox.Show("Email không được để trống");
                        break;
                    }
                case "requeid_email1":
                    {
                        MessageBox.Show("Địa chỉ email không phù hợp!");
                        break;
                    }
                case "requeid_matkhau":
                    {
                        MessageBox.Show("Mật khẩu không được để trống");
                        break;
                    }
                case "requeid_matkhau1":
                    {
                        MessageBox.Show("Mật khẩu phải ít nhất chứa 1 kí tự đặc biệt!");
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
                        MessageBox.Show("Cập nhật thành công");
                        FormQuanLyShipper_Load(null, null);
                        ClearText();
                        break;
                    }
            }
        }

        private void btn_vohieuhoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chỉnh sửa trạng thái hoạt động của tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            nhanvien.Ma_Nhan_Vien = txt_maNV.Text;
            if (btn_vohieuhoa.Text == "Vô Hiệu Hóa")
            {
                nhanvien.TinhTrang = "0";
                string getuser = TKBLL.CheckDisableShipper(nhanvien);

                switch (getuser)
                {
                    case "requeid_manhanvien":
                        {
                            MessageBox.Show("Mã nhân viên không được để trống");
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Vô hiệu hóa thành công");
                            FormQuanLyShipper_Load(null, null);
                            ClearText();
                            break;
                        }
                }
            }
        }
        private void Reset_CurrendRoww()
        {
            {
                //Sẽ load lên datagridview
                dataTable.Clear();
                string query = "SELECT Ma_nhan_vien N'Mã_Nhân_Viên', Ten_NV N'Tên_Nhân_Viên', Email N'Email',MatKhau N'Mật_Khẩu',XacNhanMatKhau N'Xác_Nhận_Mật_Khẩu', IIF(Gioi_Tinh=1, 'Nam', N'Nữ') as N'Giới_Tính', VaiTro N'Vai_Trò',IIF(TinhTrang=1, N'Hoạt_Động', N'Ngừng_Hoạt_Động') as N'Tình_Trạng', DiaChi N'Địa_Chỉ' FROM dbo.NhanVien where VaiTro='Nhân Viên' or VaiTro='Shipper' ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, TKBLL.Load());
                adapter.Fill(dataTable);
                dgv_nhanvien.DataSource = dataTable;
            }

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Reset_CurrendRoww();
        }
    }
}
