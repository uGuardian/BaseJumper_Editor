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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FX_Script_Kimsatgat()
	{
		throw null;
	}
}
