using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;        
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace QL_CuaHang.UI
{
    public partial class UC_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();

        public UC_NhanVien()
        {
            InitializeComponent();
            DataLoad();
        }

        // Functions

        #region @@ Add Value Data Table
        private void btn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_NhapNV Form_NhapNV = new Form_NhapNV();
            Form_NhapNV.ShowDialog();
        }
        #endregion

        #region @@ Delete Value Data Table

        private bool _checkDeleteFunction = false;
        private void btn_Delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            gv_DanhSachNhanVien.OptionsBehavior.Editable = false;
            bh_TenChucNang.Caption = btn_Delete.Caption;
            this._checkDeleteFunction = true;
        }

		private void gv_DanhSachNhanVien_DoubleClick(object sender, EventArgs e)
        {
			if (!_checkDeleteFunction) return;
            deleteValueFunction.DeleteValue(DataTbName.NHANVIEN_TABLENAME, DataTbName.NHANVIEN_KEYNAME, sender, gv_DanhSachNhanVien, gc_DanhNhanVien);
            //this._checkDoubleClick = false;
        }

        #endregion

        #region @@ Edit Value Data Table
        private void btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            bh_TenChucNang.Caption = btn_Edit.Caption;
            gv_DanhSachNhanVien.OptionsBehavior.Editable = true;
        }
        // Show column and row edit now
        private void gv_DanhSachNhanVien_ShownEditor(object sender, EventArgs e)
        {
            editValueFunction.CheckColumnAndRowsEditNow(sender);
        }

        private void gv_DanhSachNhanVien_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            // For edit data from database
            //string tableName = "tNhanVien";
            //string columnName = "MaNV";
            this._checkDeleteFunction = false;
            editValueFunction.UpdateValue(DataTbName.NHANVIEN_TABLENAME, DataTbName.NHANVIEN_KEYNAME, gv_DanhSachNhanVien, gc_DanhNhanVien);
        }

        #endregion

        private void gc_DanhNhanVien_Click(object sender, EventArgs e)
        {
            return;
        }
        public virtual void DataLoad()
        {
            string sl = "select * from " + DataTbName.NHANVIEN_TABLENAME;
			DataTable dt = dataBase.DataReader(sl);
			gc_DanhNhanVien.DataSource = dt;
        }

        protected virtual bool SPBanHet()
        {
			string sl = "select * from " + DataTbName.NHANVIEN_TABLENAME;
			DataTable dt = dataBase.DataReader(sl);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (dt.Rows[i]["SLSanPham"].ToString() == "0")
				{
                    return true;
				}
			}
            return false;
		}
        private void gv_DanhSachNhanVien_RowEditCanceled(object sender, RowObjectEventArgs e)
        {
            //string x = gv_DanhSachNhanVien.RowCount.ToString();
        }
        private void btn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            bh_TenChucNang.Caption = "View";
            gv_DanhSachNhanVien.OptionsBehavior.Editable = false;
            this._checkDeleteFunction = false;
        }
	}
}
