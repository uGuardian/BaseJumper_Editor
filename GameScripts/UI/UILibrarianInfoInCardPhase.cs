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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshEquipedCards()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDisabledBluePrimary()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveSlotColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickPassiveSlot(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBattlePageSlotColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterBattlePageSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitBattlePageSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultBattleCardSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickBattlePageSlot(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterEquipPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitEquipPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickEquipPage(BaseEventData data)
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickReleaseToggle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianInfoInCardPhase()
		{
			throw null;
		}
	}
}
