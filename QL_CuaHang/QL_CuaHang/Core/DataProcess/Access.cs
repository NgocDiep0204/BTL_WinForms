using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Access
{
	#region @@ Singeton
	private static Access _i;

	public static Access I
	{
		get
		{
			if (_i == null)
				_i = new Access();
			return _i;


		}
	}
	#endregion

	public virtual bool QuyenQuanLy()
	{
		switch (DataValues.I.GetTypeAcc)
		{
			case (int)QuyenTruyCap.Quanly:
				return true;
			case (int)QuyenTruyCap.NhanVien: 
				return false;
			default:
				return false;
		}
	}
}
