using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_RedHoodMercenary_Gun : DiceAttackEffect
{
	[SerializeField]
	private SpriteRenderer _targetEffect;

	[SerializeField]
	private SpriteRenderer _bullet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_RedHoodMercenary_Gun()
	{
		throw null;
	}
}
