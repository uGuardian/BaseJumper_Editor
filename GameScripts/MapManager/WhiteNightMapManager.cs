using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WhiteNightMapManager : CreatureMapManager
{
	[SerializeField]
	private GameObject _oneSinObject;

	[SerializeField]
	private WhiteNightObjectController _whiteNightObj;

	[SerializeField]
	private SpriteRenderer _whitenightWingSprite;

	[SerializeField]
	private GameObject _whiteNightWingObj;

	[SerializeField]
	private Animator _colorChangeAnimator;

	[SerializeField]
	private Color[] _wingColors;

	private float _elapsedWingColorChange;

	private int _start;

	private int _end;

	[SerializeField]
	private GameObject _lightEffect;

	[SerializeField]
	private GameObject _hokmaAuraPrefab;

	[SerializeField]
	private GameObject _whiteNightEffectPrefab;

	[SerializeField]
	private GameObject _lightEffectConfess1;

	[SerializeField]
	private GameObject _lightEffectConfess2;

	[SerializeField]
	private SpriteRenderer _createEscortApostleFilter;

	[SerializeField]
	private SpriteRenderer[] _sideFloors;

	[SerializeField]
	private AnimationCurve _escortFilterCurve;

	private float _elapsedEscortFilterOn;

	private int _deadApostleCount;

	[SerializeField]
	private GameObject _confessDivergencePrefab;

	[SerializeField]
	private GameObject _crossExplosionEffectPrefab;

	[SerializeField]
	private GameObject _featherExplosionEffectPrefab;

	[SerializeField]
	private GameObject _mapFeatherEffect;

	private GameObject _hokmaAuraObj;

	public WhiteNightObjectController whiteNightController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfessOne()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfessTwo(BattleUnitModel whiteNight)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfessThree(BattleUnitModel whiteNight)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfessFour()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEscortApostleCreationFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeWingColor(int start, int end)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnableOneSin(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableWhiteNight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToOneSinEgoMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProtectionEffect(WhiteNightMapManager.EventFunc f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ProtectionEffectRoutine(WhiteNightMapManager.EventFunc f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeadApostleFilter(List<BattleUnitModel> deadList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDlg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WhiteNightMapManager()
	{
		throw null;
	}

	public delegate void DeadApostleFilterEndEvent(List<BattleUnitModel> l);

	public delegate void EventFunc();
}
