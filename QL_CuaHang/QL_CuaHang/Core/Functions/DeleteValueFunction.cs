using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
public class DeleteValueFunction : BaseFunction
{
    public virtual void DeleteValue(string _tableName,string _keyName,object _sender, GridView _gv, GridControl _gc)
    {
        GridView view = (GridView)_sender;

        if (view == null) return;
        GridHitInfo hi = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

        if (!hi.InRowCell) return;
        //string cellValue = view.GetRowCellDisplayText(hi.RowHandle, hi.Column);

        //MessageBox.Show("Giá trị ô được double click: " + hi.RowHandle);
        if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        {
            string val = _gv.GetRowCellValue(hi.RowHandle, _keyName).ToString();
            //MessageBox.Show("Giá trị ô được double click: " + val);
            dataBase.ChangeData("delete "+_tableName+" where "+_keyName+"= N'" + val + "'");
            DataLoad(_tableName, _gc);
        }
    }
    public virtual void DeleteValueProc(string _proc,string _keyName, string _collume, object _sender, GridView _gv, GridControl _gc)
    {
        GridView view = (GridView)_sender;

        if (view == null) return;
        GridHitInfo hi = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
		if (!hi.InRowCell) return;
		string cellValue = view.GetRowCellDisplayText(hi.RowHandle, hi.Column);
		try
		{
			//MessageBox.Show("Giá trị ô được double click: " + hi.RowHandle);
			if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				string val = _gv.GetRowCellValue(hi.RowHandle, _keyName).ToString();
				//MessageBox.Show("Giá trị ô được double click: " + val);
				string collume = _gv.GetRowCellValue(hi.RowHandle, _collume).ToString();
				dataBase.DataReader(_proc + "" + _keyName + "= N'" + val + "', @" + _collume + " = " + collume);
				//DataLoad(_tableName, _gc);
			}

		}
        catch (SqlException ex)
		{

        }
    }
}
