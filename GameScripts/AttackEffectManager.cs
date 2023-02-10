using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

public class AttackEffectManager : SingletonBehavior<AttackEffectManager>
{
	public GameObject actionTextPrefab;

	[Header("데미지 폰트 관련 이펙트")]
	public DamageTextEffect damagedTextPrefab;

	public DamageNumber[] damageNumberPrefabs;

	public Color damageTextColor;

	public Color[] damageRwbpTextColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AttackEffectManager()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateActionText(BattleUnitView view, string actionName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateRecoverTextEffect(int recoverAmount, BattleUnitModel unit, int colorType = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDamagedTextEffectWithoutResist(int damage, int colorIdx, BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDamagedTextEffect(int damage, BehaviourDetail detail, BattleUnitModel unit, BattleUnitModel attacker, AtkResist atkResist, bool add, int colorIdx = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEffectSizeByCamZoom(DamageTextEffect effect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEffectSizeByUnitHeight(BattleUnitModel unit, DamageTextEffect effect)
	{
		throw null;
	}
}
