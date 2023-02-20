using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleUIInputController : MonoBehaviour
{
	private static BattleUIInputController _instance;

	private List<BattleUnitModel> _selectableUnitList;

	private BattleUnitModel _lastSelected;

	private int _lastSelectedSpeedDiceIndex;

	private BattleUnitModel _lastSelected_enemy;

	private int _lastSelectedSpeedDiceIndex_enemy;

	private BattleUnitModel _lastSelected_librarian;

	private int _lastSelectedSpeedDiceIndex_librarian;

	private BattleUnitModel _lastSelectedTarget;

	private int _lastSelectedTargetSpeedDiceIndex;

	public static BattleUIInputController Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MoveDirection GetBumperButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectSelectableForcely(UICustomSelectable selectable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateLastSelectedDice(UICustomSelectableSpeedDice diceSelectable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCharacterCursor_forError()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCharacterCursor(bool resetLastSelection, bool charSelectionPhase = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dummy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateChracterSlots(bool setFocus, Predicate<BattleUnitModel> seletableCondition = null, bool isCardTarget = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCharacterSlotsNavigation(List<BattleUnitModel> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject GetCurrentSelectedObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectSpeedDice(UICustomSelectableSpeedDice diceSelectable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLBEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRBEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeFactionToRight()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeFactionToLeft()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLTEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRTEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetSlotsNavigation_downToUp(List<UICustomSelectable> selectableList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUIState GetBattleUIState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCursor()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetTargetCursor()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInputStopSpeedDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInputStopSpeedDiceByPad()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInputStopSpeedDiceByKeyboard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInputRencounter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInputBattleStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckInputCardListChange()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsBattleState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUIInputController()
	{
		throw null;
	}
}
