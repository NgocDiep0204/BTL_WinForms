using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang.UI.HoaDonBan
{
    public partial class UC_HoaDonBan : UserControl
    {
        public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dataBase = new DataBase();
        public EditValueFunction editValueFunction = new EditValueFunction();
        public DeleteValueFunction deleteValueFunction = new DeleteValueFunction();
        public CboFunction cbofunction = new CboFunction();
        public InputConvertFuntions inputConvertFuntions = new InputConvertFuntions();
        public UC_HoaDonBan()
        {
            InitializeComponent();
            date_Ngay.Format = DateTimePickerFormat.Custom;
            date_Ngay.CustomFormat = "MM/yyyy";
            //date_Ngay.ShowUpDown = true;
        }

        private void UC_HoaDonBan_Load(object sender, EventArgs e)
        {
            DataLoad();
            resetData();
        }
        public void DataLoad()
        {
            DataTable dt = dataBase.DataReader("Select MaHoaDonBan, NhanVien.MaNhanVien, TenNhanVien, MaKhach,NgayBan, TongTien from HoaDonBan inner join NhanVien on " +
                "HoaDonBan.MaNhanVien = NhanVien.MaNhanVien");
            gc_HoaDonBan.DataSource = dt;
            gv_HoaDonBan.Columns[0].Caption = "Mã hoá đơn bán";
            gv_HoaDonBan.Columns[1].Caption = "Mã nhân viên";
            gv_HoaDonBan.Columns[2].Caption = "Tên nhân viên";
            gv_HoaDonBan.Columns[3].Caption = "Mã khách hàng";
            gv_HoaDonBan.Columns[4].Caption = "Ngày bán";
            gv_HoaDonBan.Columns[5].Caption = "Tổng tiền";
            
            gv_HoaDonBan.OptionsBehavior.Editable = false;

            gc_ChiTietHDB.DataSource = dataBase.DataReader("select SanPham.MaSP, TenSP, SoLuong, GiamGia, ThanhTien from ChiTietHDB inner join SanPham on ChiTietHDB.MaSP = " +
                "SanPham.MaSP");
            gv_ChiTietHDB.Columns[0].Caption = "Mã sản phẩm";
            gv_ChiTietHDB.Columns[1].Caption = "Tên sản phẩm";
            gv_ChiTietHDB.Columns[2].Caption = "Số lượng";
            gv_ChiTietHDB.Columns[3].Caption = "Giảm giá";
            gv_ChiTietHDB.Columns[4].Caption = "Thành tiền";
            gv_ChiTietHDB.OptionsBehavior.Editable = false;
            DataTable dataTable = dataBase.DataReader("Select count(MaHoaDonBan) from HoaDonBan");
            int slhd = int.Parse(dataTable.Rows[0][0].ToString());
            lbl_SoLuong.Text = "Số lượng hoá đơn: " + slhd.ToString();
            //string sql = "declare @t money exec TinhTongTien @t output print @t";
            //int data =int.Parse(dataBase.DataReader(sql).ToString());
            //int tongtien = int.Parse(data.Rows[0][0].ToString());
            //lbl_DoanhThu.Text = data.ToString();
        }
        public void resetData()
        {
            cbo_MaKH.Text = "";
            gc_ChiTietHDB.DataSource = null;
            //date_Ngay.Value = (DateTime?)null;
        }
        public void GetInfo()
        {

            DataTable dtSL = dataBase.DataReader("select count(mahoadonban) from HoaDonBan");
            DataTable dt = dataBase.DataReader("Select MaHoaDonBan, NhanVien.MaNhanVien, TenNhanVien, MaKhach,NgayBan, TongTien from HoaDonBan inner join NhanVien on " +
                 "HoaDonBan.MaNhanVien = NhanVien.MaNhanVien");
            int slhd = int.Parse(dtSL.Rows[0][0].ToString());
            lbl_SoLuong.Text = "Số lượng hoá đơn: " + slhd.ToString();
            int tong = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tong += int.Parse(dt.Rows[i]["TongTien"].ToString());
            }
            lbl_DoanhThu.Text = "Tổng tiền :" + tong.ToString();

        }
        private void btn_Show_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_ChiTietHDB.Visible = true;
        }

        private void btn_Shorten_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_ChiTietHDB.Visible = false;
        }

        private void cbo_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sql = dataBase.DataReader("select * from HoaDonBan where MaKhach = '" + cbo_MaKH.SelectedValue.ToString() + "'");
            if (sql.Rows.Count > 0)
            {
                gc_HoaDonBan.DataSource = sql;
                DataTable dtSL = dataBase.DataReader("select count(mahoadonban) from HoaDonBan where MaKhach = '" + cbo_MaKH.SelectedValue.ToString() + "'");
                int slhd = int.Parse(dtSL.Rows[0][0].ToString());
                lbl_SoLuong.Text = "Số lượng hoá đơn: " + slhd.ToString();
                int tong = 0;
                for (int i = 0; i < sql.Rows.Count; i++)
                {
                    tong += int.Parse(sql.Rows[i]["TongTien"].ToString());
                }
                lbl_DoanhThu.Text = "Tổng tiền :" + tong.ToString();
            }
            else
            {
                MessageBox.Show("Không có hoá đơn");
            }
        }

        private void cbo_MaKH_Click(object sender, EventArgs e)
        {
            cbofunction.FillCombobox(cbo_MaKH, dataBase.DataReader("select * from Khach"), "DienThoai", "MaKhach");

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //if (cbo_MaKH.Text == "")
            //{
                DataTable dtSL = dataBase.DataReader("select count(mahoadonban) from HoaDonBan where Month(NgayBan) = '" + date_Ngay.Value.Month + "' and year(NgayBan) = '" + date_Ngay.Value.Year + "'");
                if (dtSL.Rows.Count > 0)
                {
                    DataTable dt = dataBase.DataReader("Select MaHoaDonBan, NhanVien.MaNhanVien, TenNhanVien, MaKhach,NgayBan, TongTien " +
                         "from HoaDonBan " +
                         "inner join NhanVien ON HoaDonBan.MaNhanVien = NhanVien.MaNhanVien " +
                            "where Month(NgayBan) = '" + date_Ngay.Value.Month + "' and year(NgayBan) = '" + date_Ngay.Value.Year + "'");
                    gc_HoaDonBan.DataSource = dt;
                    int tong = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tong += int.Parse(dt.Rows[i]["TongTien"].ToString());
                    }
                    lbl_DoanhThu.Text = "Tổng tiền :" + tong.ToString();
                }
                else
                {
                    MessageBox.Show("Không có hoá đơn");
                }
            //}
            /*else
            {
                DataTable dtSL = dataBase.DataReader("select count(mahoadonban) from HoaDonBan where Month(NgayBan) = '" + date_Ngay.Value.Month + "' and year(NgayBan) = '" + date_Ngay.Value.Year + "' and MaKhach = '" + cbo_MaKH.SelectedValue.ToString() + "'");
                if (dtSL.Rows.Count > 0)
                {
                    DataTable dt = dataBase.DataReader("Select MaHoaDonBan, NhanVien.MaNhanVien, TenNhanVien, MaKhach,NgayBan, TongTien " +
                         "from HoaDonBan " +
                         "inner join NhanVien ON HoaDonBan.MaNhanVien = NhanVien.MaNhanVien " +
                            "where Month(NgayBan) = '" + date_Ngay.Value.Month + "' and year(NgayBan) = '" + date_Ngay.Value.Year + "'");
                    gc_HoaDonBan.DataSource = dt;
                    int tong = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tong += int.Parse(dt.Rows[i]["TongTien"].ToString());
                    }
                    lbl_DoanhThu.Text = "Tổng tiền :" + tong.ToString();
                }
                else
                {
                    MessageBox.Show("Không có hoá đơn");
                }

            }*/


        }
    
        private void gv_HoaDonBan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string mahoadonban = gv_HoaDonBan.GetRowCellValue(e.RowHandle, gv_HoaDonBan.Columns[0]).ToString();
            gc_ChiTietHDB.DataSource = dataBase.DataReader("select SanPham.MaSP, TenSP, SoLuong, GiamGia, ThanhTien from ChiTietHDB inner join SanPham on ChiTietHDB.MaSP = " +
                "SanPham.MaSP where MaHoaDonBan = '" + mahoadonban + "'");
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cbo_MaKH.Text = "";
            //date_Ngay.Value = DateTime.Now;
            gc_HoaDonBan.DataSource = dataBase.DataReader("Select MaHoaDonBan, NhanVien.MaNhanVien, TenNhanVien, MaKhach, NgayBan, TongTien from" +
            " HoaDonBan inner join NhanVien on HoaDonBan.MaNhanVien = NhanVien.MaNhanVien ");
            //DataLoad();
            GetInfo();
        }
    }
}
