using System;
using System.Runtime.CompilerServices;
using Sound;

public class PassiveAbility_205321 : PassiveAbilityBase
{
	private const int _ANGELA_ID = 9020511;

	private const float _RECITAL_DMG_RATIO = 0.3f;

	private int _waitCount;

	private BattleUnitModel _recitalTarget;

	private PassiveAbility_205321.Phase _curPhase;

	private SoundEffectPlayer _loopSound;

	public override bool isInvincible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

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
	public PassiveAbility_205321()
	{
		throw null;
	}

	public PassiveAbility_205321.Phase CurPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetRecitalUnit(BattleUnitModel unit)
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
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecitalAlly()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NeedRecitalPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayRecitalPhase()
	{
		
	}

	public enum Phase
	{
		None,
		NeedRecital,
		PlayRecital
	}
}
