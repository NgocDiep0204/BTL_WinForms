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
    public partial class UC_ThemLoai : DevExpress.XtraEditors.XtraUserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        public CboFunction cbofunction = new CboFunction();
        public InputConvertFuntions inputConvertFuntions = new InputConvertFuntions();
        private bool _checkDeleteFunction = false;
        public UC_ThemLoai()
        {
            InitializeComponent();
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtTenLoai.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên loại");
                return;
            }
            else
            {
                DataTable dt = dataBase.DataReader("Select count(MaLoai) from Loai");
                int sl = int.Parse(dt.Rows[0][0].ToString()) + 1;
                txtMaLoai.Text = "ML" + CodeConversion.Numbertransfer(sl);
                
                dataBase.ChangeData("insert into Loai values(N'" + txtMaLoai.Text + "', N'" +txtTenLoai.Text + "', N'"+txtGhiChu.Text+"')");
            }
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtGhiChu.Text = "";
        }
        private void btn_reset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenLoai.Text = "";
            txtGhiChu.Text = "";
        }
    }
}
