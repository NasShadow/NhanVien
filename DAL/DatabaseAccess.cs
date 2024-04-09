using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //Tạo chuỗi kết nối cho cơ sở dữ liệu
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=MSI\MSSQLSERVER2017;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); //khởi tạo connect
            return conn;
        }
    }


    public class DatabaseAccess
    {
        //////////////////////////////// LOẠI HÀNG ////////////////////////////////
        //Thêm loại hàng vào database
        public static string InsertLoaiHang(LoaiHang loaiHang)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_insertloaihang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenloaihang", loaiHang.Ten_loai_hang);
            cmd.Parameters.AddWithValue("@mota", loaiHang.Mo_ta);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }
        //Sửa loại hàng vào database
        public static string UpdateLoaiHang(LoaiHang loaiHang)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updateloaihang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maloaihang", loaiHang.Ma_loai_hang);
            cmd.Parameters.AddWithValue("@tenloaihang", loaiHang.Ten_loai_hang);
            cmd.Parameters.AddWithValue("@mota", loaiHang.Mo_ta);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }
        //Xóa loại hàng vào database
        public static string DeleteLoaiHang(LoaiHang loaiHang)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_deleteloaihang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maloaihang", loaiHang.Ma_loai_hang);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }


        //////////////////////////////// SẢN PHẨM ////////////////////////////////
        //Thêm sản phẩm vào database
        public static string InsertSanPham(SanPham sanpham)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_insertsanpham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensanpham", sanpham.Ten_SP);
            cmd.Parameters.AddWithValue("@soluong", sanpham.So_luong);
            cmd.Parameters.AddWithValue("@gianhap", sanpham.Gia_nhap);
            cmd.Parameters.AddWithValue("@giaban", sanpham.Gia_ban);
            cmd.Parameters.AddWithValue("@filenames", sanpham.FileNames);
            cmd.Parameters.AddWithValue("@maloaihang", sanpham.Ma_loai_hang);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }

        //Sửa sản phẩm vào database
        public static string UpdateSanPham(SanPham sanpham)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updatesanpham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masanpham", sanpham.Ma_SP);
            cmd.Parameters.AddWithValue("@tensanpham", sanpham.Ten_SP);
            cmd.Parameters.AddWithValue("@soluong", sanpham.So_luong);
            cmd.Parameters.AddWithValue("@gianhap", sanpham.Gia_nhap);
            cmd.Parameters.AddWithValue("@giaban", sanpham.Gia_ban);
            cmd.Parameters.AddWithValue("@filenames", sanpham.FileNames);
            cmd.Parameters.AddWithValue("@maloaihang", sanpham.Ma_loai_hang);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }


        //Sửa sản phẩm vào database
        public static string DeleteSanPham(SanPham sanpham)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_deletesanpham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masanpham", sanpham.Ma_SP);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "XÓA THÀNH CÔNG";
        }

        //////////////////////////////// KHÁCH HÀNG ////////////////////////////////

        //Sửa KhachHang vào database
        public static string UpdateKhachHang(KhachHang khachhang)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updatekhachhang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makhachhang", khachhang.Ma_Khach_Hang);
            cmd.Parameters.AddWithValue("@tentaikhoan", khachhang.Ten_TK);
            cmd.Parameters.AddWithValue("@tenkhachhang", khachhang.Ten_Khach_Hang);
            cmd.Parameters.AddWithValue("@email", khachhang.Email);
            cmd.Parameters.AddWithValue("@matkhau", khachhang.MatKhau);
            cmd.Parameters.AddWithValue("@xacnhanmatkhau", khachhang.XacNhanMatKhau);
            cmd.Parameters.AddWithValue("@gioitinh", khachhang.Gioi_Tinh);
            cmd.Parameters.AddWithValue("@dienthoai", khachhang.DienThoai);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }

        //VôHieuHoa KhachHang vào database
        public static string VoHieuHoaKhachHang(KhachHang khachhang)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_vohieuhoakhachhang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makhachhang", khachhang.Ma_Khach_Hang);
            cmd.Parameters.AddWithValue("@trangthai", khachhang.TrangThai);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }


        //////////////////////////////// ĐƠN HÀNG ////////////////////////////////

        //Sửa Đơn Hàng vào database
        public static string HoanTatDonHang(DonHang donhang)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_hoantatdonhang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madonhang", donhang.Ma_Don_Hang);
            cmd.Parameters.AddWithValue("@trangthaidon", donhang.Trang_Thai_Don);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }
        public static string PhuTrachDonHang(DonHang donHang)
        {
            string user=null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_phutrachdonhang", conn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madonhang", donHang.Ma_Don_Hang);
            cmd.Parameters.AddWithValue("@manhanvien", donHang.Ma_Nhan_Vien);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }






        ////////////////////////////////Nhân Viên////////////////////////////////////////
        public static string InsertNhanVien(NhanVien nhanVien)
        {
            string user = null;

        // Hàm Connect tới CSDL
        SqlConnection conn = SqlConnectionData.Connect();
        conn.Open();
            SqlCommand cmd = new SqlCommand("proc_insertnhanvien", conn);
        cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennhanvien", nhanVien.Ten_Nhan_Vien);
            cmd.Parameters.AddWithValue("@email", nhanVien.Email);
            cmd.Parameters.AddWithValue("@matkhau", nhanVien.MatKhau);
            cmd.Parameters.AddWithValue("@xacnhanmatkhau", nhanVien.XacNhanMatKhau);
            cmd.Parameters.AddWithValue("@gioitinh", nhanVien.GioiTinh);
            cmd.Parameters.AddWithValue("@vaitro", nhanVien.VaiTro);
            cmd.Parameters.AddWithValue("@tinhtrang", nhanVien.TinhTrang);
            cmd.Parameters.AddWithValue("@diachi", nhanVien.DiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }
        public string CapNhatMKThanhCong(NhanVien nhanvien)
        {
            string user = null;
            // Hàm Connect tớ CSDL
            SqlConnection info = SqlConnectionData.Connect();
            //Mở kết nối
            info.Open();
            SqlCommand cmd = new SqlCommand("proc_updatepassnhanvien", info);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", nhanvien.Ma_Nhan_Vien);
            cmd.Parameters.AddWithValue("@matkhau", nhanvien.MatKhau);
            cmd.Parameters.AddWithValue("@xacnhanmatkhau", nhanvien.XacNhanMatKhau);
            cmd.ExecuteNonQuery();
            info.Close();
            return user;
        }

        public static string UpdateShipper(NhanVien nhanVien)
        {
            string user = null;
            string vaitro = "Shipper";
            // Hàm Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updateshipper", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", nhanVien.Ma_Nhan_Vien);
            cmd.Parameters.AddWithValue("@tennhanvien", nhanVien.Ten_Nhan_Vien);
            cmd.Parameters.AddWithValue("@email", nhanVien.Email);
            cmd.Parameters.AddWithValue("@matkhau", nhanVien.MatKhau);
            cmd.Parameters.AddWithValue("@xacnhanmatkhau", nhanVien.XacNhanMatKhau);
            cmd.Parameters.AddWithValue("@gioitinh", nhanVien.GioiTinh);
            cmd.Parameters.AddWithValue("@vaitro", vaitro);
            cmd.Parameters.AddWithValue("@diachi", nhanVien.DiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }
        public static string UpdateNhanVien(NhanVien nhanVien)
        {
            string user = null;

            // Hàm Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updatenhanvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", nhanVien.Ma_Nhan_Vien);
            cmd.Parameters.AddWithValue("@tennhanvien", nhanVien.Ten_Nhan_Vien);
            cmd.Parameters.AddWithValue("@email", nhanVien.Email);
            cmd.Parameters.AddWithValue("@matkhau", nhanVien.MatKhau);
            cmd.Parameters.AddWithValue("@xacnhanmatkhau", nhanVien.XacNhanMatKhau);
            cmd.Parameters.AddWithValue("@gioitinh", nhanVien.GioiTinh);
            cmd.Parameters.AddWithValue("@vaitro", nhanVien.VaiTro);
            cmd.Parameters.AddWithValue("@diachi", nhanVien.DiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }
        public static string DisableNhanVien(NhanVien nhanVien)
        {
            string user = null;

            // Hàm Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updatetinhtrang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", nhanVien.Ma_Nhan_Vien);
            cmd.Parameters.AddWithValue("@tinhtrang", nhanVien.TinhTrang);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }
        public static string DisableShipper(NhanVien nhanVien)
        {
            string user = null;

            // Hàm Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updatetinhtrangshipper", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", nhanVien.Ma_Nhan_Vien);
            cmd.Parameters.AddWithValue("@tinhtrang", nhanVien.TinhTrang);
            cmd.ExecuteNonQuery();
            conn.Close();

            return user;
        }
        public static string UpdatingProfileNhanVien(NhanVien nhanVien)
        {
            string user = null;

            // Hàm Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_updateprofilenhanvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", nhanVien.Ma_Nhan_Vien);
            cmd.Parameters.AddWithValue("@tennhanvien", nhanVien.Ten_Nhan_Vien);
            cmd.Parameters.AddWithValue("@email", nhanVien.Email);
            cmd.Parameters.AddWithValue("@gioitinh", nhanVien.GioiTinh);
            cmd.Parameters.AddWithValue("@diachi", nhanVien.DiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }
        public static string ChangePassNhanVien(NhanVien nhanVien)
        {
            string user = null;
            // Hàm Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_fgpassprofilenhanvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", nhanVien.Ma_Nhan_Vien);
            cmd.Parameters.AddWithValue("@matkhau", nhanVien.MatKhau);
            cmd.Parameters.AddWithValue("@xacnhanmatkhau", nhanVien.XacNhanMatKhau);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }
        public static string FindPassNhanVien(NhanVien nhanVien)
        {
            string user = null;
            // Hàm Connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_findfgpassnhanvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", nhanVien.Email);
            //Kiểm tra quyền cần thêm 1 Parameters...
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email của bạn không tồn tại!";
            }
            return user;
        }
        //////////////////Giỏ hàng/////////////////////
        public static string InsertGioHang(DonHang donhang)
        {
            string user = null;
            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand updcmd = new SqlCommand("proc_updatetrangthaidonhang", conn);
            updcmd.CommandType = CommandType.StoredProcedure;
            updcmd.Parameters.AddWithValue("@makhachhang", donhang.Ma_Khach_Hang);
            updcmd.Parameters.AddWithValue("@manhanvien", donhang.Ma_Nhan_Vien);
            updcmd.Parameters.AddWithValue("@madonhang", donhang.Ma_Don_Hang);
            updcmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }

        public static string ExistGH(DonHang donhang)
        {
            string user = null;

            // Hàm Connect tớ CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("check_existNVGH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madonhang", donhang.Ma_Don_Hang);
            cmd.ExecuteNonQuery();
            conn.Close();
            user = "TonTai";
            return user;
        }

    }
}
