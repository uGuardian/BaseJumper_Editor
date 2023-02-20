using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ServantOfWrathMapManager : CreatureMapManager
{
	[SerializeField]
	private ParticleSystem _ps;

	[SerializeField]
	private SpriteRenderer _acidParticleRoot;

	private List<GameObject> _acidParticleObjects;

	private const float _particleFadeOutTimeMin = 0.8f;

	private const float _particleFadeoutTimeMax = 1f;

	private const int _defaultDlgNum = 2;

	private const int _specialDlgNum = 2;

	private const int _defaultDlgNum2 = 2;

	private const int _specialDlgNum2 = 2;

	private List<string> _creatureDlgIdList2;

	private CreatureDlgEffectUI _dlgEffect2;

	private int _dlgIdx2;

	private ServantOfWrathMapManager.ReclusState _state;

	private LorId _stageID;

	public ServantOfWrathMapManager.ReclusState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
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
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DollAllKilled()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SummonReady()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SummonTry()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DollAlive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateAcidParticle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutParticles()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyParticles()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinDirection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServantOfWrathMapManager()
	{
		throw null;
	}

	public enum ReclusState
	{
		DollAlive,
		DollAllKilled,
		SummonDollReady,
		SummoningDoll
	}
}
