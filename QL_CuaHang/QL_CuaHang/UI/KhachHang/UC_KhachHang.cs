using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QL_CuaHang.UI.KhachHang
{
    public partial class UC_KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        private bool _checkDeleteFunction = false;
        public UC_KhachHang()
        {
            InitializeComponent();
            DataLoad();

		}
        public void DataLoad()
        {
			if (!Access.I.QuyenQuanLy())
			{
				btn_Delete.Enabled = false;
			}
			else
			{
				btn_Delete.Enabled = true;
			}
			gc_KhachHang.DataSource = dataBase.DataReader("Select * from " + DataTbName.KHACHHANG_TABLENAME);
            gv_KhachHang.Columns[0].Caption = "Mã khách hàng";
            gv_KhachHang.Columns[1].Caption = "Tên khách hàng";
            gv_KhachHang.Columns[2].Caption = "Địa chỉ";
            gv_KhachHang.Columns[3].Caption = "SĐT";
            gv_KhachHang.OptionsBehavior.Editable = false;
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Form_ThemKH form_nhapKH = new Forms.Form_ThemKH();
            form_nhapKH.ShowDialog();
            DataLoad();
            //formLoadControll.UIThemKHLoader(mainContainer, bh_TieuDe);
            
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bh_TenChucNang.Caption = btn_Edit.Caption;
            gv_KhachHang.OptionsBehavior.Editable = true;
        }

        private void gv_KhachHang_ShownEditor(object sender, EventArgs e)
        {
            editValueFunction.CheckColumnAndRowsEditNow(sender);
        }
        
        private void gv_KhachHang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this._checkDeleteFunction = false;
            editValueFunction.UpdateValue(DataTbName.KHACHHANG_TABLENAME, DataTbName.KHACHHANG_KEYNAME, gv_KhachHang, gc_KhachHang);
        }

        private void gc_KhachHang_Click(object sender, EventArgs e)
        {
            return;
        }

        private void gv_KhachHang_RowEditCanceled(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            string str = gv_KhachHang.RowCount.ToString();
            MessageBox.Show(str);
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_KhachHang.OptionsBehavior.Editable = false;
            bh_TenChucNang.Caption = btn_Delete.Caption;
            this._checkDeleteFunction = true;
        }
        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bh_TenChucNang.Caption = "View";
            gv_KhachHang.OptionsBehavior.Editable = false;
            this._checkDeleteFunction = false;
        }

        private void gv_KhachHang_DoubleClick(object sender, EventArgs e)
        {
            if (!_checkDeleteFunction) return;
            deleteValueFunction.DeleteValue(DataTbName.KHACHHANG_TABLENAME, DataTbName.KHACHHANG_KEYNAME, sender, gv_KhachHang, gc_KhachHang);
        }

        public void gc_KhachHang_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("hah");
            DataLoad();
        }


    }
}
