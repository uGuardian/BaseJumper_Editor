using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HyperCard
{
	[Serializable]
	public abstract class CardComponent
	{
		[SerializeField]
		public Card Card;

		public CardProperties Properties
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CardComponent()
		{
			throw null;
		}
	}
}
