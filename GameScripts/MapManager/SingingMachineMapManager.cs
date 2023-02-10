using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SingingMachineMapManager : CreatureMapManager
{
	[SerializeField]
	private GameObject _particle1;

	[SerializeField]
	private GameObject _particle2;

	[SerializeField]
	private GameObject _specialAtkParticle;

	[SerializeField]
	private SpriteRenderer _filterSprite1;

	[SerializeField]
	private SpriteRenderer _filterSprite2;

	private GameObject _instantiatedParticle1;

	private GameObject _instantiatedParticle2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilter1()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAtkFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject SetSpecialParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyAtkFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SpecialAtkRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EarthQuakeRoutine(CameraFilterPack_FX_EarthQuake r)
	{
		throw null;
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
	public SingingMachineMapManager()
	{
		throw null;
	}
}
