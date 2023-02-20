using System;
using System.Collections;
using System.Runtime.CompilerServices;
using StoryScene;
using UnityEngine;

public class StoryBgmController : MonoBehaviour
{
	[SerializeField]
	private float _fadeSpeed;

	[SerializeField]
	private AudioSource[] _audioSourceAry;

	[SerializeField]
	private int curPlayIdx;

	private float _maxBgmVolume;

	[SerializeField]
	private AudioClip halfLoopBgm;

	[SerializeField]
	private StoryManager _storyManager;

	public float volume
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopMusic(BgmMode mode)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayMusic(AudioClip clip, BgmMode mode)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeInMusic(AudioSource src)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutMusic(AudioSource src)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StoryBgmController()
	{
		throw null;
	}
}
