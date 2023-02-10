using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BookDesc
	{
		[XmlAttribute("BookID")]
		public int bookID;

		[XmlElement("BookName")]
		public string bookName;

		[XmlArray("TextList")]
		[XmlArrayItem(typeof(string), ElementName = "Desc")]
		public List<string> texts;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookDesc()
		{
			throw null;
		}
	}
}
