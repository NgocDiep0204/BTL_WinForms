using DevExpress.UITemplates.Collection.UserControls;
using DevExpress.XtraEditors;
using QL_CuaHang.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang
{
    public partial class Form_NhapNV : DevExpress.XtraEditors.XtraForm
    {

        public Load_UcControl formLoadControll = new Load_UcControl();

        public Form_NhapNV()
        {
            InitializeComponent();
            LoadUserControl();
        }


        protected void LoadUserControl()
        {
            formLoadControll.UINhapNVLoader(mainPanel);
        }

        private void Form_NhapNV_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}