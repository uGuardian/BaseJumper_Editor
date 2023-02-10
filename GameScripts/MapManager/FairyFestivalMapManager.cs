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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBiteFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVibeFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBloodByst(bool phaseTwo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBloodMyst(bool active)
	{
		throw null;
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
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
