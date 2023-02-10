using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class PassiveDesc
	{
		[XmlAttribute("ID")]
		public int _id;

		[XmlIgnore]
		public bool isError;

		[XmlIgnore]
		public string workshopID;

		[XmlElement("Name")]
		public string name;

		[XmlElement("Desc")]
		public string desc;

		[XmlIgnore]
		public LorId ID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveDesc()
		{
			throw null;
		}
	}
}
