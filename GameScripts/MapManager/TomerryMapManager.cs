using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TomerryMapManager : MapManager
{
	[SerializeField]
	private AudioClip _mapChangedSound;

	[SerializeField]
	private GameObject _environmentParticlePrefab;

	[SerializeField]
	private AudioClip _phase2startSound;

	[SerializeField]
	private AudioClip _squareCardSound;

	[SerializeField]
	private AudioClip _triangleCardSound;

	[SerializeField]
	private AudioClip _whipCardSound;

	[SerializeField]
	private GameObject _squareCardParticlePrefab;

	[SerializeField]
	private GameObject _triangleCardParticlePrefab;

	[SerializeField]
	private AnimationCurve _radialFilterAnimCurve;

	[SerializeField]
	private SpriteRenderer _squareCardFilter;

	[SerializeField]
	private SpriteRenderer _triangleCardFilter;

	[SerializeField]
	private SpriteRenderer _whipCardFilter1;

	[SerializeField]
	private SpriteRenderer _whipCardFilter2;

	[SerializeField]
	private AnimationCurve _whipCardFilterAnimCurve;

	private GameObject _instantiatedParticle;

	private GameObject _instantiatedParticle_sqaureCard;

	private GameObject _instantiatedParticle_triangleCard;

	private bool _bPhaseTwoInitialized;

	private Coroutine _whipFilterRoutine;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ActiveMap(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AfterCheckMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EarthQuakeRoutine(CameraFilterPack_FX_EarthQuake r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PlayMapChangedSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWhipCardFilters()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator WhipFilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RadialRoutine(CameraFilterPack_Blur_Radial r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TomerryMapManager()
	{
		throw null;
	}
}
