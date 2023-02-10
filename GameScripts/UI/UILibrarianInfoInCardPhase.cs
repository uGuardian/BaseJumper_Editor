using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UILibrarianInfoInCardPhase : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private Graphic[] graphic_Frames;

		[SerializeField]
		private RawImage portrait;

		[SerializeField]
		private Image img_BookIconGlow;

		[SerializeField]
		private Image img_BookIcon;

		[SerializeField]
		private TextMeshProUGUI txt_BookName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_bookname;

		[SerializeField]
		private TextMeshProUGUI txt_passiveTitle;

		[SerializeField]
		private UICharacterStatInfoPanel StatsInfo;

		[SerializeField]
		private UISetInfoSlotListSc passiveSlotsPanel;

		[SerializeField]
		private Toggle toggle_ReleaseToggle;

		[SerializeField]
		private Toggle toggle_ReleaseToggle_Controller;

		[SerializeField]
		private UIEquipCardList equipedCardListPanel;

		[Header("controller")]
		[SerializeField]
		public UICustomSelectable equipPageSelectable;

		public UICustomSelectable PassiveListSelectable;

		public UICustomSelectable BattlePageSelectable;

		private UnitDataModel unitdata;

		[SerializeField]
		private Graphic[] graphic_passivesSlot;

		private bool isDisabledPassiveSuccession;

		private bool isPassiveSelected;

		[SerializeField]
		private Graphic[] graphic_battlepageSlot;

		private bool isBattlePageLock;

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
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshEquipedCards()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDisabledBluePrimary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveSlotColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledPassiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterPassiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitPassiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickPassiveSlot(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBattlePageSlotColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterBattlePageSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitBattlePageSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultBattleCardSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickBattlePageSlot(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterEquipPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitEquipPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickEquipPage(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel GetInvenPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardPanel GetBattlePageInvenPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetReleaseToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickReleaseToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianInfoInCardPhase()
		{
			throw null;
		}
	}
}
