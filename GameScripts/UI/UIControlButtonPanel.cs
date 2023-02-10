using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIControlButtonPanel : UIPanel
	{
		[SerializeField]
		private Animator panelAnim;

		[SerializeField]
		private List<UIMenuItem> menuItems;

		public new CanvasGroup cg;

		[SerializeField]
		private UICustomSelectablePanel selectablePanel;

		private bool isPanelAlwaysActive;

		private bool isPanelOpened;

		private float panelHeight_includeMenu;

		private float panelHeight_excludeMenu;

		[Header("Tutorial")]
		[SerializeField]
		private GameObject ob_tutorialHighlightFrame;

		[SerializeField]
		private Animator anim_tutorialHighlightFrame;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickMainButton(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCallInvtationPhase(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickFeedBookButton(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryArchivesButton(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickManualButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickESCButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateButtons()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeactivePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDeActiveTutorialHighlightFrame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedButton(UIMainMenuTap tapstate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectablePanel GetSelectablePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIControlButtonPanel()
		{
			throw null;
		}
	}
}
