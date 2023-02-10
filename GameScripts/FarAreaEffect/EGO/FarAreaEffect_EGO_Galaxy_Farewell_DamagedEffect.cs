using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Galaxy_Farewell_DamagedEffect : MonoBehaviour
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _damagedSound;

	[SerializeField]
	private Transform _boomSpriteTransform;

	[SerializeField]
	private Animator _animator;

	private float _startDelay;

	private float _elapsed;

	private bool _bStart;

	private BattleFarAreaPlayManager.VictimInfo _target;

	private bool _bArrived;

	private bool _bDone;

	private bool _bDamaged;

	public bool IsDone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsArrived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsDamaged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleFarAreaPlayManager.VictimInfo Victim
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleFarAreaPlayManager.VictimInfo target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Damaged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMoveAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDamagedAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_Galaxy_Farewell_DamagedEffect()
	{
		throw null;
	}
}
