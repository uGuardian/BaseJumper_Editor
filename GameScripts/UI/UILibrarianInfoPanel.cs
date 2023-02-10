using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UILibrarianInfoPanel : UIPanel
	{
		private bool _observerInitialized;

		[Header("InfoPanel")]
		public UILibrarianEquipBookInfoPanel LibrarianEquipBookInfoPanel;

		public UILibrarianAppearanceInfoPanel LibrarianAppearanceInfoPanel;

		public UIEquipCardList cardListPanel;

		public UICustomSelectablePanel SelectablePanel_Center;

		[SerializeField]
		private GraphicBundle Frames;

		private UnitDataModel _selectedUnit;

		private UnitDataModel prevUnit;

		private bool isShowRightInfo;

		public UnitDataModel SelectedUnit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool _isShowRightInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeObserver()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUpdateApearance()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetFrameColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCardEdit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianInfoPanel()
		{
			throw null;
		}
	}
}
