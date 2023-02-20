using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class BattleUnitInformationUI_Passive : MonoBehaviour
{
	public TextMeshProUGUI txt_passive;

	public List<BattleUnitInformationUI_PassiveDesc> passiveDescList;

	public BattleUnitInformationUI_Tab[] tabs;

	public Color tabTextColor;

	private List<BattleUnitInformationUI.Desc> _curUnitsDescList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPassives(List<BattleUnitInformationUI.Desc> passives)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_Tab.TabState OnTabEvent(int tabIdx, int mouseState)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_Passive()
	{
		throw null;
	}
}
