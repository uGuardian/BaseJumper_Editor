using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_bloodbath3 : EmotionCardAbilityBase
{
	private const int _dmgMin = 3;

	private const int _dmgMax = 10;

	private const int _maxStack = 3;

	private BattleUnitModel _target;

	private int _stack;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetCounter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ability()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_bloodbath3()
	{
		throw null;
	}

	public class BloodBath_HandDebuf : BattleUnitBuf
	{
		protected override string keywordIconId
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BloodBath_HandDebuf()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnHit()
		{
			throw null;
		}
	}
}
