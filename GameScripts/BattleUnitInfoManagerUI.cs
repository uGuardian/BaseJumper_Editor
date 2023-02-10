using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BattleCharacterProfile;
using UnityEngine;

public class BattleUnitInfoManagerUI : MonoBehaviour
{
	[Header("Profile List")]
	[SerializeField]
	private Transform allyPanel;

	[SerializeField]
	private Transform enemyPanel;

	public BattleCharacterProfileUI[] allyProfileArray;

	public BattleCharacterProfileUI[] enemyProfileArray;

	[Header("Act")]
	public BattleActUI battleActUI;

	public BattleFloorEndUI battleFloorEndUI;

	public BattleFinalEndUI battleFinalEndUI;

	[Header("Tooltip")]
	public BattleUnitInformationUI_Tooltip tooltip;

	private Direction allyDirection;

	public BattleCharacterProfileUI[] allyarray;

	public BattleCharacterProfileUI[] enemyarray;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableCanvas(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(IList<BattleUnitModel> unitList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseEnterCharacter(BattleUnitModel unit, bool hOvered)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleCharacterProfileUI GetProfileUI(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseClickCharacter(BattleUnitModel unit, bool byPad)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHighlight(BattleUnitModel unit, bool highlight)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayDlg(string str, BattleUnitModel unit, bool isAbnormality, MentalState state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCharacterProfileAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCharacterProfile(BattleUnitModel unit, Faction faction, float hp, int bp, BattleBufUIDataList bufDataList = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAllCharacterProfile(List<BattleUnitModel> unitList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideAllDialogueWithDelay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInfoManagerUI()
	{
		throw null;
	}
}
