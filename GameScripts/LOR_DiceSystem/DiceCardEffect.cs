using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class DiceCardEffect
	{
		[XmlAttribute("Start")]
		public string start;

		[XmlAttribute("End")]
		public string end;

		[XmlAttribute("Res")]
		public string resourceName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardEffect()
		{
			throw null;
		}
	}
}
