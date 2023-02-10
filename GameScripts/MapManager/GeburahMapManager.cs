using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GeburahMapManager : MapManager
{
	[SerializeField]
	private Transform _upperBorder;

	[SerializeField]
	private SpriteRenderer _bg;

	[SerializeField]
	private AnimationCurve _bgColorCurve;

	[SerializeField]
	private float _elapsed;

	[SerializeField]
	private float _colorSpeed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartUnitMoving()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReviseUpperBorderByCamState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeburahMapManager()
	{
		throw null;
	}
}
