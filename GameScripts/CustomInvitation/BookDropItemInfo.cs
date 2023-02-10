using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BookDropItemInfo
	{
		[XmlText]
		public int id;

		[XmlAttribute("Pid")]
		public string pid;

		[XmlAttribute("Type")]
		public DropItemType itemType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookDropItemInfo()
		{
			throw null;
		}
	}
}
