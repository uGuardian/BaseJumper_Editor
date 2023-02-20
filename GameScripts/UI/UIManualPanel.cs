using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIManualPanel : UIPopup
	{
		private static UIManualPanel _instance;

		[SerializeField]
		private GameObject panelActiveController;

		[SerializeField]
		private UIManualPopup manualButtonPanel;

		[SerializeField]
		private UIManualContentPanel contentPanel;

		[SerializeField]
		private CanvasGroup[] cgs;

		[SerializeField]
		private Image img_onlycontentbg;

		public Animator revealAnim;

		public UICustomSelectablePanel selectablePanel;

		[Header("Active Button By Condition")]
		[SerializeField]
		private GameObject cardrangefarbutton;

		[SerializeField]
		private GameObject counterattackbutton;

		[SerializeField]
		private List<GameObject> farareabuttons;

		[SerializeField]
		private List<GameObject> passivesuccessionbuttons;

		[SerializeField]
		private GameObject egocardbutton;

		private UIManualPanel.OnNextTutorial _onEndTutorialFunc;

		public Dictionary<UITutorialID, UIManualContentId> tutorialStartDic;

		[HideInInspector]
		public List<UIManualContentId> tutorialList;

		public static UIManualPanel instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetButtonsByCondition()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenOnlyManualContentPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseTutorialPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowContent(UIManualContentId ids)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenTutorialManual(UITutorialID id, bool timestop = true)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenTutorialManual(UITutorialID id, UIManualPanel.OnNextTutorial endfunc)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTutorialID()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualPanel()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIManualPanel()
		{
			throw null;
		}

		public delegate void OnNextTutorial();
	}
}
