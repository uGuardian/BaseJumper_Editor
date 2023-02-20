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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XiaoMapManager()
	{
		throw null;
	}
}
