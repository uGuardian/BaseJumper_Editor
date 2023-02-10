using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UITitlePanel : UIPanel
	{
		private static string CityState;

		private static string BookList;

		private static string CardList;

		private static string Library;

		private static string floorfeed;

		private static string BookFeed;

		private static string Invitation;

		private static string GameStart;

		private static string Gift;

		private static string Result;

		private static string Custom;

		private static string CustomCoreBook;

		private static string LibrarianInfo;

		private static string battleSetting;

		[SerializeField]
		private CanvasGroup mainTitle;

		[SerializeField]
		private TextMeshProUGUI mainTitleText;

		[SerializeField]
		private UILibrarySliderPanel sliderPanel;

		[SerializeField]
		private CanvasGroup subTitle;

		[SerializeField]
		private TextMeshProUGUI subTitleText;

		[SerializeField]
		private Image img_subtitleFrame;

		[SerializeField]
		private TextMeshProMaterialSetter setter_subtitletext;

		[SerializeField]
		private Animator anim_MainTitle;

		[SerializeField]
		private Animator anim_SubTitle;

		[Header("Guides")]
		[SerializeField]
		private CanvasGroup PCGuide;

		[SerializeField]
		private CanvasGroup ControllerGuide;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhaseTransition(UIPhase prev, UIPhase next)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetMainTitle(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSubTitle(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetOffAllTitle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSubTitleColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickManual()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickESCButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isControllerInput)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITitlePanel()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UITitlePanel()
		{
			throw null;
		}
	}
}
