using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanAccess:DatabaseAccess
    {
        public static SqlConnection check()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            return conn;
        }

        //////////////////////////////// LOẠI HÀNG ////////////////////////////////

        //Lấy giá trị thêm loại hàng
        public string CheckInsertLoaiHang(LoaiHang loaihang)
        {
            string info = InsertLoaiHang(loaihang);
            return info;
        }
        //Lấy giá trị sửa loại hàng
        public string ChecktUpdateLoaiHang(LoaiHang loaihang)
        {
            string info = UpdateLoaiHang(loaihang);
            return info;
        }
        //Lấy giá trị xóa loại hàng
        public string CheckDeleteLoaiHang(LoaiHang loaihang)
        {
            string info = DeleteLoaiHang(loaihang);
            return info;
        }

        //////////////////////////////// SẢN PHẨM ////////////////////////////////
        //Lấy giá trị thêm sản phẩm
        public string CheckInsertSanPham123(SanPham sanpham)
        {
            string info = InsertSanPham(sanpham);
            return info;
        }

        //Lấy giá trị sửa sản phẩm
        public string CheckUpdateSanPham123(SanPham sanpham)
        {
            string info = UpdateSanPham(sanpham);
            return info;
        }
        //Lấy giá trị xóa sản phẩm
        public string CheckDeleteSanPham123(SanPham sanpham)
        {
            string info = DeleteSanPham(sanpham);
            return info;
        }


        //////////////////////////////// KHÁCH HÀNG ////////////////////////////////

        //Lấy giá trị sửa khachhang sản phẩm
        public string CheckUpdateKhachHang123(KhachHang khachhang)
        {
            string info = UpdateKhachHang(khachhang);
            return info;
        }

        //Lấy giá trị vô hiệu hóa khachhang sản phẩm
        public string CheckVHHKhachHang123(KhachHang khachhang)
        {
            string info = VoHieuHoaKhachHang(khachhang);
            return info;
        }


        //////////////////////////////// ĐƠN HÀNG ////////////////////////////////

        //Lấy giá trị sửa donhang 
        public string CheckHoanTatDonHang123(DonHang donhang)
        {
            string info = HoanTatDonHang(donhang);
            return info;
        }
        ////////////////////////////////Nhân Viên//////////////////////////
        public string CheckInsertNhanVien(NhanVien nhanvien)
        {
            string infoNV = InsertNhanVien(nhanvien);
            return infoNV;
        }
        public string CheckUpdateNhanVien(NhanVien nhanvien)
        {
            string infoNV = UpdateNhanVien(nhanvien);
            return infoNV;
        }
        public string CheckUpdateShipper(NhanVien nhanvien)
        {
            string infoNV = UpdateShipper(nhanvien);
            return infoNV;
        }
        public string CapNhatMKThanhCong123(NhanVien nhanvien)
        {
            string info = CapNhatMKThanhCong(nhanvien);
            return info;
        }
        public string CheckDisableNhanVien(NhanVien nhanvien)
        {
            string infoNV = DisableNhanVien(nhanvien);
            return infoNV;
        }
        public string CheckDisableShipper(NhanVien nhanvien)
        {
            string infoNV = DisableShipper(nhanvien);
            return infoNV;
        }
        public string UpdateProfileNhanVien123(NhanVien nhanvien)
        {
            string infoNV = UpdatingProfileNhanVien(nhanvien);
            return infoNV;
        }
        public string FindPassNhanVien123(NhanVien nhanvien)
        {
            string infoNV = FindPassNhanVien(nhanvien);
            return infoNV;
        }
        public string ChangePassNhanVien123(NhanVien nhanvien)
        {
            string infoNV = ChangePassNhanVien(nhanvien);
            return infoNV;
        }
        ///////////////////////////Giỏ hàng/////////////////////////
        public string CheckInsertGioHang(DonHang donhang)
        {
            string infoGH = InsertGioHang(donhang);
            return infoGH;
        }
        public string CheckPhuTrachDonHang(DonHang donHang)
        {
            string infoPT=PhuTrachDonHang(donHang);
            return infoPT;
        }

        public string CheckExistGH(DonHang donHang)
        {
            string infoExist=ExistGH(donHang);
            return infoExist;
        }

    }
}
