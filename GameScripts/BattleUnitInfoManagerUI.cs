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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(IList<BattleUnitModel> unitList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseEnterCharacter(BattleUnitModel unit, bool hOvered)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleCharacterProfileUI GetProfileUI(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseClickCharacter(BattleUnitModel unit, bool byPad)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHighlight(BattleUnitModel unit, bool highlight)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayDlg(string str, BattleUnitModel unit, bool isAbnormality, MentalState state)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCharacterProfileAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCharacterProfile(BattleUnitModel unit, Faction faction, float hp, int bp, BattleBufUIDataList bufDataList = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAllCharacterProfile(List<BattleUnitModel> unitList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideAllDialogueWithDelay()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInfoManagerUI()
	{
		throw null;
	}
}
