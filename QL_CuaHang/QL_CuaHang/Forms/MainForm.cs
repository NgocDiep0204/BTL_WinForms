using DevExpress.XtraBars;
using DevExpress.XtraWaitForm;
using QL_CuaHang.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_CuaHang
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public MainForm()
        {
            InitializeComponent();
            InitCom();
            LoadForm();
		}
		protected void InitCom()
		{
			formLoadControll.UIMainScreenLoader(mainContainer, bh_TieuDe);
			text_Account.Caption = DataValues.I.GetTenNV;
			ac_Menu.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
		}
		protected virtual void LoadForm()
        {
			if (DataValues.I.GetTypeAcc == (int)QuyenTruyCap.Quanly)
            {
                QuyenQuanLy();
            }
            else
            {
				QuyenNhanVien();
            }
        }

        protected virtual void QuyenQuanLy()
        {
			ce_QuanLy.Enabled = true;
		}
		protected virtual void QuyenNhanVien()
        {
			ce_QuanLy.Enabled = false;
		}
        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            formLoadControll.UISanPhamLoader(mainContainer, bh_TieuDe);
        }
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            formLoadControll.UINhanVienLoader(mainContainer, bh_TieuDe);
        }
        public void btn_KhachHang_Click(object sender, EventArgs e)
        {
            formLoadControll.UIKhachHangLoader(mainContainer, bh_TieuDe);
        }
        public void btn_NhapHang_Click(object sender, EventArgs e)
        {
            formLoadControll.UINhapHangLoader(mainContainer, bh_TieuDe);
        }
        private void btn_Sales_Click(object sender, EventArgs e)
        {
            formLoadControll.UIBanHangLoader(mainContainer, bh_TieuDe);
        }
		private void btn_HDB_Click(object sender, EventArgs e)
		{
			formLoadControll.UIHoaDonBanLoader(mainContainer, bh_TieuDe);
		}

		private void btn_DoanhThu_Click(object sender, EventArgs e)
		{
			formLoadControll.UIDoanhThuLoader(mainContainer, bh_TieuDe);
		}
		private void btn_Ncc_Click(object sender, EventArgs e)
		{
			formLoadControll.UINCCLoader(mainContainer, bh_TieuDe);
		}
		private void btn_Loai_Click(object sender, EventArgs e)
		{
			formLoadControll.UILoaiLoader(mainContainer, bh_TieuDe);
		}

		private void btn_DangXuat_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}

}


