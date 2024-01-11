using DevExpress.Utils.DPI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.XtraPrinting.Native;
using QL_CuaHang.Forms;
using QL_CuaHang.UI.SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.HashCodeHelper.Primitives;

namespace QL_CuaHang.UI.NhapHang
{
    public partial class UC_NhapHang  : DevExpress.XtraEditors.XtraUserControl
    {
		public DataBase dataBase = new DataBase();
		public EditValueFunction editValueFunction = new EditValueFunction();
		public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
		public SaveFunction saveFunction = new SaveFunction();
		public CodeConversion codeConversion = new CodeConversion();
		public InputConvertFuntions inputConvertFuntions = new InputConvertFuntions();
		public CboFunction cboFunction = new CboFunction();

		public string maMoi = "(Mã mới)";
		private string _hoaDonNhapFull = DataTbName.HOADONNHAP_TABLENAME + " HDN join " + DataTbName.CHITIETHDNHAP_TABLENAME + " CTHDN on HDN." + DataTbName.HOADONNHAP_KEYNAME + " = CTHDN." + DataTbName.HOADONNHAP_KEYNAME;
		public UC_NhapHang()
        {
            InitializeComponent();
			InitCom();
			InitValueInsert();
			DataLoad();
			InitValueComboBox();
		}

		protected void InitCom()
		{
			gv_DanhSachHDNhap.OptionsBehavior.Editable = false;
			gv_DanhSachHangNhap.OptionsBehavior.Editable = false;
			bh_TenChucNang.Caption = "View";
			btn_ThuGon.Enabled = false;
			cb_DanhSachSP.Text = maMoi;
			btn_HuyHD.Enabled = false;
			btn_InHoaDon.Enabled = false;
		}
		protected virtual void LoadColumneName()
		{
			if (gv_DanhSachHangNhap.DataSource == null) return;
			if (gv_DanhSachHDNhap.DataSource == null) return;
			gv_DanhSachHDNhap.Columns[0].Caption = "Mã hóa đơn nhập";
			gv_DanhSachHDNhap.Columns[1].Caption = "Ngày nhập";
			gv_DanhSachHDNhap.Columns[2].Caption = "Mã nhân viên";
			gv_DanhSachHDNhap.Columns[3].Caption = "Mã sản phẩm";
			gv_DanhSachHDNhap.Columns[4].Caption = "Số lượng";
			gv_DanhSachHDNhap.Columns[5].Caption = "Đơn giá nhập";
			gv_DanhSachHDNhap.Columns[6].Caption = "Mã nhà cung cấp";
			gv_DanhSachHDNhap.Columns[7].Caption = "Tổng tiền hóa đơn";

			gv_DanhSachHangNhap.Columns[0].Caption = "Mã hóa đơn nhập";
			gv_DanhSachHangNhap.Columns[1].Caption = "Mã sản phẩm";
			gv_DanhSachHangNhap.Columns[2].Caption = "Đơn giá nhập";
			gv_DanhSachHangNhap.Columns[3].Caption = "Số lượng";
			gv_DanhSachHangNhap.Columns[4].Caption = "Thành tiền";
		}

		protected virtual void InitValueComboBox()
		{
			DanhSachSanPham();
			GetLoaiFromDB();
			GetNhaCungCapFromDB();
		}
		public virtual void InitValueInsert()
		{
			date_NgayNhap.DateTime = DateTime.Now;
			string hdstr = "HDN" + date_NgayNhap.DateTime.ToString("yyMMdd");
			txt_MaHD.Text = codeConversion.AutoCodeConversion(DataTbName.HOADONNHAP_TABLENAME, hdstr, DataTbName.HOADONNHAP_KEYNAME);
			GetSPCode();
			txt_TaiKhoan.Text = DataValues.I.GetAccount;
			txt_TenNV.Text = DataValues.I.GetTenNV;
		}
		protected virtual void DanhSachSanPham()
		{
			cb_DanhSachSP.Properties.Items.Add(this.maMoi);
			cboFunction.PutValueToComboBox(SelectMaSP(), cb_DanhSachSP);
		}
		protected virtual void GetLoaiFromDB()
		{
			cboFunction.PutValueToComboBox(Select_Loai(), cb_Loai);
		}
		protected virtual void GetNhaCungCapFromDB()
		{
			cboFunction.PutValueToComboBox(Select_NCC(), cb_NCC);
		}

		public virtual void GetSPCode()
		{
			string spstr = "SP";
			txt_MaSP.Text = codeConversion.AutoCodeConversion(DataTbName.SANPHAM_TABLENAME, spstr, DataTbName.SANPHAM_KEYNAME);
		}

		public virtual string Select_ChiTietHDNTbl()
		{
			string sl = "select * from " + DataTbName.CHITIETHDNHAP_TABLENAME + " where " + DataTbName.HOADONNHAP_KEYNAME + " = N'" + txt_MaHD.Text + "'";
			return sl;
		}
		public virtual string Select_ChiTietHDNTbl(string _maSp)
		{
			string sl = "select * from " + DataTbName.CHITIETHDNHAP_TABLENAME + " where " + DataTbName.SANPHAM_KEYNAME + " = N'" + _maSp + "'";
			return sl;
		}
		public virtual string Select_ChiTietHDNTblWithMaHD(string _maHD)
		{
			string sl = "select * from " + DataTbName.CHITIETHDNHAP_TABLENAME + " where MaHoaDonNhap = N'"+ _maHD + "'";
			return sl;
		}

		public virtual string SelectChiTiet_HOADONNHAPHANG()
		{
			string sl = "SELECT * FROM " + DataTbName.GET_HOADONNHAPHANG + ";";
			return sl;
		}
		public virtual string Select_Loai()
		{
			string sl = "SELECT * FROM Loai;";
			return sl;
		}
		public virtual string Select_NCC()
		{
			string sl = "SELECT * FROM NhaCungCap;";
			return sl;
		}
		public virtual string Select_HOADONNHAPHANG()
		{
			string sl = "SELECT distinct MaHoaDonNhap, NgayNhap, MaNCC, TongTien FROM " + DataTbName.GET_HOADONNHAPHANG + ";";
			return sl;
		}
		public virtual string Select_HOADONNHAPHANG(string _maHD, string _maSP)
		{
			string sl = "SELECT * FROM " + DataTbName.GET_HOADONNHAPHANG + " where MaHoaDonNhap = N'"+ _maHD+ "' AND MaSP = N'" +_maSP+ "';";
			return sl;
		}
		public virtual string Select_HOADONNHAPHANG(string _maHD)
		{
			string sl = "SELECT * FROM " + DataTbName.GET_HOADONNHAPHANG + " where MaHoaDonNhap = N'"+ _maHD+ "';";
			return sl;
		}

		public virtual string UpdateTongTien_HoaDonNhap()
		{
			string sl = "";
			return sl;
		}
		public virtual string SelectMaSP()
		{
			string sl = "SELECT MaSP FROM SanPham";
			return sl;
		}
		public virtual string SelectSP(string _maSp)
		{
			string sl = "SELECT * FROM SanPham where MaSP = N'" + _maSp + "';";
			return sl;
		}

		public virtual void DataLoad()
		{
			//string sl = "select * from " + _hoaDonNhapFull;
			gc_DanhSachHDNhap.DataSource = dataBase.DataReader(SelectChiTiet_HOADONNHAPHANG());

			gc_DanhSachHangNhap.DataSource = dataBase.DataReader(Select_ChiTietHDNTbl());

			LoadColumneName();

		}

		public virtual void HoaDonNhapLoad()
		{
			gc_DanhSachHDNhap.DataSource = dataBase.DataReader(Select_HOADONNHAPHANG(txt_MaHD.Text));

			gc_DanhSachHangNhap.DataSource = dataBase.DataReader(Select_ChiTietHDNTbl());

			LoadColumneName();
		}


		#region @@ CheckColumn

		private void gv_DanhSachHDNhap_ShowingEditor(object sender, CancelEventArgs e)
		{
			editValueFunction.CheckColumnAndRowsEditNow(sender);
			deleteValueFunction.CheckColumnAndRowsEditNow(sender);
		}
		private void gv_DanhSachHangNhap_ShownEditor(object sender, EventArgs e)
		{
			editValueFunction.CheckColumnAndRowsEditNow(sender);
		}
		#endregion

		#region @@ Edit Value Data Table

		private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bh_TenChucNang.Caption = btn_Edit.Caption;
			gv_DanhSachHangNhap.OptionsBehavior.Editable = true;
			//gv_DanhSachHDNhap.OptionsBehavior.Editable = true;
		}

		private void gv_DanhSachHangNhap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			this._checkDeleteFunction = false;
			editValueFunction.UpdateValue(DataTbName.CHITIETHDNHAP_TABLENAME, DataTbName.HOADONNHAP_KEYNAME, gv_DanhSachHangNhap, gc_DanhSachHangNhap);
			DataLoad();
			HoaDonNhapLoad();
		}

		private void gv_DanhSachHDNhap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			MessageBox.Show("Bạn không sửa được đâu !");
			//if (!Access.I.QuyenQuanLy())
			//{
			//	MessageBox.Show("Bạn không có quyền");
			//	DataLoad();
			//	return;
			//}
			//this._checkDeleteFunction = false;
			//editValueFunction.UpdateValue(DataTbName.GET_HOADONNHAPHANG, DataTbName.HOADONNHAP_KEYNAME, gv_DanhSachHDNhap, gc_DanhSachHDNhap);
			//DataLoad();
		}
		#endregion

		#region @@ Delete Value Data Table

		private bool _checkDeleteFunction = false;
		private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			gv_DanhSachHDNhap.OptionsBehavior.Editable = false;
			gv_DanhSachHangNhap.OptionsBehavior.Editable = false;
			bh_TenChucNang.Caption = btn_Delete.Caption;
			this._checkDeleteFunction = true;
		}

		private void gv_DanhSachHangNhap_DoubleClick(object sender, EventArgs e)
		{
			if (!_checkDeleteFunction) return;
			string table = "EXECUTE DeleteChiTietHoaDonNhap @";
			deleteValueFunction.DeleteValueProc(table, DataTbName.HOADONNHAP_KEYNAME, DataTbName.SANPHAM_KEYNAME, sender, gv_DanhSachHangNhap, gc_DanhSachHangNhap);
			DataLoad();
		}

		private void gv_DanhSachHDNhap_DoubleClick(object sender, EventArgs e)
		{
			if (!_checkDeleteFunction) return;
			MessageBox.Show("Bạn không thể xóa hóa đơn đâu !");
			//if (!Access.I.QuyenQuanLy())
			//{
			//	MessageBox.Show("Bạn không có quyền");
			//	DataLoad();
			//	return;
			//}
			//if (!_checkDeleteFunction) return;
			//string table = "EXECUTE DeleteChiTietHoaDonNhap @";
			//deleteValueFunction.DeleteValueProc(table, DataTbName.HOADONNHAP_KEYNAME, DataTbName.SANPHAM_KEYNAME, sender, gv_DanhSachHDNhap, gc_DanhSachHDNhap);
			//DataLoad();
		}
		#endregion

		#region @@ Save Value Data Table

		public List<string> infList = new List<string>();

		public void AddTextToList()
		{
			infList.Insert(0, txt_TenSP.Text);
			infList.Insert(1, txt_SoLuong.Text);
			infList.Insert(2, txt_DonGia.Text);
			infList.Insert(3, cb_NCC.Text);
			infList.Insert(4, txt_GiamGia.Text);
			infList.Insert(5, txt_GiaNhap.Text);
			infList.Insert(6, pic_imgSP.Text);
			infList.Insert(5, cb_Loai.Text);
		}
		private void btn_Save_Click(object sender, EventArgs e)
		{
			AddTextToList();
			if (saveFunction.CheckIsNull(infList))
			{
				infList.Clear();
				return;
			}
			InsertHoaDonNhapTbl();
			UpdateSP();
			InsertSP();
			DataTable _dt = dataBase.DataReader(Select_HOADONNHAPHANG(txt_MaHD.Text,txt_MaSP.Text));
			if (_dt.Rows.Count <= 0)
			{
				string strInsert = "Insert into " + DataTbName.CHITIETHDNHAP_TABLENAME + " (MaHoaDonNhap, MaSP, DonGiaNhap, SoLuong) values (N'" + txt_MaHD.Text + "',N'" + txt_MaSP.Text + "',N'" + txt_GiaNhap.Text + "'," + txt_SoLuong.Text + ")";
				saveFunction.DataSaver(strInsert);
				txt_GiaNhap.Enabled = false;
			}
			else
			{
				UpdateChiTietHDN();
			}
			//DataLoad();
			HoaDonNhapLoad();
			StatisticValues();
			btn_HuyHD.Enabled = true;
			btn_InHoaDon.Enabled =true;
			if (cb_DanhSachSP.Text != maMoi) return;
			GetSPCode();
		}
		protected virtual void InsertHoaDonNhapTbl()
		{
			string str = "select * from HoaDonNhap where MaHoaDonNhap = N'" + txt_MaHD.Text + "'";
			DataTable dt = dataBase.DataReader(str);
			if (dt.Rows.Count > 0) return;
			string maNV = DataValues.I.GetMaNV;
			DateTime date = Convert.ToDateTime(date_NgayNhap.Text);
			string inst = "insert into HoaDonNhap (MaHoaDonNhap, MaNhanVien, NgayNhap, MaNCC) values (N'" + txt_MaHD.Text + "', N'" + maNV + "',N'" + date + "', N'" + cb_NCC.Text + "');";
			saveFunction.DataSaver(inst);
		}
		protected virtual void InsertSP()
		{
			if (cb_DanhSachSP.Text != this.maMoi) return;
			byte[] imageBytes = inputConvertFuntions.ImageToByteArray(pic_imgSP);
			string img = "0x" + BitConverter.ToString(imageBytes).Replace("-", "");
			string strSPInsert = "Insert into " + DataTbName.SANPHAM_TABLENAME + " values (N'" + txt_MaSP.Text + "',N'" + txt_TenSP.Text + "',N'" + cb_Loai.Text + "'," + txt_SoLuong.Text + ",N'" + txt_DonGia.Text + "', " + txt_GiamGia.Text + ", N'" + txt_GhiChu.Text + "'," + img + ")";
			saveFunction.DataSaver(strSPInsert);
			cb_DanhSachSP.Properties.Items.Add(txt_MaSP.Text);
		}
		protected virtual void UpdateSP()
		{
			if (cb_DanhSachSP.Text == this.maMoi) return;
			string dk = " where MaSP = N'" + txt_MaSP.Text + "';";
			DataTable dt = dataBase.DataReader(SelectSP(cb_DanhSachSP.Text));
			int slCon = int.Parse(dt.Rows[0]["SLSanPham"].ToString());
			int sl = int.Parse(txt_SoLuong.Text) + slCon;
			string updateSP = "update SanPham set SLSanPham = " + sl + dk;
			saveFunction.DataSaver(updateSP);
		}
		protected virtual void UpdateChiTietHDN()
		{
			string dk = " where MaSP = N'" + txt_MaSP.Text + "' and MaHoaDonNhap = N'" +txt_MaHD.Text+ "';";
			DataTable dt = dataBase.DataReader(Select_HOADONNHAPHANG(txt_MaHD.Text,txt_MaSP.Text));
			int slCon = int.Parse(dt.Rows[0]["SoLuong"].ToString());
			int sl = int.Parse(txt_SoLuong.Text) + slCon;
			string updateSP = "update ChiTietHDN set SoLuong = " + sl + dk;
			saveFunction.DataSaver(updateSP);
		}

		#endregion


		public int soSP = 0;
		public int tongSL = 0;
		public int tongTien = 0;

		protected virtual void StatisticValues()
		{
			DataTable dt = dataBase.DataReader(Select_ChiTietHDNTbl());
			DataTable _dt = dataBase.DataReader(Select_HOADONNHAPHANG(txt_MaHD.Text));
			int n = _dt.Rows.Count;
			this.soSP = dt.Rows.Count;
			int _tongSL = 0;

			string slName = "SoLuong";
			string ttName = "TongTien";
			for(int i = 0; i < n; i++)
			{
				_tongSL += int.Parse(_dt.Rows[i][slName].ToString());
			}
			this.tongSL = _tongSL;
			this.tongTien = int.Parse(_dt.Rows[0][ttName].ToString());

			lb_SLSp.Text = "Số sản phẩm : " + this.soSP.ToString();
			lb_SoLuong.Text = "Tổng số lượng : " + this.tongSL.ToString();
			lb_TongTien.Text = "Tổng tiền : " + this.tongTien.ToString();
		}


		#region @@ UI Control
		private void btn_HienFormNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			lc_NhapHDNhap.Visible = true;
			lc_DanhSachHangNhap.Visible = true;
		}

		private void btn_DongFormNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			lc_NhapHDNhap.Visible = false;
			lc_DanhSachHangNhap.Visible = false;
		}
		#endregion

		private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			bh_TenChucNang.Caption = "View";
			gv_DanhSachHDNhap.OptionsBehavior.Editable = false;
			gv_DanhSachHangNhap.OptionsBehavior.Editable = false;
			this._checkDeleteFunction = false;
			DataLoad();
		}

		#region @@ Text Input Conditions
		private void txt_TenSP_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputConditions.I.NotPressWithNumb(e);
		}

		private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputConditions.I.NotPressWithChar(e);
		}
		private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputConditions.I.NotPressWithChar(e);
		}


		#endregion


		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			ClearValue();
		}
		protected virtual void ClearValue()
		{
			txt_TenSP.Text = " ";
			cb_Loai.Text = " ";
			cb_NCC.Text = " ";
			txt_SoLuong.Text = " ";
			txt_GiamGia.Text = " ";
			txt_GhiChu.Text = " ";
			txt_DonGia.Text = " ";
			pic_imgSP.Text = " ";
			txt_GiaNhap.Text = " ";
			txt_TenSP.Enabled = true;
			cb_Loai.Enabled = true;
			cb_NCC.Enabled = true;
			txt_DonGia.Enabled = true;
			pic_imgSP.Enabled = true;
			txt_GiamGia.Enabled = true;
			txt_GhiChu.Enabled = true;
			txt_GiaNhap.Enabled = true;
		}

		private void cb_DanhSachSP_SelectedIndexChanged(object sender, EventArgs e)
		{
			CheckNhapSP();
			ValueInsert();
		}

		protected virtual void ValueInsert()
		{
			if (cb_DanhSachSP.Text == this.maMoi)
			{
				ClearValue();
				GetSPCode();
			}
			else
			{
				string maSP = cb_DanhSachSP.Text;
				DataTable dt = dataBase.DataReader(SelectSP(maSP));
				DataTable _dt = dataBase.DataReader(Select_ChiTietHDNTbl(maSP));
				txt_MaSP.Text = maSP;
				txt_TenSP.Text = dt.Rows[0][1].ToString();
				cb_Loai.Text = dt.Rows[0][2].ToString();
				txt_SoLuong.Text = dt.Rows[0][3].ToString();
				txt_DonGia.Text = dt.Rows[0][4].ToString();
				txt_GiamGia.Text = dt.Rows[0][5].ToString();
				txt_GhiChu.Text = dt.Rows[0][6].ToString();
				byte[] img = (byte[])dt.Rows[0][7];
				pic_imgSP.Image = inputConvertFuntions.ByteArrayToImage(img);
				DisableBox();
				if (_dt.Rows.Count <= 0) return;
				txt_GiaNhap.Text = _dt.Rows[0]["DonGiaNhap"].ToString();
			}
		}

		protected virtual void CheckNhapSP()
		{
			DataTable x = dataBase.DataReader(Select_HOADONNHAPHANG(txt_MaHD.Text, cb_DanhSachSP.Text));
			if (x.Rows.Count > 0)
			{
				txt_GiaNhap.Enabled = false;
			}
			else
			{
				txt_GiaNhap.Enabled = true;
			}
		}

		protected virtual void DisableBox()
		{
			txt_TenSP.Enabled = false;
			cb_Loai.Enabled = false;
			txt_DonGia.Enabled = false;
			pic_imgSP.Enabled = false;
			txt_GiamGia.Enabled = false;
			txt_GhiChu.Enabled = false;
		}

		private void btn_ThemHD_Click(object sender, EventArgs e)
		{
			InitValueInsert();
			DataLoad();
		}

		private void btn_HuyHD_Click(object sender, EventArgs e)
		{
			DataTable dt = dataBase.DataReader(Select_ChiTietHDNTblWithMaHD(txt_MaHD.Text));
			if (dt.Rows.Count <= 0) return;
			if (MessageBox.Show("Bạn có muốn huỷ đơn hàng này không?", "Thông báo",
							 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				for(int i = 0; i < dt.Rows.Count; i++)
				{
					string maSp = dt.Rows[i]["MaSP"].ToString();
					DataTable dtSP = dataBase.DataReader(SelectSP(maSp));
					int slKho = int.Parse(dtSP.Rows[0]["SLSanPham"].ToString());
					int slHuy = int.Parse(dt.Rows[i]["SoLuong"].ToString());
					int sl = slKho - slHuy;
					string updateSP = "update SanPham set SLSanPham = " + sl + " where MaSP = N'" + maSp + "';";
					dataBase.ChangeData(updateSP);
				}
				//string updateSP = "update SanPham set SLSanPham = " + sl + dk;
				//dataBase.ChangeData(updateSP);
				dataBase.ChangeData("delete ChiTietHDN where MaHoaDonNhap = N'" + txt_MaHD.Text + "'");
				dataBase.ChangeData("delete HoaDonNhap where MaHoaDonNhap = N'" + txt_MaHD.Text + "'");
				DataLoad();
				InitValueInsert();
			}
		}

		private void btn_InHoaDon_Click(object sender, EventArgs e)
		{
			DataTable dt = dataBase.DataReader(Select_ChiTietHDNTbl());
			if (dt.Rows.Count <= 0) return;
			btn_HuyHD.Enabled = false;
			MessageBox.Show("in");
			//// PRINT
		}
	}
   //     private void btn_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
   //     {
   //         SaveFileDialog file = new SaveFileDialog();
   //         Excel.Application exApp = new Excel.Application();
   //         Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
   //         Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
   //         Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1
   //                                                                   //Đưa dữ liệu vào file Excel

   //         tenTruong.Range["A1:D1"].MergeCells = true;
   //         tenTruong.Range["A1"].Value = "CỬA HÀNG BÁN LAPTOP";
   //         tenTruong.Range["A2"].Value = "Địa chỉ: Số 3 Đ.Cầu Giấy - Cầu Giấy - Hà Nội";
   //         tenTruong.Range["A3"].Value = "Điện thoại: 0999-999-999";
   //         tenTruong.Range["c5:f5"].MergeCells = true;
   //         tenTruong.Range["C5:F5"].Font.Size = 18;
   //         tenTruong.Range["C5:F5"].Font.Color = System.Drawing.Color.Red;
   //         tenTruong.Range["C5"].Value = "HÓA ĐƠN NHẬP";
   //         tenTruong.Range["A7"].Value = "Mã HĐ: " + txt_MaHD.Text;
			//tenTruong.Range["A8"].Value = "Nhà cung cấp: " + cb_NCC.Text;
   //         tenTruong.Range["A10"].Value = "STT ";
   //         tenTruong.Range["B10"].Value = "Mã sản phẩm ";
   //         tenTruong.Range["C10"].Value = "Tên sản phẩm ";
   //         tenTruong.Range["D10"].Value = "Số lượng ";
   //         tenTruong.Range["E10"].Value = "Đơn giá nhập";
   //         tenTruong.Range["F10"].Value = "Thành tiền";
			////tenTruong.Range["F10"].Value = ""
   //         int hang = 10;

   //         DataTable dt = dataBase.DataReader("Select ChiTietHDN.MaSP,TenSP,SoLuong,ThanhTien from ChiTietHDN inner join SanPham on SanPham.MaSP=ChiTietHDN.MaSP where MaHoaDonNhap='" + txt_MaHD.Text + "'");
   //         for (int i = 0; i < dt.Rows.Count; i++)
   //         {
   //             hang++;
   //             tenTruong.Range["A" + hang.ToString()].Value = (i + 1).ToString();
   //             tenTruong.Range["B" + hang.ToString()].Value = dt.Rows[i]["MaSP"];
   //             tenTruong.Range["C" + hang.ToString()].Value = dt.Rows[i]["TenSP"];
   //             tenTruong.Range["D" + hang.ToString()].Value = dt.Rows[i]["SoLuong"];
   //             tenTruong.Range["E" + hang.ToString()].Value = dt.Rows[i]["DonGiaNhap"];
   //             tenTruong.Range["F" + hang.ToString()].Value = dt.Rows[i]["ThanhTien"];

   //         }
   //         tenTruong.Range["D" + (hang + 1).ToString()].Value = "Tổng tiền: " + lb_TongTien.Text;
   //         tenTruong.Range["C" + (hang + 2).ToString()].Value = "Nhân viên bán: " + txt_TenNV.Text;
			//tenTruong.Range["E" + (hang + 3).ToString()].Value = "Số sản phẩm: " + lb_SLSp.Text;
			//tenTruong.Range["F" + (hang + 4).ToString()].Value ="Số lượng: " + lb_SoLuong.Text;

   //         exSheet.Name = "HoaDonNhap";
   //         exBook.Activate();
   //         if (file.ShowDialog() == DialogResult.OK)
   //             exBook.SaveAs(file.FileName.ToString());
   //         exApp.Quit();
   //     }
 }
