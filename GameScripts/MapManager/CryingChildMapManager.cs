using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class CryingChildMapManager : MapManager
{
	[SerializeField]
	private AudioClip _burnPhaseSound;

	[SerializeField]
	private AudioClip _ashPhaseSound;

	[SerializeField]
	private AudioClip _nextBgm;

	[SerializeField]
	private AudioClip _whisperBgm;

	[SerializeField]
	private AudioClip _areaLaserSound;

	[SerializeField]
	private AudioClip _seperateSound;

	[SerializeField]
	private AudioClip _makeOneSound;

	[SerializeField]
	private List<SpriteRenderer> _burnSpriteRenderers;

	[SerializeField]
	private Color _dlgColor;

	[SerializeField]
	private MapChangeFilter _mapChangeFilter;

	[SerializeField]
	private List<GameObject> _angelParticles;

	[SerializeField]
	private GameObject _ashParticle;

	[SerializeField]
	private GameObject _sparkParticle;

	private EnemyTeamStageManager_TheCrying _stageManager;

	private EnemyTeamStageManager_TheCrying.Phase _currentPhase;

	private List<string> _dlgIdList;

	private CreatureDlgEffectUI _dlgEffect;

	private int _dlgIdx;

	private bool _bgChanged;

	private SoundEffectPlayer _loopWhisperSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayAreaLaserSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnableAngelParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeMap(EnemyTeamStageManager_TheCrying.Phase phase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CryingChildMapManager()
	{
		throw null;
	}
}
