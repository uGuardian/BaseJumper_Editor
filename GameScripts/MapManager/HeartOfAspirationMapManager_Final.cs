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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateAngelaDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HeartOfAspirationMapManager_Final()
	{
		throw null;
	}
}
