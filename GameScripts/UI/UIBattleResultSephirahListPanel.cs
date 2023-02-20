using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleResultSephirahListPanel : MonoBehaviour
	{
		[SerializeField]
		private UIBattleResultPanel _rootPanel;

		[SerializeField]
		private RectTransform rect_sephirahslotsroot;

		[SerializeField]
		private List<UISephirahEnemyFloorSlot> sephirahSlotList;

		private UISephirahEnemyFloorSlot currentsepslot;

		public VerticalLayoutGroup vg;

		public RectTransform rect;

		[HideInInspector]
		public UISephirahEnemyFloorSlot _currentsepslot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUsedFloor(List<SephirahType> usedsep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAddWaveData(StageModel stage)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRectSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSepSlot(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartRevealFloor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealFloorRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleResultSephirahListPanel()
		{
			throw null;
		}
	}
}
