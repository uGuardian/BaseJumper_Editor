using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CustomInvitation;
using LOR_DiceSystem;
using UnityEngine;

public class CharacterSound : MonoBehaviour
{
	[Header("Resource")]
	[SerializeField]
	private BattleEffectSound _soundPrefab;

	[Space]
	[Header("Reference")]
	[SerializeField]
	private List<CharacterSound.Sound> _motionSounds;

	private Dictionary<LOR_DiceSystem.MotionDetail, CharacterSound.Sound> _dic;

	private static Dictionary<string, AudioClip> _motionSoundResources;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMotionSounds(List<BookSoundInfo> soundList, string path)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator LoadAudioCoroutine(string path, List<CharacterSound.ExternalSound> externalSoundList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaySound(LOR_DiceSystem.MotionDetail motion, bool win)
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
	public void ClearSounds()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterSound()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CharacterSound()
	{
		throw null;
	}

	[Serializable]
	public class Sound
	{
		public LOR_DiceSystem.MotionDetail motion;

		public AudioClip winSound;

		public AudioClip loseSound;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sound()
		{
			throw null;
		}
	}

	public class ExternalSound
	{
		public LOR_DiceSystem.MotionDetail motion;

		public string soundName;

		public bool isWin;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExternalSound()
		{
			throw null;
		}
	}
}
