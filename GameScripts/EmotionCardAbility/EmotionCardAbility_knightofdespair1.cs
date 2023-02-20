using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class EmotionCardAbility_knightofdespair1 : EmotionCardAbilityBase
{
	private List<EmotionCardAbility_knightofdespair1.DmgInfo> _dmgInfos;

	private List<EmotionCardAbility_knightofdespair1.DmgInfo> _breakdmgInfos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSelectEmotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeBreakDamageByAttack(BattleDiceBehavior atkDice, int breakdmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_knightofdespair1()
	{
		throw null;
	}

	public class BattleUnitBuf_resists : BattleUnitBuf
	{
		public BehaviourDetail hpTarget;

		public BehaviourDetail bpTarget;

		public override bool Hide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_resists()
		{
			throw null;
		}
	}

	public class DmgInfo
	{
		public BehaviourDetail type;

		public int dmg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DmgInfo()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_Gaho : BattleUnitBuf
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
		public BattleUnitBuf_Gaho()
		{
			throw null;
		}
	}
}
