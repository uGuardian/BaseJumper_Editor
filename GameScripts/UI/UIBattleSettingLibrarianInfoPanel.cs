using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleSettingLibrarianInfoPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Graphic[] graphic_Frames;

		[SerializeField]
		private RawImage portrait;

		[SerializeField]
		private Image img_Unknown;

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
		private Toggle toggle_ReleaseToggle;

		[SerializeField]
		private UICharacterStatInfoPanel StatsInfo;

		public UISetInfoSlotListSc passiveSlotsPanel;

		[SerializeField]
		private UIEquipCardList equipedCardListPanel;

		[Header("Inspector Check")]
		[SerializeField]
		private bool isSephirahPanel;

		[SerializeField]
		private Graphic[] graphic_battlepageSlot;

		private bool isBattlePageLock;

		private bool isEquipPageLock;

		[Header("controller")]
		public UICustomSelectable equipPageSelectable;

		public UICustomSelectable PassiveListSelectable;

		public UICustomSelectable BattlePageSelectable;

		[Header("Keter CompleteOpen")]
		[SerializeField]
		private Image img_BlackSideBG;

		[SerializeField]
		private Sprite[] sp_SideBg;

		private UnitDataModel unitdata;

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
		public void SetData(UnitDataModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSideBg(bool isCompleteOpen)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshEquipedCards()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnKnownData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopProcess()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealProcess()
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
		public void OnPointerClickBattlePageSlot(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBattleCardSlotState()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquipPageSlotColor(Color c)
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
		public void SetEquipPageSlotState()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingPanel GetSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEnemyCharacterListPanel GetEnemyListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingLibrarianInfoPanel()
		{
			throw null;
		}
	}
}
