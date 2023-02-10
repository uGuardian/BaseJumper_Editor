using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Yan_ChainCurve : MonoBehaviour
{
	public int posCount;

	[SerializeField]
	private Yan_ChainParticle _particleObj;

	[SerializeField]
	private LineRenderer _lineRenderer;

	[SerializeField]
	private float originFreq;

	[SerializeField]
	private float originAmplitudeY;

	[SerializeField]
	private float originAmplitudeZ;

	[SerializeField]
	private bool _bPingpongAmp;

	[SerializeField]
	private float curAmplitudeY;

	[SerializeField]
	private float curAmplitudeZ;

	[SerializeField]
	private Vector2 _uvAnimRate;

	private Vector2 _uvOffset;

	[SerializeField]
	private Transform src;

	[SerializeField]
	private Transform dst;

	[Header("Glow")]
	[SerializeField]
	private LineRenderer _lineRenderer_Glow;

	[SerializeField]
	private float _glowUvSpeed;

	[SerializeField]
	private float _elapsedUv;

	private BattleUnitModel _ownerUnit;

	private BattleUnitModel _targetUnit;

	private Direction _handDirection;

	private float prevDist;

	private float _elapsedCreateParticle;

	private float _createDelay;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitModel owner, BattleUnitModel target, Direction handDirection)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePivot()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLinePos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMaterial_UV()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateFreq()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateAmplitude()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateGlowLineRenderer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Yan_ChainCurve()
	{
		throw null;
	}
}
