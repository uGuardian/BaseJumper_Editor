using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BattleDialog
	{
		[XmlAttribute("ID")]
		public string dialogID;

		[XmlText]
		public string dialogContent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialog()
		{
			throw null;
		}
	}
}
