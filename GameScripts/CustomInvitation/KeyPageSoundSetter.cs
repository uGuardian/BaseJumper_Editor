using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageSoundSetter : MonoBehaviour
	{
		[SerializeField]
		private KeyPageSoundPresetViewer _lorSoundPresetViewer;

		[SerializeField]
		private KeyPageSoundPresetViewer _customSoundPresetViewer;

		[SerializeField]
		private Toggle _toggleViewLor;

		[SerializeField]
		private Toggle _toggleViewCustom;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[Header("Motion Sound")]
		[SerializeField]
		private CharacterSoundSummary _charSoundRef;

		[SerializeField]
		private LayoutGroup _charSoundLayout;

		[SerializeField]
		private Button _playMotionSoundButton;

		[SerializeField]
		private Button _addMotionSoundButton;

		[SerializeField]
		private Button _deleteMotionSoundButton;

		private List<CharacterSoundSummary> _charSoundList;

		private readonly List<MotionDetail> _supportedMotionList;

		private Action<List<BookSoundInfo>> _callback;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenSoundSettingPopup(List<BookSoundInfo> soundInfoList, Action<List<BookSoundInfo>> callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitSoundPresets()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewLorTab(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewCustomTab(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PlayMotionSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddMotionSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DelMotionSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetMotionSoundByLorPreset(SoundPresetSummary selected)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetMotionSoundByCustom(SoundPresetSummary selected)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneSoundSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelSoundSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshMotionSounds()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator WaitMotionSoundRefresh()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PlayAudioClip(AudioClip clip)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DelCharSounds(List<CharacterSoundSummary> deleteKeyList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageSoundSetter()
		{
			throw null;
		}
	}
}
