using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIEquipCardList : UIOriginCardList
	{
		[Header("DetailSlot")]
		[SerializeField]
		private UIDetailCardSlot detailSlot;

		[SerializeField]
		private Vector3 targetPosForDetailSlot;

		[SerializeField]
		private Vector3 slotDetailOriginScale;

		[SerializeField]
		private UICustomSelectable selectable;

		private float revealSpeed;

		private float revealCount;

		private Vector3 startScale;

		private Vector3 EndScale;

		private bool isRunningRevealDetailSlot;

		public float startspeed;

		public float endspeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<DiceCardItemModel> cards)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCardEquipedState(List<DiceCardItemModel> currentCards)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDetailSlotByInventory(UIOriginCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideDetailSlotByInventory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckUpdateDetailSlot(UIInvenCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevealDetailSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealDetailSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopRevealCoroutine()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnY_List()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnY_Slot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipCardList()
		{
			throw null;
		}
	}
}
