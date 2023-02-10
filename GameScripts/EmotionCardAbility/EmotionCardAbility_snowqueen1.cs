using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmotionCardAbility_snowqueen1 : EmotionCardAbilityBase
{
	private const float _prob = 0.5f;

	private const int _bindMin = 1;

	private const int _bindMax = 3;

	private const int _dmgMin = 2;

	private const int _dmgMax = 5;

	private static bool Prob
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private static int Bind
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private static int Dmg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWinParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_snowqueen1()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_Snowqueen_Aura : BattleUnitBuf
	{
		private GameObject aura;

		public override bool Hide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDie()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyAura()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Snowqueen_Aura()
		{
			throw null;
		}
	}
}
