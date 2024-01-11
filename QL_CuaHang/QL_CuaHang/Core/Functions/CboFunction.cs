using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

public class CboFunction
{
	public DataBase dataBase = new DataBase();
	public void FillCombobox(ComboBox comboName, DataTable data, string displayMember, string vauleMember)
	{
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = vauleMember;
	}
	public virtual void PutValueToComboBox(string _sql, ComboBoxEdit _cb)
	{
		DataTable dt = dataBase.DataReader(_sql);
		List<string> _dsSP = new List<string>();
		if (dt.Rows.Count <= 0) return;
		_dsSP.Clear();
		for (int i = 0; i < dt.Rows.Count; i++)
		{
			_dsSP.Add(dt.Rows[i][0].ToString());
		}
		_cb.Properties.Items.AddRange(_dsSP);
	}

}

