using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIRewardCardList : UIOriginCardList
	{
		[Space(10f)]
		[Header("---Child---")]
		[Header("DetailSlot")]
		[SerializeField]
		private UIDetailCardSlot detailSlot;

		[SerializeField]
		private Vector3 targetPosForDetailSlot;

		[SerializeField]
		private Vector3 slotDetailOriginScale;

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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRewardCard(List<int> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDetailSlotByInventory(UIOriginCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideDetailSlotByInventory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckUpdateDetailSlot(UIInvenCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevealDetailSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealDetailSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopRevealCoroutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIRewardCardList()
		{
			throw null;
		}
	}
}
