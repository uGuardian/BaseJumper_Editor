using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class DiceCardRolls
	{
		[XmlAttribute("D2")]
		public int D2;

		[XmlAttribute("D4")]
		public int D4;

		[XmlAttribute("D6")]
		public int D6;

		[XmlAttribute("D8")]
		public int D8;

		[XmlAttribute("D12")]
		public int D12;

		[XmlAttribute("D20")]
		public int D20;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardRolls()
		{
			throw null;
		}
	}
}
