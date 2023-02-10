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
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
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
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGauge(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLaserPortal(bool snake)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeactivateLaserPortal(bool snake)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShootLaser(bool snake)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopLoopSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEffectPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QueenOfHatredFinalMapManager()
	{
		throw null;
	}
}
