using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class PassiveDesc
	{
		[XmlAttribute("ID")]
		public int ID;

		[XmlElement("Name")]
		public string name;

		[XmlElement("Desc")]
		public string desc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveDesc()
		{
			throw null;
		}
	}
}
