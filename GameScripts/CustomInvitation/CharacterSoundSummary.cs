using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CharacterSoundSummary : MonoBehaviour
	{
		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Text _winSoundText;

		[SerializeField]
		private Toggle _toggleWinSound;

		[SerializeField]
		private Text _loseSoundText;

		[SerializeField]
		private Toggle _toggleLoseSound;

		[SerializeField]
		private Dropdown _motionDropdown;

		private AudioClip _winSound;

		private AudioClip _loseSound;

		private bool _isWinExternal;

		private bool _isLoseExternal;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip GetWinSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip GetLoseSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MotionDetail GetMotion()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetRootToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetWinSoundToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetLoseSoundToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetWinSoundName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetLoseSoundName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSoundInfo(BookSoundInfo soundInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookSoundInfo GetSoundInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetToggles()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeMotionSound(SoundPresetSummary preset, bool isExternalSound)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSoundSummary()
		{
			throw null;
		}
	}
}
