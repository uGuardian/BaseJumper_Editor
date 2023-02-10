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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect(UICharacterSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitEnemyList(List<UnitDataModel> unitList, bool Selectable, UIStoryLine story = UIStoryLine.None)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitBattleEnemyList(List<UnitBattleDataModel> unitList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitNotClearEnemyList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitLockEnemyList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitLibrarianList(List<UnitDataModel> unitList, SephirahType sephirah, bool Selectable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitUnitListFromBattleData(List<UnitBattleDataModel> dataList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlockRaycast(bool block)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseCurrentSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectableDownNavigation(UICustomSelectable down)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectableUpNavigation(UICustomSelectable up)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterList()
		{
			throw null;
		}
	}
}
