using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang.UI.SanPham
{
    public partial class UC_SanPham : DevExpress.XtraEditors.XtraUserControl
    {
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        public UC_SanPham()
        {
            InitializeComponent();
            editValueFunction.DataLoad(DataTbName.SANPHAM_TABLENAME, gc_SanPham);
            gv_SanPham.OptionsBehavior.Editable = false;
            bh_TenChucNang.Caption = "View";
            QuyenNhap();
            LoadComBoBoxToColumn();
		}

        protected virtual void QuyenNhap()
        {
			if (!Access.I.QuyenQuanLy())
            {
                btn_Delete.Enabled = false;
            }
            else
            {
                btn_Delete.Enabled = true;
            }
		}


		#region @@ Edit Value Data Table
		private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bh_TenChucNang.Caption = btn_Edit.Caption;
            gv_SanPham.OptionsBehavior.Editable = true;
        }
        private void gv_SanPham_ShownEditor(object sender, EventArgs e)
        {
            editValueFunction.CheckColumnAndRowsEditNow(sender);
        }

        private void gv_SanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
		    this._checkDeleteFunction = false;
            editValueFunction.UpdateValue(DataTbName.SANPHAM_TABLENAME, DataTbName.SANPHAM_KEYNAME, gv_SanPham, gc_SanPham);
        }



        #endregion

        #region @@ Delete Value Data Table

        private bool _checkDeleteFunction = false;
        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this._checkDeleteFunction = true;
            gv_SanPham.OptionsBehavior.Editable = false;
            bh_TenChucNang.Caption = btn_Delete.Caption;
        }

        private void gv_SanPham_DoubleClick(object sender, EventArgs e)
        {
			if (!_checkDeleteFunction) return;
            deleteValueFunction.DeleteValue(DataTbName.SANPHAM_TABLENAME, DataTbName.SANPHAM_KEYNAME, sender, gv_SanPham, gc_SanPham);
        }
        #endregion

        private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bh_TenChucNang.Caption = "View";
            gv_SanPham.OptionsBehavior.Editable = false;
            this._checkDeleteFunction = false;
        }

		private void gv_SanPham_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			string columnName = "SLSanPham";
			int value = 0;

			if (e.Column.FieldName == columnName)
			{
				if (e.CellValue != null && Convert.ToInt32(e.CellValue) <= value)
				{
					e.Appearance.BackColor = Color.Orange; 
					e.Appearance.ForeColor = Color.White;
				}
			}
		}
        protected virtual void LoadComBoBoxToColumn()
        {
			RepositoryItemComboBox repositoryComboBox = new RepositoryItemComboBox();
            DataTable dt = dataBase.DataReader("Select MaLoai from Loai");
            repositoryComboBox.Items.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                repositoryComboBox.Items.Add(dt.Rows[i][0].ToString());
			}
			gv_SanPham.Columns["MaLoai"].ColumnEdit = repositoryComboBox;
			gv_SanPham.Columns["MaLoai"].OptionsColumn.AllowEdit = true;

		}

	}
}
