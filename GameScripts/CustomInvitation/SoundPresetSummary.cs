using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class SoundPresetSummary : MonoBehaviour
	{
		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Text _nameText;

		private AudioClip _sound;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip GetAudioClip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetSoundName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(AudioClip sound, ToggleGroup toggleGroup, Action<SoundPresetSummary> toggleCallback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoundPresetSummary()
		{
			throw null;
		}
	}
}
