using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sound
{
	public class SoundEffectPlayer : MonoBehaviour
	{
		private AudioClip _clip;

		public AudioSource source;

		private int _id;

		private float _defaultVolume;

		private bool _bTimeLimit;

		private float _maxTime;

		private float _elapsedTime;

		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int id, AudioClip clip, bool loop = false, float volume = 1f)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVolume(float volume)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGlobalPosition(Vector3 pos)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLocalPosition(Vector3 pos)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAttachParent(Transform parent)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetParentAsManager()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMaxTime(float f)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PauseSound(bool pause)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualDestroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SoundEffectPlayer PlaySound(string src)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoundEffectPlayer()
		{
			throw null;
		}
	}
}
