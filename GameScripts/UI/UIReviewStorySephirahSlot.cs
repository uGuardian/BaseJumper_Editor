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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStory(int epnumber)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealEpSlotInAnim()
		{
			
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
