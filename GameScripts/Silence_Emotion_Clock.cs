using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class Silence_Emotion_Clock : MonoBehaviour
{
	[Header("전투 책장 할당 시간 제한 체크")]
	[SerializeField]
	private SpriteRenderer _clockSecondHand;

	[SerializeField]
	private SoundEffectPlayer _loopSound;

	private bool hurry;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run(float elapsed)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartUnitMoving()
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
	public Silence_Emotion_Clock()
	{
		throw null;
	}
}
