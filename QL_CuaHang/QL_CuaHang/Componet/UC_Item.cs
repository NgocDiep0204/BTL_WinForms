using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QL_CuaHang.Componet
{
    public partial class UC_Item : UserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        private const string DefaultFolderPath = "F:\\BTL_LTTQ\\ql_cuahang\\QL_CuaHang\\QL_CuaHang\\Images";
        public Image itemImage
        {
            get { return imgItem.Image; }
            set { imgItem.Image = value; }
        }
        public string itemName
        {
            get { return lbl_ItemName.Text; }
            set { lbl_ItemName.Text = value; }
        }
        public string itemPrice
        {
            get { return lbl_ItemPrice.Text; }
            set { lbl_ItemPrice.Text = value; }
        }
        public UC_Item()
        {
            InitializeComponent();
            //lbl_ItemName.Text = 
            string sql = "select * from " + DataTbName.SANPHAM_TABLENAME;
            DataTable dt = dataBase.DataReader(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string fileAnh = dt.Rows[i]["Anh"].ToString();
                if (dt.Rows[i]["Anh"] != null)
                {

                    // string imagePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Images", fileAnh);
                    string imagePath = Path.Combine(DefaultFolderPath, fileAnh);
                    if (File.Exists(imagePath))
                    {
                        imgItem.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        imgItem.Image = null;
                    }
                    //pictureBox.Image = Image.FromFile(imagePath);
                }
                lbl_ItemName.Text = dt.Rows[0]["TenSp"].ToString();
                lbl_ItemName.Tag = dt.Rows[0]["DonGiaBan"].ToString();
            }

            //this.lbl_ItemName.Tag = null;
        }
    }
}
