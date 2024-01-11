using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;
using HitTestResult = System.Windows.Forms.DataVisualization.Charting.HitTestResult;

namespace QL_CuaHang.UI.DoanhThu
{
	public partial class UC_DoanhThu : DevExpress.XtraEditors.XtraUserControl
	{
		public DataBase dataBase = new DataBase();
		protected string currentMonth = DateTime.Now.Month.ToString();
		protected string currentYear = DateTime.Now.Year.ToString();
		private readonly ToolTip tooltip = new ToolTip();
		public const string DONVI = " VND";
		protected string seriesDoanhThu = "c_DoanhThu";
		protected string seriesChiPhi = "c_ChiPhi";
		protected string seriesLoiNhuan = "c_LoiNhuan";
		protected string seriesLoaiBanChay = "c_LoaiBanChay";
		protected string DONVIBIEUDO = "tr (VND)";

		public UC_DoanhThu()
		{
			InitializeComponent();
		}

		private void UC_DoanhThu_Load(object sender, EventArgs e)
		{
			GetMonth();
			DoanhThuThang();
			NhanVienCuaThang();
			SanPhamBanChay();
			KhachHangCuaThang();
			SoSanPhamBanDuoc();
			LoadChart();
			LoadColumneName();
		}
		protected virtual void LoadColumneName()
		{
			gv_DanhSachSPBan.Columns[0].Caption = "Mã sản phẩm";
			gv_DanhSachSPBan.Columns[1].Caption = "Tên sản phẩm";
			gv_DanhSachSPBan.Columns[2].Caption = "Số lượng";
			gv_DanhSachSPBan.Columns[3].Caption = "Đơn giá bán";
			gv_DanhSachSPBan.Columns[4].Caption = "Thành tiền";
		}

		protected virtual void GetMonth()
		{
			lb_TDLoiNhuan.Text = "Doanh thu tháng " + this.currentMonth;
			lb_TDNV.Text = "Nhân viên của tháng " + this.currentMonth;
			lb_TDSP.Text = "Sản phẩm bán chạy tháng " + this.currentMonth;
			lb_TDKH.Text = "Khách hàng của tháng " + this.currentMonth;
		}
		protected virtual string GetProc(string _proc)
		{
			string sl = "EXEC " + _proc + " @Month = " + this.currentMonth + ", @Year = " + this.currentYear + ";";
			return sl;
		}
		protected virtual string GetProcTheoNam(string _proc)
		{
			string sl = "EXEC " + _proc + " @Year = " + this.currentYear + ";";
			return sl;
		}
		protected virtual string GetProcTheoThang(string _proc)
		{
			string sl = "EXEC " + _proc + " @Thang = " + this.currentMonth + ";";
			return sl;
		}
		protected virtual string GetProcTheo3Thang(string _proc)
		{
			string sl = "EXEC " + _proc + " @Year = " + this.currentYear + ", @NumberOfMonths = " + 3 + ";";
			return sl;
		}
		protected virtual void DoanhThuThang()
		{
			DataTable dt = dataBase.DataReader(GetProc(DataTbName.GET_DOANHTHUTHEOTHANG));
			if (dt.Rows.Count <= 0) return;
			string doanhThu = dt.Rows[0][1].ToString();
			lb_LoiNhuan.Text = doanhThu + DONVI;
		}
		protected virtual void NhanVienCuaThang()
		{
			DataTable dt = dataBase.DataReader(GetProc(DataTbName.GET_NHANVIENCUATHANG));
			if (dt.Rows.Count <= 0) return;
			string name = dt.Rows[0][0].ToString();
			string doanhThu = dt.Rows[0][1].ToString();
			lb_TenNV.Text = name;
			lb_DoanhThuNV.Text = doanhThu + DONVI;
		}
		protected virtual void SanPhamBanChay()
		{
			DataTable dt = dataBase.DataReader(GetProc(DataTbName.GET_SANPHAMBANCHAY));
			if (dt.Rows.Count <= 0) return;
			string name = dt.Rows[0][1].ToString();
			string soluong = dt.Rows[0][2].ToString();
			string maSP = dt.Rows[0][0].ToString();
			lb_TenSP.Text = name;
			lb_MaSP.Text = maSP;
			lb_SoLuongBan.Text = "Số lượng "+ soluong;
		}
		protected virtual void KhachHangCuaThang()
		{
			DataTable dt = dataBase.DataReader(GetProc(DataTbName.GET_KHACHHANGCUATHANG));
			if (dt.Rows.Count <= 0) return;
			string name = dt.Rows[0][1].ToString();
			string soluong = dt.Rows[0][2].ToString();
			lb_TenKH.Text = name;
			lb_TienChi.Text = soluong + DONVI;
		}
		protected virtual void SoSanPhamBanDuoc()
		{
			lb_DanhSachBanDuoc.Text = "Danh sách sản phẩm bán được trong tháng " + this.currentMonth;
			DataTable dt = dataBase.DataReader(GetProc(DataTbName.GET_SANPHAMDABANTRONGTHANG));
			if (dt.Rows.Count <= 0) return;
			gc_DanhSachSPBan.DataSource = dt;
		}
		

		private void LoadChart()
		{
			try
			{
				LoadChartSeries(DataTbName.GET_DANHSACHDOANHTHUTHEONAM, seriesDoanhThu);
				LoadChartSeries(DataTbName.GET_DANHSACHCHIPHITHEONAM, seriesChiPhi);
				LoadChartSeries(DataTbName.GET_DANHSACHLOINHUANTHEONAM, seriesLoiNhuan);
				LoadChartLoai();
			} catch (SqlException ex) { }


			// Tùy chỉnh Chart
			c_LoiNhuan.Titles["title_LoiNhuan"].Text = "Biểu đồ thống kê năm " + this.currentYear;
			c_LoiNhuan.ChartAreas[0].AxisX.Title = "Tháng";
			c_LoiNhuan.ChartAreas[0].AxisY.Title = DONVIBIEUDO;
			c_LoiNhuan.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
			c_LoiNhuan.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
			c_LoiNhuan.MouseMove += ChartDonut_MouseMove;
			c_LoiNhuan.MouseLeave += ChartDonut_MouseLeave;
		}
		private void ChartDonut_MouseMove(object sender, MouseEventArgs e)
		{
            // Lấy thông tin về điểm đang được chọn trên biểu đồ
            HitTestResult result = c_LoiNhuan.HitTest(e.X, e.Y);

			// Kiểm tra xem có phải là một điểm trên biểu đồ không
			if (result.ChartElementType == ChartElementType.DataPoint)
			{
				// Lấy giá trị của DataPoint
				string seriesName = c_LoiNhuan.Series[result.Series.Name].Name.ToString();
				if (seriesName == this.seriesDoanhThu)
				{
					GetGiaTriCotBieuDo(0, result, e);
				}
				else if (seriesName == this.seriesChiPhi)
				{
					GetGiaTriCotBieuDo(1, result, e);
				}
				else if (seriesName == this.seriesLoiNhuan)
				{
					GetGiaTriCotBieuDo(2, result, e);
				}
			}
		}

		protected virtual void GetGiaTriCotBieuDo(int _viTri, HitTestResult _result , MouseEventArgs _e)
		{
			string ten = c_LoiNhuan.Series[_viTri].LegendText.ToString();
			DataPoint dataPoint = c_LoiNhuan.Series[_viTri].Points[_result.PointIndex];
			// Hiển thị giá trị bằng ToolTip
			tooltip.Show($"{ten}: {dataPoint.YValues[0]}{DONVIBIEUDO} ", c_LoiNhuan, _e.Location.X, _e.Location.Y - 15);
		}

		private void ChartDonut_MouseLeave(object sender, EventArgs e)
		{
			// Ẩn ToolTip khi chuột rời khỏi biểu đồ
			tooltip.Hide(c_LoiNhuan);
		}
		protected virtual void LoadChartLoai()
		{
			c_LoaiBanChay.Titles[0].Text = "Các loại sản phẩm tháng " + this.currentMonth;
			DataTable dt = dataBase.DataReader(GetProcTheoThang(DataTbName.GET_LOAIDUOCBANTHEOTHANG));
			if (dt.Rows.Count <= 0) return;
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				int soluong = int.Parse(dt.Rows[i][1].ToString());
				string typeName = dt.Rows[i][0].ToString();
				int quantity = Convert.ToInt32(soluong);
				DataPoint dataPoint = new DataPoint
				{
					LegendText = typeName,
					Label = $"{typeName} ({quantity})",
					YValues = new double[] { quantity }
				};
				c_LoaiBanChay.Series[seriesLoaiBanChay].Points.Add(dataPoint);
			}
		}

		protected virtual void LoadChartSeries(string _proc, string _seriesName)
		{
			DataTable dt = dataBase.DataReader(GetProcTheoNam(_proc));
			if (dt.Rows.Count <= 0) return;
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				long doanhThu = long.Parse(dt.Rows[i][1].ToString()) / 1000000;
				c_LoiNhuan.Series[_seriesName].Points.AddXY(i + 1, doanhThu);
			}
		}

	}

}
