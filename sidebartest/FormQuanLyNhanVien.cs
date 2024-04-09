using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebartest
{
    public partial class FormQuanLyNhanVien : Form
    {
        NhanVien nhanvien = new NhanVien();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            ComboBoxItems();
            txt_TinhTrang.Enabled = false;
            txt_maNV.Enabled = false;
            dgv_nhanvien.Update();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cập nhật thông tin của tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            nhanvien.Ma_Nhan_Vien = txt_maNV.Text;
            nhanvien.Ten_Nhan_Vien = txt_tenNV.Text;
            nhanvien.Email = txt_Email.Text;
            nhanvien.MatKhau = txt_MK.Text;
            nhanvien.XacNhanMatKhau = txt_XacNhanMK.Text;
            nhanvien.VaiTro = cbo_VaiTro.Text;
            if (rdo_Nu.Checked)
            {
                nhanvien.GioiTinh = "0";
            }
            else
            {
                nhanvien.GioiTinh = "1";
            }
            nhanvien.VaiTro = cbo_VaiTro.Text;
            nhanvien.DiaChi = txt_DiaChi.Text;

            string getuser = TKBLL.CheckUpdate(nhanvien);
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
                        formSub1_Load(null, null);
                        ClearText();
                        break;
                    }
            }
        }
        private void DisableButton()
        {
            btn_sua.Enabled = false;
            btn_vohieuhoa.Enabled = false;
        }
        private void EnableButton()
        {
            btn_sua.Enabled = true;
            btn_vohieuhoa.Enabled = true;
        }
        //Thêm loại hàng
        private void btn_them_Click(object sender, EventArgs e)
        {
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
            nhanvien.VaiTro = cbo_VaiTro.Text;
            nhanvien.TinhTrang = "1"; //mặc định là đang hoạt động
            nhanvien.DiaChi = txt_DiaChi.Text;


            string getuser = TKBLL.CheckInsert(nhanvien);

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
                        formSub1_Load(null, null);
                        break;
                    }
            }
        }


        private void ComboBoxItems()
        {
            //Vai trò
            cbo_VaiTro.Items.Add("Nhân viên");
            cbo_VaiTro.Items.Add("Shipper");
        }


        DataTable dataTable = new DataTable("NhanVien");
        private void formSub1_Load(object sender, EventArgs e)
        {

            DisableButton();
            this.ControlBox = false;
            //Sẽ load lên datagridview
            dataTable.Clear();
            string query = "SELECT Ma_nhan_vien N'Mã_Nhân_Viên', Ten_NV N'Tên_Nhân_Viên', Email N'Email',MatKhau N'Mật_Khẩu',XacNhanMatKhau N'Xác_Nhận_Mật_Khẩu', IIF(Gioi_Tinh=1, 'Nam', N'Nữ') as N'Giới_Tính', VaiTro N'Vai_Trò',IIF(TinhTrang=1, N'Hoạt_Động', N'Ngừng_Hoạt_Động') as N'Tình_Trạng', DiaChi N'Địa_Chỉ' FROM dbo.NhanVien where VaiTro='Nhân Viên' or VaiTro='Shipper' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, TKBLL.Load());
            adapter.Fill(dataTable);
            dgv_nhanvien.DataSource = dataTable;
            dgv_nhanvien.Update();
            dgv_nhanvien.Refresh();
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
        private void ClearText()
        {
            txt_maNV.Text = "";
            txt_tenNV.Text = "";
            txt_Email.Text = "";
            txt_MK.Text = "";
            txt_XacNhanMK.Text = "";
            txt_TinhTrang.Text = "";
            txt_DiaChi.Text = "";
            cbo_VaiTro.SelectedIndex = -1;
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
        //Add chuỗi mã hóa
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            // Access Text property of txt_search
            dv.RowFilter = string.Format("Mã_Nhân_Viên LIKE '%{0}%' OR Email LIKE '%{0}%'", txt_search.Text);
            dgv_nhanvien.DataSource = dv.ToTable();
        }
        private void btn_vohieuhoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chỉnh sửa trạng thái hoạt động của tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            nhanvien.Ma_Nhan_Vien = txt_maNV.Text;
            if (btn_vohieuhoa.Text == "Vô Hiệu Hóa")
            {
                nhanvien.TinhTrang = "0";
                string getuser = TKBLL.CheckDisable(nhanvien);

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
                            formSub1_Load(null, null);
                            ClearText();
                            break;
                        }
                }
            }
            else if (btn_vohieuhoa.Text == "Mở Tài Khoản")
            {
                nhanvien.TinhTrang = "1";

                string getuser = TKBLL.CheckDisable(nhanvien);

                switch (getuser)
                {
                    case "requeid_manhanvien":
                        {
                            MessageBox.Show("Mã nhân viên không được để trống", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("MỞ KHÓA TÀI KHOẢN THÀNH CÔNG!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formSub1_Load(null, null);
                            ClearText();
                            break;
                        }
                }
            }
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            Reset_CurrendRoww();
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
            cbo_VaiTro.Text = dgv_nhanvien.Rows[i].Cells[6].Value.ToString();
            txt_TinhTrang.Text = dgv_nhanvien.Rows[i].Cells[7].Value.ToString();
            txt_DiaChi.Text = dgv_nhanvien.Rows[i].Cells[8].Value.ToString();
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

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            DisableButton();
            this.ControlBox = false;
            //Sẽ load lên datagridview
            dataTable.Clear();
            string query = "SELECT Ma_nhan_vien N'Mã_Nhân_Viên', Ten_NV N'Tên_Nhân_Viên', Email N'Email',MatKhau N'Mật_Khẩu',XacNhanMatKhau N'Xác_Nhận_Mật_Khẩu', IIF(Gioi_Tinh=1, 'Nam', N'Nữ') as N'Giới_Tính', VaiTro N'Vai_Trò',IIF(TinhTrang=1, N'Hoạt_Động', N'Ngừng_Hoạt_Động') as N'Tình_Trạng', DiaChi N'Địa_Chỉ' FROM dbo.NhanVien where VaiTro='Nhân Viên' or VaiTro='Shipper' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, TKBLL.Load());
            adapter.Fill(dataTable);
            dgv_nhanvien.DataSource = dataTable;
            dgv_nhanvien.Update();
            dgv_nhanvien.Refresh();
        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbo_VaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_TinhTrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_mota_Click(object sender, EventArgs e)
        {

        }

        private void txt_maNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TinhTrang_Click(object sender, EventArgs e)
        {

        }

        private void lbl_xacNhanMK_Click(object sender, EventArgs e)
        {

        }

        private void txt_MK_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_maNV_Click(object sender, EventArgs e)
        {

        }

        private void txt_XacNhanMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tenNV_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_VaiTro_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MK_Click(object sender, EventArgs e)
        {

        }

        private void lbl_GioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdo_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
