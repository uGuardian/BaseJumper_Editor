using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_EGO_Angela_Atk : DiceAttackEffect
{
	[SerializeField]
	private Vector3 _customOffset;

	[SerializeField]
	private ActionDetail _actionPivot;

	[SerializeField]
	private AudioClip _additionalSound;

	private Transform _followTransform;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_EGO_Angela_Atk()
	{
		throw null;
	}
}
