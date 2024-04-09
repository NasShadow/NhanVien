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
    public partial class FormDonHang : Form
    {
        public string Manv { get; set; }
        public string Email {  get; set; }
        static TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        static DonHang donhang = new DonHang();
        SqlConnection conn = TKBLL.Load();
        public FormDonHang(string email, string MaNV)
        {
            InitializeComponent();
            Email=email;
            Manv = MaNV;
        }
        DataTable dataTable = new DataTable("DonHang");
        private void FormDonHang_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txt_madonhang.Enabled = false;
            txt_MaNV.Enabled = false;
            txt_makhachhang.Enabled = false;
            txt_thanhtien.Enabled = false;
            txt_ngayxuatdon.Enabled=false;
            txt_MaNV.Text = Manv;
            dataTable.Clear();
            string query = "SELECT Ma_Don_Hang N'Mã_Đơn_Hàng', Ma_Khach_Hang N'Mã_Khách_Hàng',Thanh_Tien AS N'Thành_Tiền',Ngay_Xuat_Don as N'Ngày_Xuất_Đơn' FROM DonHang where Ma_Nhan_Vien is null Order by Ma_Don_Hang ASC\r\n";
            SqlDataAdapter adapter = new SqlDataAdapter(query, TKBLL.Load());
            adapter.Fill(dataTable);
            dgv_donhang.DataSource = dataTable;
        }
        private void dgv_donhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_donhang.CurrentRow.Index;
            txt_madonhang.Text = dgv_donhang.Rows[i].Cells[0].Value.ToString();
            txt_makhachhang.Text = dgv_donhang.Rows[i].Cells[1].Value.ToString();
            txt_thanhtien.Text = dgv_donhang.Rows[i].Cells[2].Value.ToString();
            txt_ngayxuatdon.Text= dgv_donhang.Rows[i].Cells[3].Value.ToString();
        }

        private void dgv_donhang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void btn_phutrach_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN PHỤ TRÁCH ĐƠN HÀNG NÀY???", "THÔNG BÁO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            donhang.Ma_Don_Hang = txt_madonhang.Text;
            donhang.Ma_Khach_Hang = txt_makhachhang.Text;
            txt_MaNV.Text = Manv;
            donhang.Thanh_Tien = txt_thanhtien.Text;
            donhang.Ma_Nhan_Vien=txt_MaNV.Text;
            if (result == DialogResult.Yes)
            {
                string getlist = TKBLL.Insert_GioHang(donhang);
                switch (getlist)
                {
                    case "botrong":
                        {
                            MessageBox.Show("VUI LÒNG KHÔNG ĐỂ TRỐNG");
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("ĐÃ NHẬN PHỤ TRÁCH ĐƠN!");
                            FormDonHang_Load(null, null);
                            break;
                        }
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            // Access Text property of txt_search
            dv.RowFilter = string.Format("Mã_Đơn_Hàng LIKE '%{0}%'", txt_search.Text);
            dgv_donhang.DataSource = dv.ToTable();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            string query = "SELECT Ma_Don_Hang N'Mã_Đơn_Hàng', Ma_Khach_Hang N'Mã_Khách_Hàng',Thanh_Tien AS N'Thành_Tiền',Ngay_Xuat_Don as N'Ngày_Xuất_Đơn' FROM DonHang where Ma_Nhan_Vien is null Order by Ma_Don_Hang ASC\r\n";
            SqlDataAdapter adapter = new SqlDataAdapter(query, TKBLL.Load());
            adapter.Fill(dataTable);
            dgv_donhang.DataSource = dataTable;
        }
    }
}
