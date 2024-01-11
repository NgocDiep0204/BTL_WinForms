using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang.UI.Loai
{
    public partial class UC_Loai : DevExpress.XtraEditors.XtraUserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        public CboFunction cbofunction = new CboFunction();
        public InputConvertFuntions inputConvertFuntions = new InputConvertFuntions();
        private bool _checkDeleteFunction = false;
        public UC_Loai()
        {
            InitializeComponent();
        }
        private void UC_Loai_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
        public void dataLoad()
        {
            gc_Loai.DataSource = dataBase.DataReader("Select * from Loai");
            gv_Loai.Columns[0].Caption = "Mã loại";
            gv_Loai.Columns[1].Caption = "Tên loại";
        }
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Form_ThemLoai frm = new Forms.Form_ThemLoai();
            frm.ShowDialog();
        }

        private void btn_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_Loai.OptionsBehavior.Editable = true;
        }

      
        private void cbo_Maloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sql = dataBase.DataReader("select * from Loai where MaLoai= '" + cbo_Maloai.SelectedValue.ToString() + "'");
            if (sql.Rows.Count > 0)
            {
                gc_Loai.DataSource = sql;
            }
        }

        private void cbo_Maloai_Click(object sender, EventArgs e)
        {
            cbofunction.FillCombobox(cbo_Maloai, dataBase.DataReader("select * from Loai"), "TenLoai", "MaLoai");

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            cbo_Maloai.Text = "";
            dataLoad();
        }

        private void gv_Loai_ShowingEditor(object sender, CancelEventArgs e)
        {
            editValueFunction.CheckColumnAndRowsEditNow(sender);
        }

        private void gv_Loai_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            editValueFunction.UpdateValue("Loai", "MaLoai", gv_Loai, gc_Loai);
        }
    }
}
