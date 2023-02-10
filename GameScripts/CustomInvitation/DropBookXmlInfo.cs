using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class DropBookXmlInfo
	{
		[XmlAttribute("ID")]
		public int id;

		[XmlElement("Name")]
		public string name;

		[XmlElement("TextId")]
		public string targetText;

		[XmlElement("BookIcon")]
		public string bookIcon;

		[XmlElement("Chapter")]
		public int chapter;

		[XmlElement("BookValue")]
		public int bookvalue;

		[XmlElement("DropItem")]
		public List<BookDropItemInfo> DropItemList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookXmlInfo()
		{
			throw null;
		}
	}
}
