using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataValues
{
	#region @@ Singeton
	private static DataValues _i;

	public static DataValues I
	{
		get
		{
			if (_i == null)
				_i = new DataValues();
			return _i;
		}
	}
	#endregion

	private string getAccount;
	public string GetAccount { get => getAccount; set => getAccount = value; }
	
	private string getMaNV;
	public string GetMaNV { get => getMaNV; set => getMaNV = value; }
	
	private string getTenNV;
	public string GetTenNV { get => getTenNV; set => getTenNV = value; }
	
	private int getTypeAcc;
	public	int GetTypeAcc { get => getTypeAcc; set => getTypeAcc = value; }

}

public enum QuyenTruyCap
{
	Quanly = 1,
	NhanVien = 0
}


