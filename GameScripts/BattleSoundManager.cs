using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleSoundManager : SingletonBehavior<BattleSoundManager>
{
	[Header("Ref Prefab")]
	[SerializeField]
	public BattleEffectSound effectSoundPrefab;

	[Header("볼륨")]
	[SerializeField]
	[Range(0f, 1f)]
	private float volumeBgm;

	[SerializeField]
	[Range(0f, 1f)]
	private float volumeEffectSound;

	[SerializeField]
	[Tooltip("다른 BGM 재생중일 때 배경음 볼륨 임시로 줄이기 위함")]
	[Range(0f, 1f)]
	private float volumeBgmRatio;

	private float volumeFxRatio;

	[Header("검은 침묵 최종전")]
	[SerializeField]
	private AudioClip[] _blackSilenceTheme;

	[Header("잔향악단 2차전")]
	[SerializeField]
	private AudioClip[] _reverberationBandTheme;

	[Header("머리 발톱 최종")]
	[SerializeField]
	private AudioClip[] _finalFinalTheme;

	[Header("환상체 최종전")]
	[SerializeField]
	public AudioClip[] _finalCreatureTheme;

	[SerializeField]
	private AudioClip[] _rolandEgoTheme;

	[Header("테마 관련")]
	[SerializeField]
	private AudioClip[] enemyThemeSound;

	[SerializeField]
	private AudioClip[] allyThemeSound;

	[SerializeField]
	private AudioClip[] defaultEnemyThemeSound;

	[SerializeField]
	private AudioSource _currentEnemyTheme;

	[SerializeField]
	private AudioSource _currentAllyTheme;

	[SerializeField]
	private AudioSource _currentCreatureTheme;

	[SerializeField]
	private AudioClip changeThemeEvent;

	[Header("카드 관련")]
	[SerializeField]
	private AudioClip selectCard;

	[SerializeField]
	private AudioClip releaseCard;

	[SerializeField]
	private AudioClip assignCard;

	[SerializeField]
	private AudioClip assignCardNotAllowed;

	[SerializeField]
	private AudioClip card_hOver;

	[Header("환상체 카드")]
	[SerializeField]
	private AudioClip abnormality_Start;

	[SerializeField]
	private AudioClip abnormality_Loop;

	[SerializeField]
	private AudioClip abnormality_card_hOver_start;

	[SerializeField]
	private AudioClip abnormality_card_hOver_loop;

	[SerializeField]
	private AudioClip abnormality_card_select;

	[Header("오브젝트 충돌")]
	[SerializeField]
	private AudioClip object_crash;

	[Header("전투 턴 흐름")]
	public AudioClip round_start;

	public AudioClip speedDice_ready;

	public AudioClip speedDice_roll;

	public AudioClip fingerSnap;

	public AudioClip turnEnd;

	public AudioClip unitDead;

	[Header("전투 결과")]
	[SerializeField]
	private AudioClip waveWin;

	[SerializeField]
	private AudioClip waveLose;

	[SerializeField]
	private AudioClip finalAnimStart;

	[SerializeField]
	private AudioClip result_EndWin;

	[SerializeField]
	private AudioClip result_EndLose;

	[Header("주사위 ui")]
	public AudioClip dice_start;

	public AudioClip dice_roll;

	public AudioClip dice_hOver;

	[Space]
	[Header("배치파트")]
	public AudioClip ui_click;

	public AudioClip ui_card_apply;

	[HideInInspector]
	public AudioClip dice_destroy;

	[HideInInspector]
	public AudioClip dice_buf;

	[HideInInspector]
	public AudioClip dice_debuff;

	private Dictionary<EgoSoundType, AudioClip> _egoSoundDic;

	private Dictionary<EffectSoundType, AudioClip> _soundDic;

	[SerializeField]
	private AudioSource _currentPlayingTheme;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BattleSoundManager()
	{
		throw null;
	}

	public float VolumeBGM
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float VolumeFX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public AudioSource CurrentPlayingTheme
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStageStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllyTheme(AudioClip[] allyThemes)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioClip SetEnemyThemeIndexZero(AudioClip enemyTheme)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioClip[] SetEnemyTheme(AudioClip[] enemyThemes)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckTheme()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeEnemyTheme(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeAllyTheme(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCurrentTheme(bool isAlly)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeToBlackSilenceTheme()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeToFinalFinalBinahTheme(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFinalCreatureTheme(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFinalCreatureTheme_Roland(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndBgm()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartBgm()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeBgm(bool fadeIn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEffectSound PlaySound(EffectSoundType t, bool loop = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEffectSound PlaySound(EffectSoundType t, Vector3 pos, bool loop = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateVolume()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckBlackSilenceTheme()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckReverberationTheme()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBgmVolumeRatio(float ratio)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFxVolumeRatio(float ratio)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnVolumeChanged(OptionDataModel option)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOffBattleSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsBlackSilenceBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFinalFinalBattle()
	{
		throw null;
	}
}
