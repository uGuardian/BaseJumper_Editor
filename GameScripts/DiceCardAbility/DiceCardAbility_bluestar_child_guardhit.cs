using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_bluestar_child_guardhit : DiceCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_bluestar_child_guardhit()
	{
		throw null;
	}

	public class BattleUnitBuf_BlueStar_Child_Guard_Hit_Ready : BattleUnitBuf
	{
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
		public BattleUnitBuf_BlueStar_Child_Guard_Hit_Ready()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_BlueStar_Child_Guard_Hit : BattleUnitBuf
	{
		private const int _bDmg = 2;

		public override bool Hide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_BlueStar_Child_Guard_Hit()
		{
			throw null;
		}
	}
}
