using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIReviewStorySephirahSlot : MonoBehaviour
	{
		[SerializeField]
		private List<UIReviewStoryEpSlot> Storyslot;

		[SerializeField]
		private Image sephirahIcon;

		public SephirahType sephirah;

		[SerializeField]
		private TextMeshProUGUI txt_sepText;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Animator anim;

		public bool isOpen;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStory(int epnumber)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealEpSlotInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIReviewStorySephirahSlot()
		{
			throw null;
		}
	}
}
