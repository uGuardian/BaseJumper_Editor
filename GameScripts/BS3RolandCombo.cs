using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BS3RolandCombo : MonoBehaviour
{
	[SerializeField]
	private BS3_Combo_A_GreatSword greadswordEffectRes;

	[SerializeField]
	private BS3_Combo_A_Shotgun shotgunEffectRes;

	private BattleUnitView _self;

	private BattleUnitView _target;

	private Vector3 _selfStartPos;

	private Vector3 _targetStartPos;

	private float _elapsedBeforeLastAtk;

	public BS3RolandCombo.ActionOrder curActionOrder
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
	private bool MoveWithDurandalUpper(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveWithAngelicaShotgun(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TeleportBackWithDurandalH(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TeleportBackWithDurandalDown(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BS3RolandCombo()
	{
		throw null;
	}

	public enum ActionOrder
	{
		First,
		Second,
		Third,
		Fourth,
		End
	}
}
