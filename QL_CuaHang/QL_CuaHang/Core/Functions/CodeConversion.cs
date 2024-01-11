using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class CodeConversion
{
    public DataBase dataBase = new DataBase();
    public string AutoCodeConversion(string _tableName, string _codeInit, string _codeBh)
    {
        int id = 1;
        bool dung = false;
        string code = "";
        DataTable dm = new DataTable();
        while (dung == false)
        {
            dm = dataBase.DataReader("Select * from " + _tableName + " where " + _codeBh + "='" + _codeInit +
                Numbertransfer(id) + "'");
            if (dm.Rows.Count == 0)
            {
                dung = true;
            }
            else
            {
                id++;
                dung = false;
            }
        }
        code = _codeInit + Numbertransfer(id);
        return code;
    }

	public static string Numbertransfer(int num)
	{
		if (num < 10)
		{
			return "000" + num;
		}
		else if (num < 100)
		{
			return "00" + num;
		}
		else if (num < 1000)
		{
			return "0" + num;
		}
		else
		{
			return num.ToString();
		}
	}
}

