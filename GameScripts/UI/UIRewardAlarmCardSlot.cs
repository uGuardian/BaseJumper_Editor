using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIRewardAlarmCardSlot : UIOriginCardSlot
	{
		[SerializeField]
		private UIRewardAlarmCardList listPanel;

		[SerializeField]
		private GameObject ob_Number;

		[SerializeField]
		private TextMeshProUGUI txt_Number;

		[SerializeField]
		private RectTransform rect_Vibe;

		[SerializeField]
		private Animator anim;

		[Range(0f, 20f)]
		public float startvibepower;

		public float vibeRunningTime;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(DiceCardItemModel cardmodel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshNumbersData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealCard()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefaultPrevStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartVibe()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator SlotVibeProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIRewardAlarmCardSlot()
		{
			throw null;
		}
	}
}
