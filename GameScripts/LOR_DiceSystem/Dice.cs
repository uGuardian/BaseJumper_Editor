using System;
using System.Runtime.CompilerServices;

namespace LOR_DiceSystem
{
	public class Dice
	{
		public int min;

		public int value;

		public int faces;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dice()
		{
			throw null;
		}
	}
}
