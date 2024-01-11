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
using System.IO;
using QL_CuaHang.UI.KhachHang;
using DevExpress.XtraEditors.Mask.Design;
using System.Windows.Controls.Primitives;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using DevExpress.ClipboardSource.SpreadsheetML;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography.X509Certificates;
using DevExpress.Mvvm.Native;

namespace QL_CuaHang.UI.BanHang
{
    public partial class UC_BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        public CboFunction cbofunction = new CboFunction();
        public InputConvertFuntions inputConvertFuntions = new InputConvertFuntions();
        private Dictionary<string, Label> maSP_Label_Map = new Dictionary<string, Label>();
        private object labelSoLuong;
        private const string DefaultFolderPath = "F:\\BTL_LTTQ\\ql_cuahang\\QL_CuaHang\\QL_CuaHang\\Images";
        public UC_BanHang()
        {
            InitializeComponent();
            

        } 
        private void btnAdd_KH_Click(object sender, EventArgs e)
        {
            Forms.Form_ThemKH form_nhapKH = new Forms.Form_ThemKH();
            form_nhapKH.ShowDialog();
        }
        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            DataLoad();
            UC_Item();
            date_NgayLap.Value = DateTime.Now;
            txtTenNV.Text = DataValues.I.GetTenNV;
            txtMaNV.Text = DataValues.I.GetMaNV;
        }
        public void DataLoad()
        {
            //SinhMa();
            gc_ChiTietHDB.DataSource = dataBase.DataReader("Select SanPham.MaSP, TenSP, SoLuong, GiamGia, ThanhTien from SanPham inner join ChiTietHDB on SanPham.MaSP = ChiTietHDB.MaSP" +
                " where MaHoaDonBan = N'" + txt_MaHDB.Text + "'");

            //DateTime dateNgayLap = Convert.ToDateTime(date_NgayLap.Text.Trim());
            //dataBase.ChangeData("insert into HoaDonBan values('" + txt_MaHDB.Text + "','" + cbo_MaNV.SelectedValue.ToString() + "','"
            //          + string.Format("{0:MM/dd/yyyy}", dateNgayLap) + "','" + cbo_MaKH.SelectedValue.ToString() + "','" + txtTongTien.Text.Trim() + "')");

            gv_ChiTietHDB.Columns[0].Caption = "Mã sản phẩm";
            gv_ChiTietHDB.Columns[1].Caption = "Tên sản phẩm";
            gv_ChiTietHDB.Columns[2].Caption = "Số lượng";
            gv_ChiTietHDB.Columns[3].Caption = "Giảm giá";
            gv_ChiTietHDB.Columns[4].Caption = "Thành tiền";
            gv_ChiTietHDB.OptionsBehavior.Editable = false;

        }
        public void ResetData()
        {
            txt_MaHDB.Text = "";
            cbo_MaKH.Text = "";
            txtMaNV.Text = DataValues.I.GetMaNV;
            txtTenNV.Text = DataValues.I.GetTenNV;
            txtTen_KH.Text = "";
            txtTongTien.Text = "";
            txtTienKhachTra.Text = "";
            txtTienThua.Text = "";
            gc_ChiTietHDB.DataSource = null;
            date_NgayLap.Value = DateTime.Now;
        }     
        private void cbo_MaKH_Click(object sender, EventArgs e)
        {
            cbofunction.FillCombobox(cbo_MaKH, dataBase.DataReader("select * from Khach"), "DienThoai", "MaKhach");
        }
        private void cbo_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sql = dataBase.DataReader("select MaKhach, TenKhach, DienThoai from Khach where MaKhach = '" + cbo_MaKH.SelectedValue.ToString() + "'");
            if (sql.Rows.Count > 0)
            {
                txtTen_KH.Text = sql.Rows[0]["TenKhach"].ToString();
            }
        }
        public void UC_Item()
        {

            string sql = "select * from " + DataTbName.SANPHAM_TABLENAME;
            DataTable dt = dataBase.DataReader(sql);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.White;
                panel.Size = new Size(115, 170);
                panel.Margin = new Padding(5);
                /*panel.Name = "btn"+ dt.Rows[i][0].ToString();
                panel.Click += new System.EventHandler(this.btn_MaSp_click);*/

                Label labelPrice = new Label();
                labelPrice.Name = "lbl_GiaBan";
                labelPrice.Text = dt.Rows[i]["DonGiaBan"].ToString() + " VND";
                labelPrice.Location = new Point(12, 12);
                labelPrice.ForeColor = Color.Gray;

                

                Label labelPriceDiscount = new Label();
                labelPriceDiscount.Name = "lbl_GiamGia";
                int giamgia = int.Parse(dt.Rows[i]["GiamGia"].ToString());
                double thanhtien = double.Parse(dt.Rows[i]["DonGiaBan"].ToString());
                double tt = thanhtien - (thanhtien * giamgia / 100);
                //labelPriceDiscount.Text = "Giá giảm: " + tt.ToString() + " VND";
                labelPriceDiscount.Font = new Font("Tohoma", 8);
                labelPriceDiscount.Location = new Point(12, 135);
                labelPriceDiscount.ForeColor = Color.Red;
                if(int.Parse(dt.Rows[i]["GiamGia"].ToString()) == 0)
                {
                    labelPriceDiscount.Text = "Giá Bán: " + tt.ToString() + " VND";
                    //labelPriceDiscount.Location = new Point(12, 135);
                    //labelPriceDiscount.ForeColor = Color.Red;
                }
                else
                {
                    labelPriceDiscount.Text = "Giảm giá: " + tt.ToString() + " VND";
                    //labelPriceDiscount.Location = new Point(12, 135);
                    //labelPriceDiscount.ForeColor = Color.Red;
                }



                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 120);
                pictureBox.Location = new Point(12, 10);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                //fileAnh = dt.Rows[i]["Anh"].ToString();
                byte[] anh = (byte[])dt.Rows[i]["Anh"];
                if (dt.Rows[i]["Anh"] != null)
                {
                    //string imagePath = Path.Combine(DefaultFolderPath, fileAnh);
                    //if (File.Exists(imagePath))
                    //{
                    //    pictureBox.Image = System.Drawing.Image.FromFile(imagePath);
                    //}
                    //else
                    //{
                    //    pictureBox.Image = null;
                    //}
                    pictureBox.Image = inputConvertFuntions.ByteArrayToImage(anh);

                }

                pictureBox.Name = dt.Rows[i][0].ToString();
                pictureBox.Click += new System.EventHandler(this.btn_MaSp_click);
                //pictureBox.Click += btn_MaSp_click;


                Label labelName = new Label();
                labelName.Name = "lbl_TenSP";
                labelName.Text = dt.Rows[i]["TenSp"].ToString();
                labelName.Location = new Point(12, 110);
                labelName.ForeColor = Color.Gray;

                
                Label labelSoLuong = new Label();
                labelSoLuong.Name = dt.Rows[i][0].ToString();
                labelSoLuong.Text = "SL: " + dt.Rows[i]["SLSanPham"].ToString();
                labelSoLuong.Location = new Point(65, 150);
                labelSoLuong.Font = new Font("Tohoma", 7);
                labelSoLuong.ForeColor = Color.Gray;
                

                Label labelID = new Label();
                labelID.Text = dt.Rows[i]["MaSP"].ToString();
                //
                maSP_Label_Map.Add(dt.Rows[i][0].ToString(), labelSoLuong);
                //
                panel.Controls.Add(labelName);
                pictureBox.Controls.Add(labelPrice);
                panel.Controls.Add(labelSoLuong);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(labelPriceDiscount);
                flowLayout.Controls.Add(panel);
            }
        }
        public void SinhMa()
        {

            if (txt_MaHDB.Text == "")
            {
                string sql = "select count(MaHoaDonBan) from HoaDonBan";
                DataTable data = dataBase.DataReader(sql);
                int shdb = int.Parse(data.Rows[0][0].ToString()) + 1;
                txt_MaHDB.Text = "HDB" + CodeConversion.Numbertransfer(shdb);
                DateTime dateNgayLap = Convert.ToDateTime(date_NgayLap.Text.Trim());
                dataBase.ChangeData("insert into HoaDonBan values('" + txt_MaHDB.Text + "','" + txtMaNV.Text + "','"
                      + string.Format("{0:MM/dd/yyyy}", dateNgayLap) + "','" + cbo_MaKH.SelectedValue.ToString() + "','" + txtTongTien.Text.Trim() + "')");
            }
        }
        private void btn_MaSp_click(object sender, EventArgs e)
        {
            int slcon;
            int soluong;
            PictureBox pictureBox = (PictureBox)sender;
            //Label label = (Label)sender;
            DataTable dtHD = dataBase.DataReader("select * from HoaDonBan where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
            DataTable dt = dataBase.DataReader("select * from SanPham where MaSP = '" + pictureBox.Name + "'");
            DataTable _dt = dataBase.DataReader("select MaSP, SoLuong, ThanhTien from ChiTietHDB where MaSP = '" + pictureBox.Name + "' and MaHoaDonBan = '" + txt_MaHDB.Text + "'");
            if(dtHD.Rows.Count == 0)
            {
                MessageBox.Show("Bạn cần ấn chọn mua hàng trước khi thêm sản phẩm");
                return;
            }
            if (_dt.Rows.Count != 0)
            {              
                soluong = int.Parse(_dt.Rows[0]["SoLuong"].ToString());
                soluong += 1;
                if(int.Parse(dt.Rows[0]["SLSanPham"].ToString()) == 0)
                {
                    MessageBox.Show("Số lượng sản phẩm này không đủ, còn " + dt.Rows[0]["SLSanPham"].ToString());
                }
                else
                {
                    int giaban = int.Parse(dt.Rows[0]["DonGiaBan"].ToString());
                    int giamgia = int.Parse(dt.Rows[0]["GiamGia"].ToString());
                    double thanhtien = giaban * soluong * (1-(giamgia/100));
                    dataBase.ChangeData("update ChiTietHDB set SoLuong = " + soluong + " where MaHoaDonBan ='" + txt_MaHDB.Text + "' and MaSP ='" + _dt.Rows[0]["MaSP"].ToString() + "'");
                    dataBase.ChangeData("update ChiTietHDB set ThanhTien = " + thanhtien + " where MaHoaDonBan ='" + txt_MaHDB.Text + "' and MaSP ='" + _dt.Rows[0]["MaSP"].ToString() + "'");
                    //int tongtien = int.Parse(dtHDB.Rows[0]["TongTien"].ToString()) + int.Parse(_dt.Rows[2]["ThanhTien"].ToString());
                    //txtTongTien.Text = tongtien.ToString();
                    //dataBase.ChangeData("update HoaDonBan set TongTien = " + tongtien + " where MaHoaDonBan = '" + txt_MaHDB.Text + "'");


                    slcon = int.Parse(dt.Rows[0]["SLSanPham"].ToString()) - 1;
                    dataBase.ChangeData("update SanPham set SLSanPham = " + slcon + " where MaSP = '" + pictureBox.Name + "'");
                    DataTable dtHDB = dataBase.DataReader("select TongTien from HoaDonBan where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                    txtTongTien.Text = dtHDB.Rows[0]["TongTien"].ToString();
                    DataTable sl = dataBase.DataReader("select SLSanPham from SanPham where MaSP = '" + pictureBox.Name + "'");                  
                    int SL = int.Parse(sl.Rows[0][0].ToString());
                    if (maSP_Label_Map.ContainsKey(pictureBox.Name))
                    {
                        maSP_Label_Map[pictureBox.Name].Text = "SL: " + SL.ToString();
                    }



                }
            }
            else
            {
                if(int.Parse(dt.Rows[0]["SLSanPham"].ToString()) <= 0)
                {

                    MessageBox.Show("Số lượng sản phẩm này không đủ, còn " + dt.Rows[0]["SLSanPham"].ToString());
                }
                else
                {
                    int giaban = int.Parse(dt.Rows[0]["DonGiaBan"].ToString());
                    int giamgia = int.Parse(dt.Rows[0]["GiamGia"].ToString());
                    int thanhtien = giaban * (1 - giamgia/100);
                    dataBase.ChangeData("insert into ChiTietHDB(MaHoaDonBan, MaSP, SoLuong, ThanhTien) values('" + txt_MaHDB.Text + "','"
                      + pictureBox.Name + "','" + 1 + "', '" + thanhtien.ToString() + "')");
                    slcon = int.Parse(dt.Rows[0]["SLSanPham"].ToString()) - 1;
                    dataBase.ChangeData("update SanPham set SLSanPham = " + slcon + " where MaSP = '" + pictureBox.Name + "'");
                    DataTable dtHDB = dataBase.DataReader("select TongTien from HoaDonBan where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                    txtTongTien.Text = dtHDB.Rows[0]["TongTien"].ToString();
                    DataTable sl = dataBase.DataReader("select SLSanPham from SanPham where MaSP = '" + pictureBox.Name + "'");
                    int SL = int.Parse(sl.Rows[0][0].ToString());
                    if (maSP_Label_Map.ContainsKey(pictureBox.Name))
                    {
                        maSP_Label_Map[pictureBox.Name].Text = "SL: " + SL.ToString();
                    }
                }
            }
            DataTable data = dataBase.DataReader("select SanPham.MaSP, TenSP, SoLuong, GiamGia, ThanhTien from ChiTietHDB inner join SanPham on SanPham.MaSP = ChiTietHDB.MaSP where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
            gc_ChiTietHDB.DataSource = data;
		}
		private void btn_ADD_Click(object sender, EventArgs e)
        {
            if(cbo_MaKH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khách hàng. Nếu chưa có nhấn nút thêm mới");
            }
            else
            {
                if (txt_MaHDB.Text == "")
                {
                    string sql = "select count(MaHoaDonBan) from HoaDonBan";
                    DataTable data = dataBase.DataReader(sql);
                    int shdb = int.Parse(data.Rows[0][0].ToString()) + 1;
                    txt_MaHDB.Text = "HDB" + CodeConversion.Numbertransfer(shdb);
                    DateTime dateNgayLap = Convert.ToDateTime(date_NgayLap.Text.Trim());
                    dataBase.ChangeData("insert into HoaDonBan values('" + txt_MaHDB.Text + "','" + txtMaNV.Text + "','"
                          + string.Format("{0:MM/dd/yyyy}", dateNgayLap) + "','" + cbo_MaKH.SelectedValue.ToString() + "','" + txtTongTien.Text.Trim() + "')");
                }
            }
        }
        private void gv_ChiTietHDB_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá sản phẩm này không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int soluong;
                string masp = gv_ChiTietHDB.GetRowCellValue(e.RowHandle, gv_ChiTietHDB.Columns[0]).ToString();
                DataTable dt = dataBase.DataReader("select * from SanPham where MaSP = '" + masp+ "'");
                DataTable dtSP = dataBase.DataReader("select SLSanPham from SanPham where MaSP = '" + masp + "'");
                DataTable dtCT = dataBase.DataReader("select * from ChiTietHDB where MaHoaDonBan = '"+ txt_MaHDB.Text +"' and MaSP = '"+ masp+"'");
                DataTable dtHD = dataBase.DataReader("select * from HoaDonBan where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                if (int.Parse(dtCT.Rows[0]["SoLuong"].ToString()) <= 1){
                    dataBase.ChangeData("delete ChiTietHDB where MaHoaDonBan = '" + txt_MaHDB.Text + "' and MaSP = '" + masp + "'");
                    int slcon = int.Parse(dtSP.Rows[0]["SLSanPham"].ToString()) +1;
                    dataBase.ChangeData("update SanPham set SLSanPham = " + slcon + " where MaSP = '" + masp + "'");                   
                    DataTable sl = dataBase.DataReader("select SLSanPham from SanPham where MaSP = '" + masp + "'");
                    int SL = int.Parse(sl.Rows[0][0].ToString());
                    if (maSP_Label_Map.ContainsKey(masp))
                    {
                        maSP_Label_Map[masp].Text = "SL: " + SL.ToString();
                    }
                    DataTable dtHDB = dataBase.DataReader("select TongTien from HoaDonBan where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                    txtTongTien.Text = dtHDB.Rows[0][0].ToString();

                }
                else
                {
                    soluong = int.Parse(dtCT.Rows[0]["SoLuong"].ToString());
                    soluong -= 1;
                    int giaban = int.Parse(dt.Rows[0]["DonGiaBan"].ToString());
                    double giamgia = double.Parse(dt.Rows[0]["GiamGia"].ToString()) / 100;
                    double tt = giaban * (1 - giamgia);
                    double thanhtien = double.Parse(dtCT.Rows[0]["ThanhTien"].ToString()) - tt;
                    dataBase.ChangeData("update ChiTietHDB set SoLuong = " + soluong + " where MaHoaDonBan = '" + txt_MaHDB.Text + "' and MaSP = '" + masp + "'");
                    int slcon = int.Parse(dtSP.Rows[0]["SLSanPham"].ToString()) + 1;
                    dataBase.ChangeData("update SanPham set SLSanPham = " + slcon + " where MaSP = '" + masp + "'");
                    dataBase.ChangeData("update ChiTietHDB set ThanhTien = " + thanhtien + " where MaHoaDonBan ='" + txt_MaHDB.Text + "' and MaSP ='" + masp + "'");
                    DataTable dtHDB = dataBase.DataReader("select TongTien from HoaDonBan where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                    txtTongTien.Text = dtHDB.Rows[0]["TongTien"].ToString();
                    DataTable sl = dataBase.DataReader("select SLSanPham from SanPham where MaSP = '"+masp + "'");
                    int SL = int.Parse(sl.Rows[0][0].ToString());
                    if (maSP_Label_Map.ContainsKey(masp))
                    {
                        maSP_Label_Map[masp].Text = "SL: " + SL.ToString();
                    }
                }
                DataTable data = new DataTable();
                data = dataBase.DataReader("select SanPham.MaSP, TenSP, SoLuong, GiamGia, ThanhTien from ChiTietHDB inner join SanPham on SanPham.MaSP = ChiTietHDB.MaSP where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                gc_ChiTietHDB.DataSource = data;
            }
        }
		public virtual string Select_ChiTietHDBTblWithMaHD(string _maHD)
		{
			string sl = "select * from " + DataTbName.CHITIETHDB_TABLENAME + " where MaHoaDonBan = N'" + _maHD + "'";
			return sl;
		}
		public virtual string SelectSP(string _maSp)
		{
			string sl = "SELECT * FROM SanPham where MaSP = N'" + _maSp + "';";
			return sl;
		}
		private void btn_HuyBo_Click(object sender, EventArgs e)
        {
			DataTable dt = dataBase.DataReader(Select_ChiTietHDBTblWithMaHD(txt_MaHDB.Text));
			if (MessageBox.Show("Bạn có muốn huỷ đơn hàng này không?", "Thông báo",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					string maSp = dt.Rows[i]["MaSP"].ToString();
					DataTable dtSP = dataBase.DataReader(SelectSP(maSp));
					int slKho = int.Parse(dtSP.Rows[0]["SLSanPham"].ToString());
					int slHuy = int.Parse(dt.Rows[i]["SoLuong"].ToString());
					int sl = slKho + slHuy;
					string updateSP = "update SanPham set SLSanPham = " + sl + " where MaSP = N'" + maSp + "';";
					dataBase.ChangeData(updateSP);
                    if (maSP_Label_Map.ContainsKey(maSp))
                    {
                        maSP_Label_Map[maSp].Text = "SL: " + sl.ToString();
                    }
                }
				dataBase.ChangeData("delete ChiTietHDB where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                dataBase.ChangeData("delete HoaDonBan where MaHoaDonBan = '" + txt_MaHDB.Text + "'");
                ResetData();
                DataLoad();
			}
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        { 
            DataTable dt = dataBase.DataReader("Select SanPham.MaSP, TenSP, SoLuong, GiamGia, ThanhTien from SanPham inner join ChiTietHDB on SanPham.MaSP = ChiTietHDB.MaSP" +
               " where MaHoaDonBan = N'" + txt_MaHDB.Text + "'");
            DataTable _dt = dataBase.DataReader("select TongTien from HoaDonBan where MaHoaDonBan = '"+txt_MaHDB.Text +"'");
            if (dt.Rows.Count <=0)
            {
                MessageBox.Show("Chưa có sản phẩm nào được thêm!");
                return;
            }
            else
            {
                if (txtTienKhachTra.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập số tiền khách trả");
                    txtTienKhachTra.Focus();
                    return;
                }
                else
                {
                    if (int.Parse(txtTienKhachTra.Text) < int.Parse(_dt.Rows[0][0].ToString()))
                    {
                        MessageBox.Show("Số tiền không đủ");
                        txtTienKhachTra.Focus();
                        return;
                    }
                    else
                    {
                        if (txtTienThua.Text != "")
                        {

                            // txtTienThua.Text = (int.Parse(txtTienKhachTra.Text) - int.Parse(txtTongTien.Text)).ToString();                               
                            SaveFileDialog file = new SaveFileDialog();
                            Excel.Application exApp = new Excel.Application();
                            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1
                                                                                      //Đưa dữ liệu vào file Excel

                            tenTruong.Range["A1:D1"].MergeCells = true;
                            tenTruong.Range["A1"].Value = "CỬA HÀNG BÁN LAPTOP";
                            tenTruong.Range["A2"].Value = "Địa chỉ: Số 3 Đ.Cầu Giấy - Cầu Giấy - Hà Nội";
                            tenTruong.Range["A3"].Value = "Điện thoại: 0999-999-999";
                            tenTruong.Range["c5:f5"].MergeCells = true;
                            tenTruong.Range["C5:F5"].Font.Size = 18;
                            tenTruong.Range["C5:F5"].Font.Color = System.Drawing.Color.Red;
                            tenTruong.Range["C5"].Value = "HÓA ĐƠN BÁN";
                            tenTruong.Range["A7"].Value = "Mã HĐ: " + txt_MaHDB.Text;
                            tenTruong.Range["A8"].Value = "Khách hàng: " + cbo_MaKH.SelectedValue.ToString() + "-" + txtTen_KH.Text;
                            DateTime ngay = date_NgayLap.Value;
                            tenTruong.Range["A9"].Value = "Ngày bán: " + ngay.ToString("dd/MM/yyyy : HH:mm:ss");
                            tenTruong.Range["A10"].Value = "STT ";
                            tenTruong.Range["B10"].Value = "Mã sản phẩm ";
                            tenTruong.Range["C10"].Value = "Tên sản phẩm ";
                            tenTruong.Range["D10"].Value = "Số lượng ";
                            tenTruong.Range["E10"].Value = "Giảm Giá ";
                            tenTruong.Range["F10"].Value = "Thành Tiền";
                            int hang = 10;

                            //DataTable tblChiTiet = dataBase.DataReader("Select tblChiTietHDBan.MaHang,TenHang,tblChiTietHDBan.SoLuong,ThanhTien from tblChiTietHDBan inner join tblHang on tblHang.MaHang=tblChiTietHDBan.MaHang where MaHDBan='" + txtMaHD.Text + "'");
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                hang++;
                                tenTruong.Range["A" + hang.ToString()].Value = (i + 1).ToString();
                                tenTruong.Range["B" + hang.ToString()].Value = dt.Rows[i]["MaSP"];
                                tenTruong.Range["C" + hang.ToString()].Value = dt.Rows[i]["TenSP"];
                                tenTruong.Range["D" + hang.ToString()].Value = dt.Rows[i]["SoLuong"];
                                tenTruong.Range["E" + hang.ToString()].Value = dt.Rows[i]["GiamGia"];
                                tenTruong.Range["F" + hang.ToString()].Value = dt.Rows[i]["ThanhTien"];

                            }
                            tenTruong.Range["C" + (hang + 1).ToString()].Value = "Tổng tiền: " + txtTongTien.Text+ " VND";
                            tenTruong.Range["C" + (hang + 2).ToString()].Value = "Tiền khách trả: " + txtTienKhachTra.Text + " VND";
                            tenTruong.Range["C" + (hang + 3).ToString()].Value = "Tiền thừa : " + txtTienThua.Text + " VND";
                            tenTruong.Range["C" + (hang + 4).ToString()].Value = "Nhân viên bán: " + txtTenNV.Text;

                            exSheet.Name = "HoaDonBan";
                            exBook.Activate();
                            if (file.ShowDialog() == DialogResult.OK)
                                exBook.SaveAs(file.FileName.ToString());
                            exApp.Quit();
                            ResetData();
                        }
                        else
                        {
                            MessageBox.Show("Bạn cần nhấn nút enter để tính tiền thừa");
                            txtTienKhachTra.Focus();
                            return;
                        }

                    }
                    
                }
            }
        }

        private void txtTienKhachTra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTienKhachTra.Text.Length > 0)
                {

                    if (int.Parse(txtTienKhachTra.Text) < int.Parse(txtTongTien.Text))
                    {
                        MessageBox.Show("Số tiền không đủ!");
                    }
                    else
                    {
                        int tienthua = int.Parse(txtTienKhachTra.Text) - int.Parse(txtTongTien.Text);
                        txtTienThua.Text = tienthua.ToString();
                    }
                }
            }
        }
    }

}

       

       
 
