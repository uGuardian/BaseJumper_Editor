using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class FairyFestivalMapManager : CreatureMapManager
{
	[SerializeField]
	private AnimationCurve _biteFilterCurve;

	[SerializeField]
	private SpriteRenderer _biteFilter;

	[SerializeField]
	private SpriteRenderer _bloodMystFilter;

	private FairyFestivalMapManager.DlgType _curdlgType;

	private bool _bBloodMyst;

	private bool _bPhaseTwo;

	private SoundEffectPlayer _loopSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDlgType(FairyFestivalMapManager.DlgType dlgType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBiteFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVibeFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBloodByst(bool phaseTwo)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBloodMyst(bool active)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EarthQuakeRoutine(CameraFilterPack_FX_EarthQuake r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BiteFilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BloodMystRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FairyFestivalMapManager()
	{
		throw null;
	}

	public enum DlgType
	{
		NORMAL,
		CARE,
		EAT,
		EATALL
	}
}
