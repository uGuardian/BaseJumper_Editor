using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIFilterPanel : UIPanel
	{
		[Header("Reference")]
		[SerializeField]
		private UICustomTabsController librarianMainTapController;

		private readonly Vector2 originGradeFrameSize;

		private readonly Vector2 wideFrameSize;

		private readonly Vector2 battleSettingPosition;

		private readonly Vector2 storyArchivesPosition;

		private readonly Vector2 dropbookfilterpos;

		private bool isrunningReveal;

		private float startalpha;

		private float revealcount;

		public float revealspeed;

		[SerializeField]
		private GameObject ControllerGuide;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhaseTransition(UIPhase prev, UIPhase next)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSummaryTap()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEquipPageTap()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBattlePageTap()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isControllerInput)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFilterPanel()
		{
			throw null;
		}
	}
}
