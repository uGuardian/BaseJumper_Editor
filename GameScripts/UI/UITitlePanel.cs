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
		private void SetMainTitle(string key)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSubTitle(string key)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetOffAllTitle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSubTitleColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickManual()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickESCButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isControllerInput)
		{
			
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
