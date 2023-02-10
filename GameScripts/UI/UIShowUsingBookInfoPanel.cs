using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIShowUsingBookInfoPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[Header("Current Book")]
		[SerializeField]
		private Image img_BookIcon;

		[SerializeField]
		private Image img_BookIconGlow;

		[SerializeField]
		private TextMeshProUGUI txt_bookName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_BookName;

		[SerializeField]
		private UIBookSlot currentDropBookSlot;

		[Header("RewardList")]
		[SerializeField]
		private UIRewardItemList rewardItemList;

		[Header("Reset Reward Button")]
		[SerializeField]
		private UICustomGraphicObject button_rewardResetButton;

		[Header("ForColor")]
		[SerializeField]
		private Graphic[] g_colorTargets;

		public UICustomSelectable SelectablePanel;

		private DropBookXmlInfo xmlinfo;

		public float alphacount;

		public float alphaspeed;

		private bool isrunningAlpha;

		private float startAlpha;

		private float targetAlpha;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultRevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowBookInfoData(DropBookXmlInfo dropBookInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool show)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealAlphaProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickRewardRestButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIShowUsingBookInfoPanel()
		{
			throw null;
		}
	}
}
