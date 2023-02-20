using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DamagedEffectManager : SingletonBehavior<DamagedEffectManager>
{
	private static string path;

	[SerializeField]
	private List<ParticleSystem> psList;

	[SerializeField]
	private DamagedBloodEffect bloodEffect;

	[SerializeField]
	private GameObject lowDamageEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected DamagedEffectManager()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateEffect(int damage, float curHp, Vector2 dir, BattleUnitView damagedUnitView, BattleUnitView attackerView)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DamagedEffectManager()
	{
		throw null;
	}
}
