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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebartest
{
    public partial class FormPhuTrachDonHang : Form
    {
        public string Manv { get; set; }
        public string Email { get; set; }
        DataTable dataTable = new DataTable("GioHang");
        static TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        static DonHang donhang = new DonHang();
        SqlConnection conn = TKBLL.Load();
        public FormPhuTrachDonHang(string email, string MaNV)
        {
            InitializeComponent();
            Email = email;
            Manv = MaNV;
        }
        private void Load_DgvDonHang()
        {
            dataTable.Clear();
            string query = "SELECT Ma_Don_Hang N'Mã_Đơn_Hàng', Ma_Khach_Hang N'Mã_Khách_Hàng',Ma_Nhan_Vien N'Mã_Nhân_Viên',Thanh_Tien N'Thành_Tiền',Ngay_Xuat_Don N'Ngày_Xuất_Đơn',Ma_Nhan_VienGH N'Mã_Nhân_Viên_GH' FROM DonHang where Ma_Nhan_Vien ='"+Manv+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dataTable);
            dgv_phutrach.DataSource = dataTable;
        }
        static string NVGH = "";
        private void dgv_phutrach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_phutrach.CurrentRow.Index;
            txt_madonhang.Text = dgv_phutrach.Rows[i].Cells[0].Value.ToString();
            txt_makhachhang.Text = dgv_phutrach.Rows[i].Cells[1].Value.ToString();
            txt_manv.Text = dgv_phutrach.Rows[i].Cells[2].Value.ToString();
            txt_thanhtien.Text = dgv_phutrach.Rows[i].Cells[3].Value.ToString();
            txt_ngayxuatdon.Text = dgv_phutrach.Rows[i].Cells[4].Value.ToString();
            NVGH= dgv_phutrach.Rows[i].Cells[5].Value.ToString();
        }

        private void FormPhuTrachDonHang_Load(object sender, EventArgs e)
        {
            dataTable.Clear();
            Load_DgvDonHang();
            txt_madonhang.Enabled= false;
            txt_makhachhang.Enabled= false;
            txt_manv.Enabled= false;
            txt_ngayxuatdon.Enabled= false;
            txt_thanhtien.Enabled= false;
        }

        private void btn_phutrach_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("BẠN CÓ CHẮC CHẮC MUỐN NGỪNG PHỤ TRÁCH ĐƠN HÀNG NÀY???", "THÔNG BÁO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                donhang.Ma_Don_Hang = txt_madonhang.Text;
                donhang.Ma_Khach_Hang = txt_makhachhang.Text;
                txt_manv.Text = Manv;
                donhang.Ma_Nhan_Vien = txt_manv.Text;
                donhang.Ma_Nhan_VienGH = NVGH;

/*                string checknv = TKBLL.Check_ExistGH(donhang);
                switch (checknv)
                {
                    case "TonTai":
                        {
                            MessageBox.Show("ĐƠN HÀNG ĐANG ĐƯỢC GIAO KHÔNG ĐƯỢC NGỪNG PHỤ TRÁCH ĐƠN HÀNG!!!");
                            return;
                        }
                }*/


                string getlist = TKBLL.PhuTrach_DonHang(donhang);
                switch (getlist)
                {
                    case "botrong":
                        {
                            MessageBox.Show("VUI LÒNG KHÔNG ĐỂ TRỐNG!!!");
                            break;
                        }
                    case "exist":
                        {
                            MessageBox.Show("ĐƠN HÀNG ĐANG ĐƯỢC GIAO NÊN KHÔNG NGỪNG PHỤ TRÁCH ĐƯỢC!!!");
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("ĐÃ NGỪNG PHỤ TRÁCH ĐƠN!!!");
                            FormPhuTrachDonHang_Load(null, null);
                            break;
                        }
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }

        }

        private void txt_ngayxuatdon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_madonhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            // Access Text property of txt_search
            dv.RowFilter = string.Format("Mã_Đơn_Hàng LIKE '%{0}%'", txt_search.Text);
            dgv_phutrach.DataSource = dv.ToTable();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            string query = "SELECT Ma_Don_Hang N'Mã_Đơn_Hàng', Ma_Khach_Hang N'Mã_Khách_Hàng',Ma_Nhan_Vien N'Mã_Nhân_Viên',Thanh_Tien N'Thành_Tiền',Ngay_Xuat_Don N'Ngày_Xuất_Đơn',Ma_Nhan_VienGH N'Mã_Nhân_Viên_GH' FROM DonHang where Ma_Nhan_Vien ='" + Manv + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dataTable);
            dgv_phutrach.DataSource = dataTable;
        }
    }
}
