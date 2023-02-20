using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_305511 : PassiveAbilityBase
{
	private BattleUnitModel _tempTarget;

	private bool _giveDmg;

	private bool _isTearMouthDead;

	private int _reviveUnitIdx;

	private List<int> _unitIdList;

	private PassiveAbility_305511.BattleUnitBuf_BlackSwanDeadBro _buf;

	private bool _hasSpecialAreaAtkCard;

	private bool _hasSpecialGuardCard;

	private bool _hasSpecialAtkCard;

	private bool _bRevived;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
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
	public override void OnDieOtherUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttackEvent(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AfterGiveDamage(int damage)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetBonusWithNoLegs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetBonusWithNoArms()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetBonusWithNoEars()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GetBonusWithNoEyes()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetBonusWithNoMouth()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetBonusWithTearMouth(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReviveUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetReviveFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_305511()
	{
		throw null;
	}

	public class BattleUnitBuf_BlackSwanDeadBro : BattleUnitBuf
	{
		public override KeywordBuf bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override BufPositiveType positiveType
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

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_BlackSwanDeadBro()
		{
			throw null;
		}
	}
}
