using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;



public class BaseFunction
{

	public DataBase dataBase = new DataBase();
    public virtual void DataLoad(string _tableName ,DevExpress.XtraGrid.GridControl _gc)
    {
        string sl = "select * from "+_tableName+"";
        _gc.DataSource = dataBase.DataReader(sl);
    }

	public string columnName;
	public int rowHandle;
	public void CheckColumnAndRowsEditNow(object _sender)
	{
		ColumnView view = (ColumnView)_sender;

		if (view.FocusedColumn != null && view.FocusedRowHandle >= 0)
		{
			this.columnName = view.FocusedColumn.FieldName;
			this.rowHandle = view.FocusedRowHandle;
			//MessageBox.Show("Đang chỉnh sửa cột: " + this.columnName + ", Dòng: " + this.rowHandle);
		}
	}
	public int CheckRowNow(object _sender)
	{
		ColumnView view = (ColumnView)_sender;
		int _rowHandle = 0;
		if (view.FocusedColumn != null && view.FocusedRowHandle >= 0)
		{
			_rowHandle = view.FocusedRowHandle;
		}
		return _rowHandle;
	}
}
