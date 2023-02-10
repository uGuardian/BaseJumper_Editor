using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class FX_Script_Kimsatgat : DiceAttackEffect
{
	[Header("Check Inspector")]
	public ActionDetail action;

	[SerializeField]
	private bool isShowDefaultEffect;

	[SerializeField]
	private float destorytime;

	[SerializeField]
	private AudioClip effectSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FX_Script_Kimsatgat()
	{
		throw null;
	}
}
