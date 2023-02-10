using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UISettingCardInvenPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[Header("Left")]
		[SerializeField]
		private UILibrarianEquipDeckPanel _equipInfoDeckPanel;

		[Header("Center")]
		[SerializeField]
		private UIInvenCardListScroll _invenCardList;

		[SerializeField]
		private UICustomSelectable FirstSelectable_Center;

		[Header("EquipInfo")]
		[SerializeField]
		public UICardEquipInfoPanel CardEquipInfoPanel;

		public UILibrarianEquipDeckPanel EquipInfoDeckPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIInvenCardListScroll InvenCardList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenCardEquipInfo(DiceCardItemModel cardInfo, bool _isDeckEditor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToCardList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingPanel GetBattleSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingCardInvenPanel()
		{
			throw null;
		}
	}
}
