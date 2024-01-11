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

namespace QL_CuaHang.Forms
{
    public partial class Form_ThemLoai : DevExpress.XtraEditors.XtraForm
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public Form_ThemLoai()
        {
            InitializeComponent();
            LoadUserControl();
        }
        protected void LoadUserControl()
        {
            formLoadControll.UIThemLoaiLoader(mainPanel);
        }
    }
}
