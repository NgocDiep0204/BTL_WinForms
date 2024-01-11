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
    public partial class Login : Form
    {

        public DataBase dataBase = new DataBase();

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            FormLoginLoad();
        }

        public DataTable DataReader(string _sql)
        {
            DataTable dt = dataBase.DataReader(_sql);
            return dt;
        }
        public virtual string SelectUserAccTable()
        {
            string _sql = "select * from UserAccount where UserName = '" + txt_TaiKhoan.Text + "'and PassWord = '" + txt_MatKhau.Text + "'";
            return _sql;
		}

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int dataCount = DataReader(SelectUserAccTable()).Rows.Count;
            if (dataCount > 0)
            {
                LoadMainForm();
                if (cb_LuuMK.Checked == true) return;
				txt_MatKhau.Text = "";
			}
			else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai rồi");
                FormLoginLoad();
			}
        }

        public void LoadMainForm()
        {
            SetUserValue();
			MainForm mainForm = new MainForm();
			mainForm.ShowDialog();
			//this.Close();
        }

        protected virtual void SetUserValue()
        {
            DataTable dt = DataReader(SelectUserAccTable());
            int typeNV = int.Parse(dt.Rows[0]["TypeAccount"].ToString());
            string maNV = dt.Rows[0][DataTbName.NHANVIEN_KEYNAME].ToString();
			string sl = "SELECT NhanVien.TenNhanVien FROM NhanVien JOIN UserAccount ON NhanVien.MaNhanVien = UserAccount.MaNhanVien WHERE NhanVien.MaNhanVien = N'"+ maNV +"';";
			DataTable _dt = DataReader(sl);
            string tenNV = _dt.Rows[0][0].ToString();
			DataValues.I.GetAccount = txt_TaiKhoan.Text.ToString();
			DataValues.I.GetMaNV = maNV;
            DataValues.I.GetTenNV = tenNV;
            DataValues.I.GetTypeAcc = typeNV;
		}

		public void FormLoginLoad()
        {
            txt_TaiKhoan.Focus();
        }

		private void lb_TaoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Form_NhapNV frm = new Form_NhapNV();
            frm.ShowDialog();
		}
	}
}
