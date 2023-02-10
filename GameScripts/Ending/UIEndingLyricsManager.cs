using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Opening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Ending
{
	public class UIEndingLyricsManager : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private AudioClip looping_bgm;

		[SerializeField]
		public AudioSource audiosource;

		[SerializeField]
		private CanvasGroup cg_lyrics;

		[SerializeField]
		private TextMeshProUGUI subTitleText;

		[SerializeField]
		private Image img_subtitleBg;

		[SerializeField]
		private List<UIEndingLyricsManager.OpeningFont> fonts;

		[SerializeField]
		private AnimationCurve revealCurve;

		[SerializeField]
		private AnimationCurve HideCurve;

		public Dictionary<int, UIEndingLyricsManager.Subtitle> subtitles;

		public List<UIEndingLyricsManager.Subtitle> listedSubtitles;

		private Queue<UIEndingLyricsManager.Subtitle> _subtitlequeue;

		[HideInInspector]
		public string currentLanguage;

		[HideInInspector]
		public bool isRunning;

		private UIEndingLyricsManager.Subtitle _currentsubtitle;

		private float _inputDelay;

		private bool isShowText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopBgm()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayBgm()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateSubtitle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetText()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLanguage(string language)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitSubtitleData(GameOpeingSubtitleRoot subtitleRoot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadSubtitle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator HideProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEndingLyricsManager()
		{
			throw null;
		}

		[Serializable]
		public class Subtitle
		{
			public int id;

			public float displayTime;

			public float duration;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Subtitle()
			{
				throw null;
			}
		}

		[Serializable]
		public class OpeningFont
		{
			public string language;

			public Material mat;

			public TMP_FontAsset fontAsset;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public OpeningFont()
			{
				throw null;
			}
		}
	}
}
