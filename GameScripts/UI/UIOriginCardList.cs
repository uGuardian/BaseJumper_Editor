using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIOriginCardList : MonoBehaviour, IScrollHandler, IEventSystemHandler
	{
		[Header("Parent")]
		[SerializeField]
		protected Transform transform_CardListRoot;

		[SerializeField]
		protected List<UIOriginCardSlot> slotList;

		protected List<DiceCardItemModel> currentviewCardList;

		protected bool _isDisabled;

		public bool IsDisabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCardsData(List<DiceCardItemModel> cards)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEmptyCardsData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateCardViewList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetDiabledCardListForBluePrimary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOriginCardList()
		{
			throw null;
		}
	}
}
