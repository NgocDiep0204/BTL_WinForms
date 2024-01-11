using DevExpress.UITemplates.Collection.UserControls;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using QL_CuaHang.UI;
using QL_CuaHang.UI.BanHang;
using QL_CuaHang.UI.DoanhThu;
using QL_CuaHang.UI.HoaDonBan;
using QL_CuaHang.UI.KhachHang;
using QL_CuaHang.UI.Loai;
using QL_CuaHang.UI.MainScreen;
using QL_CuaHang.UI.NhaCungCap;
using QL_CuaHang.UI.NhapHang;
using QL_CuaHang.UI.SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Load_UcControl
{

    // INPUTDATA 
    UC_NhanVien uC_NhanVien = null;
    public const string NHANVIEN_FORM = "uC_NhanVien";

    public virtual void UINhanVienLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = NHANVIEN_FORM;
        string name = NHANVIEN_FORM;
        LoadUCcontroller(name, uC_NhanVien, _container);
    }


    UC_SanPham uC_SanPham = null;
    public const string SANPHAM_FORM = "uC_SanPham";

    public virtual void UISanPhamLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = SANPHAM_FORM;
        string name = SANPHAM_FORM;
        LoadUCcontroller(name, uC_SanPham, _container);
    }


    UC_NhapNV uC_NhapNV = null;
    public const string NHAPNV_FORM = "uC_NhapNV";
    public virtual void UINhapNVLoader(Panel _panel)
    {
        string name = NHAPNV_FORM;
        LoadUCcontroller(name, uC_NhapNV, _panel);
    }

    UC_KhachHang uC_KhachHang = null;
    public const string KHACHHANG_FORM = "uC_KhachHang";

    public virtual void UIKhachHangLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = KHACHHANG_FORM;
        string nameFormNV = KHACHHANG_FORM;
        LoadUCcontroller(nameFormNV, uC_KhachHang, _container);
    }

    UC_ThemKH uC_ThemKH = null;
    public const string THEMKH_FORM = "uC_ThemKH";

    public virtual void UIThemKHLoader(Panel _panel)
    {
        string nameFormNV = THEMKH_FORM;
        LoadUCcontroller(nameFormNV, uC_ThemKH, _panel);
    }

    UC_NhapHang uC_NhapHang = null;
    public const string NHAPHANG_FORM = "uC_NhapHang";

    public virtual void UINhapHangLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = NHAPHANG_FORM;
        string nameFormNV = NHAPHANG_FORM;
        LoadUCcontroller(nameFormNV, uC_NhapHang, _container);
    }
   UC_BanHang uC_BanHang = null;
    public const string BANHANG_FORM = "uC_BanHang";

    public virtual void UIBanHangLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = BANHANG_FORM;
        string nameFormNV = BANHANG_FORM;
        LoadUCcontroller(nameFormNV, uC_BanHang, _container);
    }
	UC_DoanhThu uC_DoanhThu = null;
    public const string DOANHTHU_FORM = "uC_DoanhThu";

    public virtual void UIDoanhThuLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = DOANHTHU_FORM;
        string nameFormNV = DOANHTHU_FORM;
        LoadUCcontroller(nameFormNV, uC_DoanhThu, _container);
    }

    UC_MainScreen uC_MainScreen = null;
    public const string MAINSCREEN_FORM = "uC_MainScreen";

    public virtual void UIMainScreenLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = MAINSCREEN_FORM;
		string name = MAINSCREEN_FORM;
		LoadUCcontroller(name, uC_HoaDonBan, _container);
	}

	UC_HoaDonBan uC_HoaDonBan = null;
    public const string HOADONBAN_FORM = "uC_HoaDonBan";
    public virtual void UIHoaDonBanLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = HOADONBAN_FORM;
        string name = HOADONBAN_FORM;
        LoadUCcontroller(name, uC_HoaDonBan, _container);
    }


    UC_NCC uC_NCC = null;
    public const string NCC_FORM = "uC_NCC";
    public virtual void UINCCLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        _item.Caption = NCC_FORM;
        string name = NCC_FORM;
        LoadUCcontroller(name, uC_NCC, _container);
    }

    UC_ThemNCC uC_ThemNCC = null;
    public const string THEMNCC_FORM = "uC_ThemNCC";

    public virtual void UIThemNCCLoader(Panel _panel)
    {
        string nameFormNV = THEMNCC_FORM;
        LoadUCcontroller(nameFormNV, uC_ThemNCC, _panel);
    }

    UC_Loai uC_Loai = null;
    public const string LOAI_FORM = "uC_Loai";

    public virtual void UILoaiLoader(FluentDesignFormContainer _container, BarHeaderItem _item)
    {
        string nameFormNV = LOAI_FORM;
        LoadUCcontroller(nameFormNV, uC_Loai, _container);
    }


    UC_ThemLoai uC_ThemLoai = null;
    public const string THEMLOAI_FORM = "uC_ThemLoai";

    public virtual void UIThemLoaiLoader(Panel _panel)
    {
        string nameFormNV = THEMLOAI_FORM;
        LoadUCcontroller(nameFormNV, uC_ThemLoai, _panel);
    }

    protected UserControl CreateNewControl(string controlType)
    {
        switch (controlType)
        {
            // ADD CASE FORM
            case NHANVIEN_FORM:
                return new UC_NhanVien();
            case SANPHAM_FORM:
                return new UC_SanPham();
            case NHAPNV_FORM: 
                return new UC_NhapNV();
            case KHACHHANG_FORM:
                return new UC_KhachHang();
            case THEMKH_FORM:
                return new UC_ThemKH();
            case BANHANG_FORM: 
                return new UC_BanHang();
            case NHAPHANG_FORM:
                return new UC_NhapHang();
            case HOADONBAN_FORM:
                return new UC_HoaDonBan();
            case NCC_FORM:
                return new UC_NCC();
            case THEMNCC_FORM:
                return new UC_ThemNCC();
            case LOAI_FORM:
                return new UC_Loai();
            case THEMLOAI_FORM:
                return new UC_ThemLoai();
            case DOANHTHU_FORM:
                return new UC_DoanhThu();
            case MAINSCREEN_FORM:
                return new UC_MainScreen();
            default:
                return null;
        }
    }
    protected virtual void LoadUCcontroller(string _name, UserControl _userControl, FluentDesignFormContainer _container)
    {
        if (_userControl == null)
        {
            _userControl = CreateNewControl(_name);
            _userControl.Dock = DockStyle.Fill;
            _container.Controls.Add(_userControl);
            _userControl.BringToFront();
        }
        else
        {
            _userControl.BringToFront();
        }
    }
    protected virtual void LoadUCcontroller(string _name, UserControl _userControl, Panel _panel)
    {
        _userControl = CreateNewControl(_name);
        if (!_panel.Controls.Contains(_userControl))
        {
            _userControl.Dock = DockStyle.Fill;
            _panel.Controls.Add(_userControl);
            _userControl.BringToFront();
        }
        else
        {
            _userControl.BringToFront();
        }
    }
 }

