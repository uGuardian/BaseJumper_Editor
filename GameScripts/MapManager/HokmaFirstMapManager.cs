using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HokmaFirstMapManager : CreatureMapManager
{
	[SerializeField]
	private GameObject _particle2;

	[SerializeField]
	private SpriteRenderer[] _imgFilters;

	private GameObject _instantiatedParticle1;

	private GameObject _instantiatedParticle2;

	private int _filterCount;

	private bool _awaken;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awaken(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAtkFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EarthQuakeRoutine(CameraFilterPack_FX_EarthQuake r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateAreaAttackFilter(int filterId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyAreaAttackFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeInFilter(SpriteRenderer r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutFilter(SpriteRenderer r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HokmaFirstMapManager()
	{
		throw null;
	}
}
