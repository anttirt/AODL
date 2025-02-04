using System;
#if !UNITY_6000_0_OR_NEWER
using System.Drawing;
#endif
using System.IO;

namespace AODL.Document.TextDocuments
{
	public class DocumentPicture
	{
#if !UNITY_6000_0_OR_NEWER
		private System.Drawing.Image _image;
#endif

		private string _imageName;

		private string _imagePath;

#if !UNITY_6000_0_OR_NEWER
		public System.Drawing.Image Image
		{
			get
			{
				return this._image;
			}
			set
			{
				this._image = value;
			}
		}
#endif

		public string ImageName
		{
			get
			{
				return this._imageName;
			}
			set
			{
				this._imageName = value;
			}
		}

		public string ImagePath
		{
			get
			{
				return this._imagePath;
			}
			set
			{
				this._imagePath = value;
			}
		}

		public DocumentPicture()
		{
		}

		public DocumentPicture(string file)
		{
			try
			{
				FileInfo fileInfo = new FileInfo(file);
				this.ImageName = fileInfo.Name;
				this.ImagePath = fileInfo.FullName;
			}
			catch (Exception exception)
			{
				throw;
			}
		}
	}
}