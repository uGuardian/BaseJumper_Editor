using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sound
{
	public class SoundEffectManager : SingletonBehavior<SoundEffectManager>
	{
		public GameObject ReferencePlayer;

		private int _id;

		private Dictionary<int, SoundEffectPlayer> _management;

		private List<SoundEffectPlayer> _loopSounds;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected SoundEffectManager()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyLoopSounds()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoundEffectPlayer PlayClip(string src, bool loop = false, float volume = 1f, Transform parent = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVolume(float volume)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePlayer(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoundEffectPlayer PlayClip(AudioClip clip, bool loop = false, float volume = 1f, Transform parent = null)
		{
			throw null;
		}
	}
}
