using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EditValueFunction : BaseFunction
{
    public string GetValueEdited(GridView _gv)
    {
        string enteredValue = _gv.EditingValue.ToString();
        return enteredValue;
    }
    public virtual void UpdateValue(string _tableName, string _columnName, GridView _gv, GridControl _gc)
    {
        // Get cells value of row edited
        string editValue = GetValueEdited(_gv);
        string columnEditNow = _gv.GetRowCellValue(rowHandle, _columnName).ToString();
        if (columnEditNow == "ThanhTien")  return;
        dataBase.ChangeData("update " + _tableName + " set " + this.columnName + "=N'" + editValue + "' where " + _columnName + "=N'" + columnEditNow + "'");
        //DataLoad(_tableName, _gc);
    }
}
