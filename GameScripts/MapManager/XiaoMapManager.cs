using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class XiaoMapManager : MapManager
{
	[SerializeField]
	private AudioClip _initSoundClip;

	[SerializeField]
	private AudioClip _loopSoundClip;

	private SoundEffectPlayer _loopSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XiaoMapManager()
	{
		throw null;
	}
}
