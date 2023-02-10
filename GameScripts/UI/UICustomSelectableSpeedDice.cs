using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_BattleUnit_UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UICustomSelectableSpeedDice : UICustomSelectable
	{
		[SerializeField]
		private SpeedDiceSetter _speedDiceSetter;

		[SerializeField]
		private SpeedDiceUI _speedDiceUI;

		[SerializeField]
		private BattleUnitView _unitView;

		private List<BattleUnitModel> _connectedSelectables;

		private List<UICustomSelectableSpeedDice> _connectedSelectableDiceList;

		public BattleUnitView unitView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public SpeedDiceUI diceUI
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private Vector2 UIPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivatedCharacters(List<BattleUnitModel> list)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnMove(AxisEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMove_character(AxisEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMove_speedDiceAllVer(AxisEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMove_speedDice(MoveDirection moveDir)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSelect(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectableSpeedDice()
		{
			throw null;
		}
	}
}
