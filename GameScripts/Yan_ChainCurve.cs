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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePivot()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLinePos()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMaterial_UV()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateFreq()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateAmplitude()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLayer()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateGlowLineRenderer()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateParticle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Yan_ChainCurve()
	{
		throw null;
	}
}
