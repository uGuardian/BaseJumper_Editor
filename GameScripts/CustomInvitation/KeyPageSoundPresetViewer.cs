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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActivated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BlockImg(bool enable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggles(bool enable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddRefreshButtonListener(Action callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPlayButtonListener(Action<AudioClip> callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddSetButtonListener(Action<SoundPresetSummary> callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSoundPreset(List<AudioClip> audioClipList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectSoundPreset(SoundPresetSummary soundPreset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageSoundPresetViewer()
		{
			throw null;
		}
	}
}
