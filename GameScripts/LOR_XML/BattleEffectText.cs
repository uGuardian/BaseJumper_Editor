using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BattleEffectText
	{
		[XmlAttribute("ID")]
		public string ID;

		public string Name;

		public string Desc;

		public string OnlyKeyword;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleEffectText()
		{
			throw null;
		}
	}
}
