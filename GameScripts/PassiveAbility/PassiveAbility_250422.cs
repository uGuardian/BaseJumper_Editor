using System;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;
using UnityEngine;

public class PassiveAbility_250422 : PassiveAbilityBase
{
	private AudioClip[] _oldEnemytheme;

	private int _roundDamage;

	private bool _egoCancel;

	private string path;

	private CreatureEffect aura;

	private bool _bDoneEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnBreakGageZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AfterGiveDamage(int damage)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetResist()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnKill(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayChangingEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_250422()
	{
		throw null;
	}

	public class BattleUnitBuf_RedMistEgo : BattleUnitBuf
	{
		public override KeywordBuf bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool isAssimilation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_RedMistEgo()
		{
			throw null;
		}
	}
}
