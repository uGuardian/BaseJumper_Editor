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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCharacterRenderer(List<UnitDataModel> unitList, bool fromLeft)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCharacterRenderer(List<UnitBattleDataModel> unitList, bool fromLeft)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectValidFirstCharacter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnSelect(UICharacterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshBattleUnitDataModel(UnitDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectableDownNavigation(UICustomSelectable selectableObject)
		{
			throw null;
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
