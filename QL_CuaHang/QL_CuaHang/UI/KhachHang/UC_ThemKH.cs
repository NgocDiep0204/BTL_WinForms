namespace DevExpress.UITemplates.Collection.UserControls {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraPrinting;
    using QL_CuaHang;
    using QL_CuaHang.UI;
    using QL_CuaHang.UI.KhachHang;

    public partial class UC_ThemKH : XtraUserControl {

        public DataBase dataBase = new DataBase();
        public CodeConversion codeConversion = new CodeConversion();
        public SaveFunction saveFunction = new SaveFunction();
        public UC_KhachHang uC_KhachHang = new UC_KhachHang();  
        public UC_ThemKH() 
        {
            InitializeComponent();
            ClearData();
            
        }

        protected virtual void AddCode()
        {
            string str = "KH";

            txtMaKH.Text = codeConversion.AutoCodeConversion(DataTbName.KHACHHANG_TABLENAME, str, DataTbName.KHACHHANG_KEYNAME);

        }
        private void btn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddCode();

            AddTextToList();

            if (saveFunction.CheckIsNull(infList))
            {
                infList.Clear();
                return;
            }

            
            string sql = "insert into " + DataTbName.KHACHHANG_TABLENAME + " values(N'" + txtMaKH.Text + "', N'" + txtTenKH.Text + "', N'" + txtDiaChi.Text + "',N'" + txtSdt.Text + "')";
            
            saveFunction.DataSaver(sql);

            ClearData();
            
        }
        public List<string> infList = new List<string>();
        public void AddTextToList()
        {
            infList.Insert(0, txtTenKH.Text);
            infList.Insert(1, txtSdt.Text);
            infList.Insert(2, txtDiaChi.Text);
        }
        protected virtual void ClearData()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
          
        }

        private void btn_Clear_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearData();
        }

        private void btn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //UC_ThemKH.Close();
            }
        }

		#region @@ TextCoditions
		private void text_SDT_TextChanged(object sender, EventArgs e)
		{
			InputConditions.I.PhoneNumberChecker(txtSdt);
		}

		private void text_SDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputConditions.I.NotPressWithChar(e);
		}
		private void text_TenKH_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputConditions.I.NotPressWithNumb(e);
		}
		#endregion
	}
}
