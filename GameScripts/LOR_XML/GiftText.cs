using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class GiftText
	{
		[XmlAttribute("ID")]
		public string id;

		[XmlElement("Name")]
		public string name;

		[XmlElement("Desc")]
		public string desc;

		[XmlElement("Prefix")]
		public string titlePrefix;

		[XmlElement("Postfix")]
		public string titlePostfix;

		[XmlElement("AcquireCondition")]
		public string acquireCondition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GiftText()
		{
			throw null;
		}
	}
}
