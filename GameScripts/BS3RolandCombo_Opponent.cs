using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BS3RolandCombo_Opponent : MonoBehaviour
{
	private BattleUnitView _self;

	private BattleUnitView _attacker;

	private Vector3 _selfStartPos;

	private Vector3 _attackerStartPos;

	public BS3RolandCombo_Opponent.ActionOrder curActionOrder
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public float elapsedTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitView self, BattleUnitView attacker)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetElapsedTime()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveCustom(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Knockback1(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Knockback2(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Knockback3(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BS3RolandCombo_Opponent()
	{
		throw null;
	}

	public enum ActionOrder
	{
		First,
		Second,
		Third,
		End
	}
}
