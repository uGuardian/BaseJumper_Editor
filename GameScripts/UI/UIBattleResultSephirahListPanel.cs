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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUsedFloor(List<SephirahType> usedsep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAddWaveData(StageModel stage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRectSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSepSlot(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartRevealFloor()
		{
			throw null;
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
