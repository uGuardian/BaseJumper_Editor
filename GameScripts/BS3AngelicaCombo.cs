using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BS3AngelicaCombo : MonoBehaviour
{
	[SerializeField]
	private BS3_Combo_R_DurandalDown durandalDownEffectRes;

	[SerializeField]
	private BS3_Combo_R_DurandalUp durandalUpEffectRes;

	[SerializeField]
	private BS3_Combo_R_DurandalPenetrate durandalPenetrateEffectRes;

	private BattleUnitView _self;

	private BattleUnitView _target;

	private Vector3 _selfStartPos;

	private Vector3 _targetStartPos;

	public BS3AngelicaCombo.ActionOrder curActionOrder
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
	public void Init(BattleUnitView self, BattleUnitView target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetElapsedTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveCustom(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveWithMace(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveWithAxe(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveWithLance(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BS3AngelicaCombo()
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
