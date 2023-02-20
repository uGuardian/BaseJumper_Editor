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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeObserver()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUpdateApearance()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetFrameColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCardEdit()
		{
			
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
