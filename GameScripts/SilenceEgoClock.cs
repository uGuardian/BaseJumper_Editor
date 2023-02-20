using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class SilenceEgoClock : MonoBehaviour
{
	[Header("전투 책장 할당 시간 제한 체크")]
	[SerializeField]
	private SpriteRenderer _clockSecondHand;

	private SoundEffectPlayer _loopSound;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run(float elapsed)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SilenceEgoClock()
	{
		throw null;
	}
}
