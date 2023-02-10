using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TwistedArgaliaDeadAction : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _movingCurve;

	[SerializeField]
	private float _moveDelay;

	[SerializeField]
	private GameObject _fadeOutEffect;

	private BattleUnitView _roland;

	private BattleUnitView _argalia;

	private float _elapsed;

	private Vector3 _startPos;

	public bool DoneAction
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
	public void Init(BattleUnitView roland, BattleUnitView argalia)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveCustom(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TwistedArgaliaDeadAction()
	{
		throw null;
	}
}
