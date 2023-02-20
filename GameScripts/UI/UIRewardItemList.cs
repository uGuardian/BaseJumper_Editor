using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIRewardItemList : MonoBehaviour
	{
		[Header("Parent")]
		[SerializeField]
		protected Transform transform_ListRoot;

		[SerializeField]
		protected List<UIRewardEquipPageSlot> equipPageSlotList;

		[SerializeField]
		protected UIRewardCardSlot cardPrefab;

		[SerializeField]
		protected List<UIRewardCardSlot> cardSlotList;

		protected List<UIRewardCardData> currentviewCardList;

		protected List<UIRewardBookData> currentViewBookList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItemsData(List<UIRewardBookData> books, List<UIRewardCardData> cards)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIRewardItemList()
		{
			throw null;
		}
	}
}
