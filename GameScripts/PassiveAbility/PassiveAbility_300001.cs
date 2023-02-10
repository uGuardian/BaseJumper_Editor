using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_300001 : PassiveAbilityBase
{
	private bool _tempDead;

	private int _type;

	public override bool isImmortal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isActionable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isTargetable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSadoType(int type)
	{
		
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
	public override void AfterTakeDamage(BattleUnitModel attacker, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnToOriginalUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBattleEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_300001()
	{
		throw null;
	}

	public class BattleUnitBuf_sado : BattleUnitBuf
	{
		public override bool IsControllable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_sado()
		{
			throw null;
		}
	}
}
