using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SaveFunction
{
    public DataBase dataBase = new DataBase();
    public virtual bool CheckIsNull(List<string> _infList)
    {
        List<string> infList = new List<string>();
        for (int i = 0; i < _infList.Count; i++)
        {
            infList.Add(_infList[i]);
        }
        foreach (string inf in infList)
        {
            if (IsNullOrSpace(inf))
            {
                CheckIsNull(inf, "Đừng bỏ trống !");
                return true;
            }
        }
        return false;
    }
    public virtual void DataSaver(string _dtInsert)
    {
        dataBase.ChangeData(_dtInsert);
        MessageBox.Show("Đã thêm thành công !");
        //ClearData();
    }
    protected virtual void CheckIsNull(string _text, string _showText)
    {
        if (IsNullOrSpace(_text))
        {
            MessageBox.Show(_showText);
        }
    }

    protected bool IsNullOrSpace(string _text)
    {
        return string.IsNullOrWhiteSpace(_text);
    }

}
