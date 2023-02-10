using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UISephirahStoryPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private List<UIReviewStorySephirahSlot> slotlist;

		[SerializeField]
		private List<UISmallTalkSlot> talkSlotList;

		[Header("Controller")]
		public UICustomSelectablePanel selectabePanel_Left;

		public UICustomSelectablePanel selectabePanel_Right;

		private readonly string talkStoryNameoffset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(bool animstart = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickExitButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealSepSlotInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISephirahStoryPanel()
		{
			throw null;
		}
	}
}
