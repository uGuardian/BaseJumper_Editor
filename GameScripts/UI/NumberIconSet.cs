using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	[Serializable]
	public class NumberIconSet
	{
		public string type;

		public Sprite iconbg;

		public Sprite iconContent;

		public Sprite iconLinear;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NumberIconSet()
		{
			throw null;
		}
	}
}
