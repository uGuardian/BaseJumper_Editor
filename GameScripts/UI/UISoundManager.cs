using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UISoundManager : MonoBehaviour
	{
		private static UISoundManager _instance;

		[Header("Resouces")]
		[SerializeField]
		private AudioClip[] soundResources;

		[Header("Reference")]
		[SerializeField]
		private AudioSource Audio_BGM;

		public AudioSource EndingCredit_Bgm;

		[SerializeField]
		private AudioSource[] Audio_EffectSoundPooling;

		[Header("UI EffectSount Ref")]
		public List<AudioClip> soundList;

		private Dictionary<UISoundType, AudioClip> effectSoundDic;

		private Dictionary<UIButtonSoundType, UIAudioData> audioDataDic;

		private Dictionary<UIBGMType, AudioClip> bgmSoundDic;

		public int soundcount;

		public static UISoundManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Dictionary<UISoundType, AudioClip> _EffectSoundDic
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Dictionary<UIButtonSoundType, UIAudioData> _audioDataDic
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGameStateBGM(GameCurrentState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayBGMSound(UIPhase currentphase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayBGMSound(UIBGMType bgm)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private AudioClip SetBGMAudio(UIPhase currentphase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopBGM()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PauseBGM()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnVolumeChanged(OptionDataModel option)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayEffectSound(UISoundType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISoundManager()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UISoundManager()
		{
			throw null;
		}
	}
}
