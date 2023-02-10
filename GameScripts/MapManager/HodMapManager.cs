using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HodMapManager : MapManager
{
	[Header("Hod Sound")]
	[SerializeField]
	private AudioClip bgChangeSound;

	[SerializeField]
	private AudioClip[] bgObjectMovLvSounds;

	[SerializeField]
	private AudioSource audioSrcBgObjs;

	[Header("Moving Obj")]
	[SerializeField]
	private List<HodBgScroll> bgMovingObjs;

	private int objectSpeedLv;

	public ParticleSystem dust;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HodMapManager()
	{
		throw null;
	}
}
