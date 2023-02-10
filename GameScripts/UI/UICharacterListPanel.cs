using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICharacterListPanel : UIPanel
	{
		[Header("Reference")]
		[SerializeField]
		protected GraphicBundle graphics;

		[SerializeField]
		protected UICharacterList CharacterList;

		public UICustomSelectablePanel SelectablePanel;

		private UICustomSelectable downSelectableObject;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCharacterRenderer(List<UnitDataModel> unitList, bool fromLeft)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCharacterRenderer(List<UnitBattleDataModel> unitList, bool fromLeft)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectValidFirstCharacter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnSelect(UICharacterSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshBattleUnitDataModel(UnitDataModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectableDownNavigation(UICustomSelectable selectableObject)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable GetFirstSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterListPanel()
		{
			throw null;
		}
	}
}
