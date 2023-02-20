using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageSoundPresetViewer : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private SoundPresetSummary _soundPresetRef;

		[SerializeField]
		private LayoutGroup _presetLayout;

		[SerializeField]
		private ToggleGroup _presetToggleGroup;

		[SerializeField]
		private Button _refreshButton;

		[SerializeField]
		private Button _playButton;

		[SerializeField]
		private Button _setButton;

		[SerializeField]
		private ToggleListFilter _searchFilter;

		[SerializeField]
		private AudioSource _audioSource;

		[SerializeField]
		private GameObject _blockObj;

		private List<SoundPresetSummary> _soundPresetList;

		private SoundPresetSummary _curSelectedSoundPreset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActivated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BlockImg(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggles(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddRefreshButtonListener(Action callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPlayButtonListener(Action<AudioClip> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddSetButtonListener(Action<SoundPresetSummary> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSoundPreset(List<AudioClip> audioClipList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectSoundPreset(SoundPresetSummary soundPreset)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageSoundPresetViewer()
		{
			throw null;
		}
	}
}
