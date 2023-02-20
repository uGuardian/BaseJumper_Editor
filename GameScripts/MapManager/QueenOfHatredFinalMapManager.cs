using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class QueenOfHatredFinalMapManager : CreatureMapManager
{
	[SerializeField]
	private List<SpriteGhostEffect> _gaugeSpriteList;

	[SerializeField]
	private FarAreaEffect_QueenOfHatredLaser _laserHumanForm;

	[SerializeField]
	private FarAreaEffect_QueenOfHatredLaser _laserSnakeForm;

	public QueenOfHatredMapPolymorphFilter filter;

	private SoundEffectPlayer _laserLoopSound;

	private float _curGauge;

	private float _dstGauge;

	public FarAreaEffect_QueenOfHatredLaser laserHumanForm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public FarAreaEffect_QueenOfHatredLaser laserSnakeForm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Metamorphosis(bool active)
	{
		
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
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
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
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGauge(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLaserPortal(bool snake)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeactivateLaserPortal(bool snake)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShootLaser(bool snake)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopLoopSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEffectPos()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QueenOfHatredFinalMapManager()
	{
		throw null;
	}
}
