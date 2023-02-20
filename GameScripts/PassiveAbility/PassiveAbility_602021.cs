using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_602021 : PassiveAbilityBase
{
	private bool _bStealth;

	private int _stealthRound;

	private int _dmgTaken;

	private float _stdHp;

	private const float _RATIO = 0.25f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxBpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSpec()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetResistsWeak(bool weak)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDoneStealthFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_602021()
	{
		throw null;
	}

	public class BattleUnitBuf_BigBadWolf_NonActionable : BattleUnitBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_BigBadWolf_NonActionable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(BattleUnitModel owner)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsActionable()
		{
			throw null;
		}
	}
}
