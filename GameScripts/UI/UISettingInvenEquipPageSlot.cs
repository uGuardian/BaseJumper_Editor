using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISettingInvenEquipPageSlot : UIOriginEquipPageSlot
	{
		[Header("---Child---")]
		[SerializeField]
		private UISettingEquipPageScrollList listRoot;

		[Header("Equip Character Sprite")]
		[SerializeField]
		private Image img_equipFrame;

		[SerializeField]
		private GameObject ob_equipRoot;

		[SerializeField]
		private CanvasGroup cg_equiproot;

		[SerializeField]
		private FaceEditor faceEditor;

		[Header("Operating Panel")]
		[SerializeField]
		private GameObject ob_OperatingPanel;

		[SerializeField]
		private CanvasGroup cg_operatingPanel;

		[Header("BookMark Button")]
		[SerializeField]
		private UICustomGraphicObject button_BookMark;

		[SerializeField]
		private TextMeshProUGUI txt_bookmarkButton;

		[SerializeField]
		private Image img_bookmarkbuttonIcon;

		[Header("Equip Button")]
		[SerializeField]
		private UICustomGraphicObject button_Equip;

		[SerializeField]
		private TextMeshProUGUI txt_equipButton;

		[SerializeField]
		private Image img_equipbuttonIcon;

		[SerializeField]
		private UICustomGraphicObject button_EmptyDeck;

		[Header("Block Frame")]
		[SerializeField]
		private GameObject ob_blockFrame;

		[SerializeField]
		private Image img_SepIcon;

		private bool isBlock;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetActiveSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetActiveOperatinPanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOperatingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEquipButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEmptyDeckButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBookMarkButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelOperating()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenPanel GetEquipInvenPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingInvenEquipPageSlot()
		{
			throw null;
		}
	}
}
