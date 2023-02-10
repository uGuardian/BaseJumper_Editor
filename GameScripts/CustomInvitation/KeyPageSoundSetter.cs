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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitUI()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitSoundPresets()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewLorTab(bool isOn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewCustomTab(bool isOn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PlayMotionSound()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddMotionSound()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DelMotionSound()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetMotionSoundByLorPreset(SoundPresetSummary selected)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetMotionSoundByCustom(SoundPresetSummary selected)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneSoundSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelSoundSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshMotionSounds()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator WaitMotionSoundRefresh()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PlayAudioClip(AudioClip clip)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DelCharSounds(List<CharacterSoundSummary> deleteKeyList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageSoundSetter()
		{
			throw null;
		}
	}
}
