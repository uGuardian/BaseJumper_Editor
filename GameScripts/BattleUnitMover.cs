using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleUnitMover : MonoBehaviour
{
	[SerializeField]
	private float _speed;

	[SerializeField]
	private Vector3 _direction;

	[SerializeField]
	private float _acceleration;

	[SerializeField]
	private Vector3 _destination;

	private Transform _target;

	private bool _bArrived;

	public bool IsArrived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFollower(Transform t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMoveDst(Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMoveDir(Vector3 dir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAcceleration(float accel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpeed(float speed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateByFollowing()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Move()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckArrived()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitMover()
	{
		throw null;
	}
}
