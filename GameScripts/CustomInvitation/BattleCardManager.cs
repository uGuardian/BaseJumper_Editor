using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CustomInvitation
{
	public class BattleCardManager : MonoBehaviour
	{
		private static BattleCardManager _instance;

		private List<DiceCardXmlInfo> _cardList;

		public static BattleCardManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(List<DiceCardXmlInfo> cardList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleCardManager()
		{
			throw null;
		}
	}
}
