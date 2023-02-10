using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class BattleUnitInformationUI_Effects : MonoBehaviour
{
	public TextMeshProUGUI txt_effects;

	public List<BattleUnitInformationUI_PassiveDesc> passiveDescList;

	public BattleUnitInformationUI_Tab[] tabs;

	public Color tabTextColor;

	public Sprite bufIcon;

	public Sprite debufIcon;

	private List<BattleUnitInformationUI.Desc> _curUnitsDescList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEffects(List<BattleUnitInformationUI.Desc> passives)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_Tab.TabState OnTabEvent(int tabIdx, int mouseState)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_Effects()
	{
		throw null;
	}
}
