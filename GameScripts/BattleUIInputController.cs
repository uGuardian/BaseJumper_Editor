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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MoveDirection GetBumperButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectSelectableForcely(UICustomSelectable selectable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateLastSelectedDice(UICustomSelectableSpeedDice diceSelectable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCharacterCursor_forError()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCharacterCursor(bool resetLastSelection, bool charSelectionPhase = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dummy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateChracterSlots(bool setFocus, Predicate<BattleUnitModel> seletableCondition = null, bool isCardTarget = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCharacterSlotsNavigation(List<BattleUnitModel> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject GetCurrentSelectedObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectSpeedDice(UICustomSelectableSpeedDice diceSelectable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLBEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRBEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeFactionToRight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeFactionToLeft()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLTEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRTEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetSlotsNavigation_downToUp(List<UICustomSelectable> selectableList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUIState GetBattleUIState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCursor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetTargetCursor()
	{
		throw null;
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
