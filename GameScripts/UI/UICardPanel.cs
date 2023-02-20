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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLeftPanelCg(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeObserver()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseEnter(UIPhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseExit(UIPhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenCardEquipInfo(DiceCardItemModel cardInfo, bool _isDeckEditor)
		{
			
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
