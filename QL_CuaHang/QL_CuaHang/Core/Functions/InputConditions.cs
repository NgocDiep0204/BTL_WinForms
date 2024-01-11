using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class InputConditions
{
	#region @@ Singeton
	private static InputConditions _i;

	public static InputConditions I
	{
		get
		{
			if (_i == null)
				_i = new InputConditions();
			return _i;
		}
	}
	#endregion

	// Call in TextChanged for use
	public virtual void PhoneNumberChecker(TextEdit _textPhone)
	{
		string inputValue = _textPhone.Text;

		string phoneNumber = new string(inputValue.Where(char.IsDigit).ToArray());

		if (phoneNumber.Length == 10)
		{
			phoneNumber = string.Format("{0:+84 0###-###-###}", long.Parse(phoneNumber));
		}
		else
		{
			_textPhone.Text = " ";
			return;
		}
		_textPhone.Text = phoneNumber;
	}

	// Call in KeyPress for use
	public virtual void NotPressWithChar(KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
		{
			e.Handled = true;
		}
	}
	public virtual void NotPressWithNumb(KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
		{
			e.Handled = true;
		}
	}
}
