using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LOR_Localize
{
	public class EmotionCard
	{
		public string cardID;

		public string cardName;

		public List<EmotionCardAbility> abilities;

		public string abilityShortDesc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotionCard()
		{
			throw null;
		}
	}
}
