using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmotionCardAbility_whitenight3 : EmotionCardAbilityBase
{
	private bool _effect;

	private GameObject _aura;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie(BattleUnitModel killer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyAura()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_whitenight3()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_WhiteNight_Mighty : BattleUnitBuf
	{
		private const int _prot = 2;

		private const int _absorb = 3;

		private BattleUnitModel _god;

		public override bool Hide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_WhiteNight_Mighty(BattleUnitModel god)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(BattleUnitModel owner)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDieOtherUnit(BattleUnitModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override double ChangeDamage(BattleUnitModel attacker, double dmg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}
	}
}
