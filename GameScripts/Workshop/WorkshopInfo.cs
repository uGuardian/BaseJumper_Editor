using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workshop
{
	public class WorkshopInfo
	{
		[XmlElement("ID")]
		public string uniqueId;

		[XmlElement("Title")]
		public string title;

		[XmlElement("Description")]
		public string desc;

		[XmlElement("Tag")]
		public string tag;

		[XmlElement("PreviewImage")]
		public string previewImgAbsPath;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorkshopInfo()
		{
			throw null;
		}
	}
}
