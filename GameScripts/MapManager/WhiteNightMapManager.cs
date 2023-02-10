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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfessTwo(BattleUnitModel whiteNight)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfessThree(BattleUnitModel whiteNight)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfessFour()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEscortApostleCreationFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeWingColor(int start, int end)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnableOneSin(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableWhiteNight()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToOneSinEgoMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProtectionEffect(WhiteNightMapManager.EventFunc f)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ProtectionEffectRoutine(WhiteNightMapManager.EventFunc f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeadApostleFilter(List<BattleUnitModel> deadList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDlg()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WhiteNightMapManager()
	{
		throw null;
	}

	public delegate void DeadApostleFilterEndEvent(List<BattleUnitModel> l);

	public delegate void EventFunc();
}
