using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class InputConvertFuntions
{
	public virtual byte[] ImageToByteArray(PictureEdit pictureEdit)
	{
		if (pictureEdit.Image == null)
			return null;

		using (MemoryStream memoryStream = new MemoryStream())
		{
			pictureEdit.Image.Save(memoryStream, pictureEdit.Image.RawFormat);
			return memoryStream.ToArray();
		}
	}

	public Image ByteArrayToImage(byte[] _byte)
	{
		return Image.FromStream(new MemoryStream(_byte));
	}	
}
