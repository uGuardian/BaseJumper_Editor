using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class HeartOfAspirationMapManager_Final : KeterFinalMapManager
{
	[SerializeField]
	private AudioClip _actionSoundSrc;

	[SerializeField]
	private AudioClip _nonActionSoundSrc;

	[SerializeField]
	private AudioClip _ferventBeatSoundSrc;

	private SoundEffectPlayer _actionLoopSound;

	private SoundEffectPlayer _nonActionLoopSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayLoopSound(bool action)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateAngelaDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HeartOfAspirationMapManager_Final()
	{
		throw null;
	}
}
