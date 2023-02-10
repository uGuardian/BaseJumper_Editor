using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
	public class UIEgoCardPanel : MonoBehaviour
	{
		[SerializeField]
		private List<UIEgoCardPreviewSlot> slotList;

		[SerializeField]
		private UIDetailEgoCardSlot detailSlot;

		[SerializeField]
		private Vector3 targetPosForDetailSlot;

		[SerializeField]
		private Vector3 slotDetailOriginScale;

		public float startspeed;

		public float endspeed;

		private float revealSpeed;

		private float revealCount;

		private Vector3 startScale;

		private Vector3 EndScale;

		private bool isRunningRevealDetailSlot;

		[Header("Controller")]
		public UnityEvent XEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(LibraryFloorModel floor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDetailSlotByInventory(UIEgoCardPreviewSlot slot)
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
		public UIEgoCardPreviewSlot GetFirstSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEgoCardPanel()
		{
			throw null;
		}
	}
}
