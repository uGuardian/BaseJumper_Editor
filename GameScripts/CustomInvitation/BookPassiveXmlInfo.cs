using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BookPassiveXmlInfo
	{
		[XmlAttribute("Pid")]
		public string pid;

		[XmlText]
		public int passiveId;

		[XmlIgnore]
		public bool isWorkshop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookPassiveXmlInfo()
		{
			throw null;
		}
	}
}
