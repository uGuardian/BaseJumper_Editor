using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICharacterList : MonoBehaviour
	{
		[SerializeField]
		private UICharacterListPanel panel;

		public List<UICharacterSlot> slotList;

		[SerializeField]
		private Image highlightFrame;

		[HideInInspector]
		public UICharacterSlot currentSelectedSlot;

		[HideInInspector]
		public bool isSelectableList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect(UICharacterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitEnemyList(List<UnitDataModel> unitList, bool Selectable, UIStoryLine story = UIStoryLine.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitBattleEnemyList(List<UnitBattleDataModel> unitList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitNotClearEnemyList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitLockEnemyList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitLibrarianList(List<UnitDataModel> unitList, SephirahType sephirah, bool Selectable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitUnitListFromBattleData(List<UnitBattleDataModel> dataList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlockRaycast(bool block)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseCurrentSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectableDownNavigation(UICustomSelectable down)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectableUpNavigation(UICustomSelectable up)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterList()
		{
			throw null;
		}
	}
}
