using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmotionCardAbility_freischutz1 : EmotionCardAbilityBase
{
	private const int _dmgMin = 3;

	private const int _dmgMax = 5;

	private Transform lastkillPos;

	private static int Dmg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetAliveTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnKill(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrintEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_freischutz1()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_Freischutz_Target : BattleUnitBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Freischutz_Target()
		{
			throw null;
		}
	}
}
