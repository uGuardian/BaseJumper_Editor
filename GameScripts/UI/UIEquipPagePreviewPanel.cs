using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIEquipPagePreviewPanel : MonoBehaviour
	{
		[Header("Reference")]
		public RectTransform rect;

		[SerializeField]
		private Graphic[] graphic_Frames;

		[SerializeField]
		private RectTransform[] rect_FrameForSize;

		public CanvasGroup cg;

		public RectTransform rect_Arrow;

		[Header("Stat")]
		[SerializeField]
		private Image img_Portrait;

		[SerializeField]
		private Image img_BookIconGlow;

		[SerializeField]
		private Image img_BookIcon;

		[SerializeField]
		private TextMeshProUGUI txt_BookName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_bookname;

		[SerializeField]
		private UICharacterStatInfoPanel StatsInfo;

		[Header("Passive Received Panel")]
		[SerializeField]
		private TextMeshProUGUI txt_passiveSuccessionTitle;

		[SerializeField]
		private Image img_passiveSuccessionTitleBg;

		[SerializeField]
		private Image[] img_passiveReceivedFrame;

		[SerializeField]
		private CanvasGroup cg_receivedPassiveBookListPanel;

		[SerializeField]
		private List<UIPassiveEquipBookSlot> equipedPassiveBookList;

		[Header("Passive Give Panel")]
		[SerializeField]
		private CanvasGroup cg_givePassiveBookPanel;

		[SerializeField]
		private Image img_givebookFrame;

		[SerializeField]
		private TextMeshProUGUI txt_givebookname;

		[SerializeField]
		private TextMeshProMaterialSetter setter_givebookname;

		[SerializeField]
		private Image img_givebookIconGlow;

		[SerializeField]
		private Image img_givebookIcon;

		[SerializeField]
		private UICharacterBookSlot giveBookSlot;

		[Header("Passive")]
		[SerializeField]
		private TextMeshProUGUI txt_passiveTitle;

		[SerializeField]
		private Image img_passiveTitleBg;

		[SerializeField]
		private UISetInfoSlotListSc passiveSlotsPanel;

		[Header("Card List")]
		[SerializeField]
		private UIEquipCardList equipedCardListPanel;

		[Header("Controller")]
		[SerializeField]
		private GameObject controllerGuide;

		private BookModel bookDataModel;

		private readonly float originHeight;

		private readonly float wideHeight;

		public bool isActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIEquipCardList EquipedCardListPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveBookInfoPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFrameSize(bool wide)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPagePreviewPanel()
		{
			throw null;
		}
	}
}
