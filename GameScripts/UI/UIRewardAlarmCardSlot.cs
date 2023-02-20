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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(DiceCardItemModel cardmodel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshNumbersData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealCard()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefaultPrevStart()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartVibe()
		{
			
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
