using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang.UI.MainScreen
{
	public partial class UC_MainScreen : DevExpress.XtraEditors.XtraUserControl
	{

		public UC_MainScreen()
		{
			InitializeComponent();
			LoadPicture();
		}
		protected virtual void LoadPicture()
		{
			string fileAnh = "hinh-nen-cute-co-chu.jpg";
			string imagePath = Path.Combine("D:\\", fileAnh);
			if (File.Exists(imagePath))
			{
			    pictureEdit1.Image = System.Drawing.Image.FromFile(imagePath);
			}
		}
	}
}
