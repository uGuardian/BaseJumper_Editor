using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PassiveAbility_151139 : PassiveAbilityBase
{
	private const int _HAND_CHARACTER_ID = 50040;

	private const string _CHAIN_PREFAB_PATH = "Battle/SpecialEffect/EGO_Yan_HandChainEffect";

	private List<PassiveAbility_151139.ChainInfo> _chainInfoList;

	private bool _bInitChain;

	public override bool isHide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDieOtherUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitChain()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveChain()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveChain(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_151139()
	{
		throw null;
	}

	public class ChainInfo
	{
		public GameObject chainObj;

		public BattleUnitModel chainUnit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChainInfo()
		{
			throw null;
		}
	}
}
