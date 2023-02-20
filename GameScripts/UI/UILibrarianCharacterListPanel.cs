using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UILibrarianCharacterListPanel : UICharacterListPanel
	{
		[SerializeField]
		private List<UISephirahSelectionButton> SephirahSelectionButtons;

		[Header("Tutorial")]
		[SerializeField]
		private GameObject ob_tutorialhighlightedFrame;

		public event OnSephirahChangedEvent SephirahChangedEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSetSephirah(SephirahType targetSephirah)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSelect(UICharacterSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLibrarianCharacterListPanel_Default(SephirahType targetsephirah)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLibrarianCharacterListPanel_Battle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFrameToSephirah(SephirahType targetSephirah)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFrameToSephirahInBattle(SephirahType targetSephirah)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSephirahSelectionButtons()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSephirahSelectionButtonsInBattle(List<StageLibraryFloorModel> floors)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBattleSettingPanel GetBattleSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UICardPanel GetCardPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIEquipPageInventoryPanel getEquipPagePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianInfoPanel GetLibrarianInfoPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianCharacterListPanel()
		{
			throw null;
		}
	}
}
