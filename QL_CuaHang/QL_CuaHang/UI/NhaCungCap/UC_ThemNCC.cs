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

namespace QL_CuaHang.UI.NhaCungCap
{
    public partial class UC_ThemNCC : DevExpress.XtraEditors.XtraUserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        UC_NCC ncc =  new UC_NCC();
        public UC_ThemNCC()
        {
            InitializeComponent();
            txtSdt.MaxLength = 10;
        }
        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable data = dataBase.DataReader("select count(MaNCC) from NhaCungCap");
           
                if(txtTenNcc.Text == "")
                {
                    MessageBox.Show("Bạn cần thêm tên nhà cung cấp");
                    return;
                }
                else
                {
                    if (txtSdt.Text == "")
                    {
                        MessageBox.Show("Bạn cần thêm số điện thoại");
                        return;
                    }
                    else
                    {
                        int sl = int.Parse(data.Rows[0][0].ToString()) + 1;
                        string mancc = "NCC" + CodeConversion.Numbertransfer(sl);
                        string sql = "insert into NhaCungCap values('" + mancc+ "', '" + txtTenNcc.Text + "', '" + txtSdt.Text + "','" + txtDiaChi.Text + "')";
                        dataBase.ChangeData(sql);
                        ncc.UC_NCC_Load(sender, e);
                    }

                }

            ResetData();
        }
      
        private void ResetData()
        {
           
            txtTenNcc.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
        }
        private void btn_Reset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetData();
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
