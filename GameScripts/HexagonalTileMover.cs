using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HexagonalTileMover
{
	public bool isArrived;

	public float speedFactor;

	private BattleUnitModel _self;

	private int _curPathIdx;

	private Vector3 _finalDest;

	private bool _direct;

	private bool _toTarget;

	private float _speed;

	private bool _init;

	public bool isKnockback;

	public bool IsCollideWithWall;

	private bool _ignoreKnockbackCollision;

	private bool _isParrying;

	private Vector3 _departurePos;

	private float _knockbackEnergy;

	private bool _bCollideWithWall;

	private float _elapsedKnockback;

	private float _craterValue;

	private Vector3 _finalDestAfterKnockback;

	private bool _moveAfterKnockback;

	private BattleUnitModel _target;

	private float _originSpeed;

	private BattleEffectSound _crashSound;

	private bool canCreateScratch;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HexagonalTileMover(BattleUnitModel model)
	{
		throw null;
	}

	public float MoveSpeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnToFormation(int round)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnToFormationByBlink(bool ignoreView = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Knockback(BattleUnitModel attacker, float energy, float speed, float craterValue, bool noRotation = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Move(BattleUnitModel target, float speed = 10f, bool moveMotion = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Move(Vector3 pos, float speed = 10f, bool moveMotion = true, bool ignoreWall = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalcBlinkDst(Vector3 dst)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Blink(Vector3 dst)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveSlow(bool slow)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdate(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateKnockback()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RefreshPath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EmptyCell()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 CalcMoveDst(BattleUnitModel self, BattleUnitModel mainTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetDistanceBetweenDstAndTarget(BattleUnitModel self, BattleUnitModel mainTarget)
	{
		throw null;
	}
}
