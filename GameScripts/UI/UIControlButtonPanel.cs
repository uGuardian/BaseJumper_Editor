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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCallInvtationPhase(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickFeedBookButton(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryArchivesButton(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickManualButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickESCButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateButtons()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeactivePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDeActiveTutorialHighlightFrame()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedButton(UIMainMenuTap tapstate)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectablePanel GetSelectablePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIControlButtonPanel()
		{
			throw null;
		}
	}
}
