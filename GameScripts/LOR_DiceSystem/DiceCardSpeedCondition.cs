using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class DiceCardSpeedCondition
	{
		[XmlAttribute("Geq")]
		public int Geq;

		[XmlAttribute("Leq")]
		public int Leq;

		[XmlAttribute("Equal")]
		public int Equal;

		[XmlAttribute("Odd")]
		public int Odd;

		[XmlAttribute("Even")]
		public int Even;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardSpeedCondition()
		{
			throw null;
		}
	}
}
