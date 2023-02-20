using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect : MonoBehaviour
{
	public bool isRunning;

	public Animator animator;

	[SerializeField]
	protected FarAreaEffect.EffectState state;

	protected BattleUnitModel _self;

	protected bool _isDoneEffect;

	public bool IsDoneEffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual bool HasIndependentAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GiveDamageFromManager(List<BattleUnitModel> damagedUnitList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEffectStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAnimEvent(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAnimSoundEvent(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ActionPhase(float deltaTime, BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect()
	{
		throw null;
	}

	protected enum EffectState
	{
		None,
		Start,
		GiveDamage,
		End
	}
}
