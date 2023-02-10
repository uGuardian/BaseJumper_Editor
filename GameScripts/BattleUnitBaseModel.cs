using System;
using System.Runtime.CompilerServices;

public class BattleUnitBaseModel : BattleObjectModel
{
	public UnitGradeType grade;

	public UnitTargetingCondition targetCondition;

	protected bool _isDeadReal;

	protected bool _isKnockout;

	protected bool _knockoutInsteadOfDeath;

	protected bool _isExtinction;

	private float _elapsedRetargeting;

	private bool _retarget;

	protected bool bCasting;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDead()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDeadReal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsExtinction()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsKnockout()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRetargeting()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterRetargeting()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetKnockoutInsteadOfDeath(bool alter)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsKnockoutInstaedOfDeath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFixedUpdate(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnFixedUpdateSkill(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDie(bool callEvent = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Damage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AtkStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AtkEnd()
	{
		throw null;
	}

	public bool IsCasting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CastSkill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterAttackSuccess(bool killed, BattleUnitModel attackedUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBaseModel()
	{
		throw null;
	}
}
