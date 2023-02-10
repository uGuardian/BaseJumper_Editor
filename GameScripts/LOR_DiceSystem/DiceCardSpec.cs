using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class DiceCardSpec
	{
		[XmlAttribute("Range")]
		public CardRange Ranged;

		[XmlAttribute("Cost")]
		public int Cost;

		[XmlAttribute("Affection")]
		public CardAffection affection;

		[XmlAttribute("EmotionLimit")]
		public int emotionLimit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardSpec Copy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardSpec()
		{
			throw null;
		}
	}
}
