using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICardPanel : UIPanel
	{
		[Header("Left")]
		[SerializeField]
		private UILibrarianEquipDeckPanel _equipInfoDeckPanel;

		[SerializeField]
		private CanvasGroup cg_leftpanel;

		[Header("Center")]
		[SerializeField]
		private UIInvenCardListScroll _invenCardList;

		[SerializeField]
		private UICustomSelectablePanel SelectablePanel_Center;

		[Header("Right")]
		[SerializeField]
		private UILibrarianInfoInCardPhase librarianInfoPanel;

		[Header("EquipInfo")]
		public UICardEquipInfoPanel CardEquipInfoPanel;

		private bool _observerInitialized;

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

		public UILibrarianInfoInCardPhase LibrarianInfoPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLeftPanelCg(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeObserver()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseEnter(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseExit(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenCardEquipInfo(DiceCardItemModel cardInfo, bool _isDeckEditor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardPanel()
		{
			throw null;
		}
	}
}
