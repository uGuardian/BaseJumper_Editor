using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class MurdererMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer scaryFilter;

	private bool _bScared;

	private SoundEffectPlayer _loopSound;

	[Header("Boss Phase")]
	[SerializeField]
	private SpriteRenderer bossScaryFilter;

	private bool _bMetalShock;

	private SoundEffectPlayer _loopSoundMetalShock;

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
	public void SetScary(bool b)
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
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMetalShock(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MurdererMapManager()
	{
		throw null;
	}
}
