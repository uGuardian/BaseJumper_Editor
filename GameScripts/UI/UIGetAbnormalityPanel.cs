using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIGetAbnormalityPanel : UIPopup
	{
		private static UIGetAbnormalityPanel _instance;

		[Header("Resources")]
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Image img_bg;

		[SerializeField]
		private Image img_TitleFrame;

		[SerializeField]
		private Image img_floorIcon;

		[SerializeField]
		private Image img_exitFrame;

		[SerializeField]
		private TextMeshProUGUI txt_floorname;

		[SerializeField]
		private TextMeshProUGUI txt_getabcardtxt;

		[SerializeField]
		private TextMeshProUGUI txt_getegocardtxt;

		[SerializeField]
		private TextMeshProUGUI txt_level;

		[SerializeField]
		private TextMeshProUGUI txt_exit;

		[SerializeField]
		private GameObject AbnormalitiesRoot;

		[SerializeField]
		private List<UIEmotionPassiveCardInven> AbnormalityList;

		[SerializeField]
		private GameObject EgoCardsRoot;

		[SerializeField]
		private UIEgoCardList egoCardList;

		[Header("Controller")]
		public UICustomSelectablePanel selectablePanel;

		public UICustomSelectable abpanelSelectable;

		public UICustomSelectable egopanelSelectable;

		[SerializeField]
		private GameObject controllerGuide;

		[Header("Anim Dfault")]
		[SerializeField]
		private _2dxFX_HSV hsv_bg;

		[SerializeField]
		private Image img_blackbg;

		[SerializeField]
		private List<CanvasGroup> cgs;

		[SerializeField]
		private TextMeshProMaterialSetter[] setters;

		[Header("Keter CompleteOpen")]
		[SerializeField]
		private GameObject ob_blackbgForKeterCompleterOpen;

		private LibraryFloorModel currentFloor;

		private SephirahType sep;

		private Color OriginalColor;

		private int currentSettinfCardCount;

		private bool isbinahhokmacompletecheck;

		private bool isShowEgo;

		public static UIGetAbnormalityPanel instance
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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(LibraryFloorModel floor, bool isbinahandhokmalevel6 = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetAbnormalityList(LibraryFloorModel floor, int level)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetEgoCardList(LibraryFloorModel floor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerOverButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerExitButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerClickButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealCardListInAnimEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGetAbnormalityPanel()
		{
			throw null;
		}
	}
}
