using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

namespace Opening
{
	public class GameOpeningController : MonoBehaviour
	{
		private static GameOpeningController _instance;

		public List<GameOpeningController.OpeningFont> fonts;

		public GameObject ActiveController;

		public VideoPlayer videoPlayer;

		public TextMeshProUGUI SubtitleText;

		private string targetFileName;

		public string currentLanguage;

		public Dictionary<int, GameOpeningController.Subtitle> subtitles;

		public List<GameOpeningController.Subtitle> listedSubtitles;

		public GameOpeingSubtitleRoot subtitleRoot;

		public GameObject Curtain;

		public AudioSource audio;

		private Queue<GameOpeningController.Subtitle> _queue;

		public float InputDelay;

		private float _inputDelay;

		private GameOpeningController.OnPlayEnd _onPlayEnd;

		private bool _isPlayed;

		private bool _inputDelayEnd;

		private GameOpeningController.Subtitle _current;

		public static GameOpeningController Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOnPlayEndMethod(GameOpeningController.OnPlayEnd method)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVolume(float v)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PlayReady()
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
		public void PlayOpening()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopOpening()
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
		public void SaveSubtitle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameOpeningController()
		{
			throw null;
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

		public delegate void OnPlayEnd();
	}
}
