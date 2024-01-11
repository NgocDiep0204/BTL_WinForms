namespace DevExpress.UITemplates.Collection.UserControls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using DevExpress.XtraBars;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
    using System.Data;
    using QL_CuaHang.UI;
    using DevExpress.Utils.About;
	using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

	public partial class UC_NhapNV : XtraUserControl
    {

        public DataBase dataBase = new DataBase();
        public UC_NhanVien uC_NhanVien = new UC_NhanVien();
        public CodeConversion codeConversion = new CodeConversion();
        public SaveFunction saveFunction = new SaveFunction();
        public UC_NhapNV()
        {
            InitializeComponent();
            InitComponet();
        }

        protected virtual void InitComponet()
        {
            text_TenNV.Focus();
            InitValueText();
			CreateEmployeeCode();
        }
        protected virtual void InitValueText()
        {
			List<string> gioiTinh = new List<string> { "Nam", "Nữ" };
			cb_GioiTinh.Properties.Items.AddRange(gioiTinh);

			List<string> chucvu = new List<string> { "Quản lý", "Nhân viên" };
			cb_ChucVu.Properties.Items.AddRange(chucvu);

            List<string> hsl = new List<string> { "1", "2","3"};
			cb_HSL.Properties.Items.AddRange(hsl);
		}

        protected virtual void CreateEmployeeCode()
        {
            string maNVHead = "NV";
            string maNV = codeConversion.AutoCodeConversion(DataTbName.NHANVIEN_TABLENAME, maNVHead, DataTbName.NHANVIEN_KEYNAME);
            text_MaNV.Text = maNV;
        }

        #region @@ Save Value Data Table

        public List<string> infList = new List<string>();

        public void AddTextToList()
        {
            infList.Insert(0, text_TenNV.Text);
            infList.Insert(1, date_NTNS.Text);
            infList.Insert(2, text_DiaChi.Text);
            infList.Insert(3, cb_GioiTinh.Text);
            infList.Insert(4, cb_ChucVu.Text);
            infList.Insert(5, cb_HSL.Text);
            //infList.Insert(7, text_GhiChu.Text);
        }

        private void btn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {

            // Add and check list have data or null
            AddTextToList();

            if (saveFunction.CheckIsNull(infList))
            {
                infList.Clear();
                return;
            }

            DateTime date = Convert.ToDateTime(date_NTNS.Text);
            DateTime dateLv = Convert.ToDateTime(date_NgayLV.Text);
            string strInsert = "Insert into " + DataTbName.NHANVIEN_TABLENAME + " values ('" + text_MaNV.Text + "',N'" + text_TenNV.Text + "',N'" + cb_GioiTinh.Text + "',N'" + text_DiaChi.Text + "',N'" + text_SDT.Text + "',N'" + date.ToString() + "', N'" + dateLv.ToString() + "'," + cb_HSL.Text + ",N'" + cb_ChucVu.Text + "',N'" + text_GhiChu.Text + "')";
			string strInsertTk = "Insert into UserAccount values (N'" + text_MaNV.Text + "', '123' , N'"+ text_MaNV.Text+ "', "+ GetQuyen() +")";
			saveFunction.DataSaver(strInsert);
			saveFunction.DataSaver(strInsertTk);

            // Return form insert default
            CreateEmployeeCode();
            ClearData();
            uC_NhanVien.DataLoad();
        }

        protected virtual int GetQuyen()
        {
            switch (cb_ChucVu.Text)
            {
                case "Quản lý":
                    return 1;
                case "Nhân viên":
                    return 0;
                default:
                    return 0;
            }
        }

        #endregion

        #region @@ ClearData
        private void btn_ClearData_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearData();
        }

        protected virtual void ClearData()
        {
            text_TenNV.Text = "";
            text_GhiChu.Text = "";
            cb_ChucVu.Text = "";
            cb_HSL.Text = "";
            text_DiaChi.Text = "";
            date_NTNS.Text = "";
            text_SDT.Text = "";
            cb_GioiTinh.Text = "";
        }

		#endregion

		#region @@ TextCoditions
		private void text_SDT_TextChanged(object sender, EventArgs e)
		{
            InputConditions.I.PhoneNumberChecker(text_SDT);
		}

		private void text_SDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputConditions.I.NotPressWithChar(e);
		}
		private void text_TenNV_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputConditions.I.NotPressWithNumb(e);
		}
		#endregion


	}
}
