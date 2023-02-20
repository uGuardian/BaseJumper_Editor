using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIGachaSlot : MonoBehaviour
	{
		public UIGachaCardSlot cardSlot;

		public UIGachaEquipSlot equipSlot;

		public UICustomSelectable selectable;

		public Animator animator;

		[HideInInspector]
		public bool isCard;

		private UIGachaResultPopup panel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCard(DiceCardItemModel card, int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCardForBattleResult(DiceCardItemModel card, int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquip(BookModel item, int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlotAll(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartRevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRevealAnimEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGachaSlot()
		{
			throw null;
		}
	}
}
