using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIInvenEquipPageSlot : UIOriginEquipPageSlot
	{
		[Header("---Child---")]
		[SerializeField]
		private UIEquipPageScrollList listRoot;

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

		[SerializeField]
		private UICustomGraphicObject button_BookMark;

		[SerializeField]
		private TextMeshProUGUI txt_bookmarkButton;

		[SerializeField]
		private Image img_bookmarkbuttonIcon;

		[SerializeField]
		private UICustomGraphicObject button_Equip;

		[SerializeField]
		private TextMeshProUGUI txt_equipButton;

		[SerializeField]
		private Image img_equipbuttonIcon;

		[SerializeField]
		private UICustomGraphicObject button_PassiveSuccession;

		[SerializeField]
		private UICustomGraphicObject button_ReleaseButton;

		[SerializeField]
		private TextMeshProUGUI txt_releaseButton;

		[SerializeField]
		private UICustomGraphicObject button_EmptyDeck;

		[Header("Block")]
		[SerializeField]
		private GameObject ob_blockFrame;

		[SerializeField]
		private Image img_SepIcon;

		private bool isBlock;

		public RectTransform rect_ButtonEquip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetActiveOperatinPanel(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOperatingPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptySlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEquipButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPassiveSuccessionButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickRelaseButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEmptyDeckButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBookMarkButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelOperating()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenEquipPageSlot()
		{
			throw null;
		}
	}
}
