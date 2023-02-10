using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class AbnormalityCardDialog
	{
		[XmlAttribute("ID")]
		public string id;

		[XmlText]
		public string dialog;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AbnormalityCardDialog()
		{
			throw null;
		}
	}
}
