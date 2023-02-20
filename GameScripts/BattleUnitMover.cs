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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMoveDst(Vector3 pos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMoveDir(Vector3 dir)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAcceleration(float accel)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpeed(float speed)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateByFollowing()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Move()
	{
		
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
