using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HyperCard
{
	public class CardCollection : ScriptableObject
	{
		public List<GameObject> Cards;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameObject InstantiateCard(int cardId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardCollection()
		{
			throw null;
		}
	}
}
