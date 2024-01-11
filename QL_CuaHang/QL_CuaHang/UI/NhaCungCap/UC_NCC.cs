using DevExpress.XtraEditors;
using QL_CuaHang.UI.HoaDonBan;
using QL_CuaHang.UI.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang.UI.NhaCungCap
{
    public partial class UC_NCC : DevExpress.XtraEditors.XtraUserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        public CboFunction cbofunction = new CboFunction();
        public InputConvertFuntions inputConvertFuntions = new InputConvertFuntions();
        private bool _checkDeleteFunction = false;
        public UC_NCC()
        {
            InitializeComponent();
        }
   
        public void UC_NCC_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
        public void dataLoad()
        { 
            if (!Access.I.QuyenQuanLy())
			{
				btn_Delete.Enabled = false;
			}
			else
			{
				btn_Delete.Enabled = true;
			}
            gc_NhaCungCap.DataSource = dataBase.DataReader("Select* from NhaCungCap");
            gv_NhaCungCap.Columns[0].Caption = "Mã nhà cung cấp";
            gv_NhaCungCap.Columns[1].Caption = "Tên nhà cung cấp";
            gv_NhaCungCap.Columns[2].Caption = "Số điện thoại";
            gv_NhaCungCap.Columns[3].Caption = "Địa chỉ";
        }
        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Form_ThemNCC form_themNcc = new Forms.Form_ThemNCC();
            form_themNcc.ShowDialog();

        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_NhaCungCap.OptionsBehavior.Editable = true;
        }

        private void cbo_MaNcc_Click_1(object sender, EventArgs e)
        {
            cbofunction.FillCombobox(cbo_MaNcc, dataBase.DataReader("select * from NhaCungCap"), "TenNcc", "MaNcc");

        }

        private void cbo_MaNcc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable sql = dataBase.DataReader("select * from NhaCungCap where MaNCC= '" + cbo_MaNcc.SelectedValue.ToString() + "'");
            if (sql.Rows.Count > 0)
            {
                gc_NhaCungCap.DataSource = sql;
            }
        }

       /* private void gv_NhaCungCap_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá nhà cung cấp này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mancc = gv_NhaCungCap.GetRowCellValue(e.RowHandle, gv_NhaCungCap.Columns[0]).ToString();
                dataBase.ChangeData("delete NhaCungCap where MaNCC = '" + mancc + "'");

            }
        }*/

        private void gv_NhaCungCap_ShowingEditor(object sender, CancelEventArgs e)
        {
            editValueFunction.CheckColumnAndRowsEditNow(sender);
        }

        private void gv_NhaCungCap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            editValueFunction.UpdateValue("NhaCungCap", "MaNCC", gv_NhaCungCap, gc_NhaCungCap);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cbo_MaNcc.Text = "";
            gc_NhaCungCap.DataSource = dataBase.DataReader("Select * from NhaCungCap");
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_NhaCungCap.OptionsBehavior.Editable = false;
           // bh_TenChucNang.Caption = btn_Delete.Caption;
            this._checkDeleteFunction = true;
        }

        private void gv_NhaCungCap_DoubleClick(object sender, EventArgs e)
        {
            if (!_checkDeleteFunction) return;
            deleteValueFunction.DeleteValue("NhaCungCap", "MaNCC", sender, gv_NhaCungCap, gc_NhaCungCap);
        }
    }
}
