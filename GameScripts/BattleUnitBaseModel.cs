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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetKnockoutInsteadOfDeath(bool alter)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsKnockoutInstaedOfDeath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFixedUpdate(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnFixedUpdateSkill(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDie(bool callEvent = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Damage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AtkStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AtkEnd()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterAttackSuccess(bool killed, BattleUnitModel attackedUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBaseModel()
	{
		throw null;
	}
}
