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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetScary(bool b)
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
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMetalShock(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MurdererMapManager()
	{
		throw null;
	}
}
