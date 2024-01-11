using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataTbName
{
    #region @@ Singeton
    private static DataTbName _i;

    public static DataTbName I
    {
        get
        {
            if(_i == null)
                _i = new DataTbName();
            return _i;
        }
    }
    #endregion

    public const string NHANVIEN_TABLENAME = "NhanVien";
    public const string NHANVIEN_KEYNAME = "MaNhanVien";

    public const string SANPHAM_TABLENAME = "SanPham";
    public const string SANPHAM_KEYNAME = "MaSP";

    public const string KHACHHANG_TABLENAME = "Khach";
    public const string KHACHHANG_KEYNAME = "MaKhach";

    public const string CHITIETHDB_TABLENAME = "ChiTietHDB";
    public const string CHITIETHDB_KEYNAME = "MaHoaDonBan";

    public const string HOADONBAN_TABLENAME = "HoaDonBan";
    public const string HOADONBAN_KEYNAME = "MaHoaDonBan";
    
    public const string HOADONNHAP_TABLENAME = "HoaDonNhap";
    public const string HOADONNHAP_KEYNAME = "MaHoaDonNhap";
    
    public const string CHITIETHDNHAP_TABLENAME = "ChiTietHDN";
	//public const string CHITIETHDNHAP_KEYNAME = "MaHoaDonNhap";

	// FUNCTION DATABASE
	public const string GET_HOADONNHAPHANG = "GetHoaDonNhapHang()";

    public const string GET_NHANVIENCUATHANG = "GetTopSellingEmployees";

    public const string GET_SANPHAMBANCHAY = "GetBestSellingProduct";

    public const string GET_KHACHHANGCUATHANG = "GetTopCustomerInMonth";

    public const string GET_SANPHAMBANTHEOTHANG = "GetSoldProductsInMonth";

    public const string GET_DANHSACHDOANHTHUTHEONAM = "GetMonthlyRevenue";

    public const string GET_DANHSACHCHIPHITHEONAM = "GetMonthlyExpenses";

    public const string GET_DANHSACHLOINHUANTHEONAM = "GetMonthlyProfit";

    public const string GET_DOANHTHUTHEOTHANG = "GetDoanhThuThang";

    public const string GET_SANPHAMDABANTRONGTHANG = "GetSoldProductsInMonth";

    public const string GET_LOAIDUOCBANTHEOTHANG = "GetLoaiDuocBanTheoThang";
}
