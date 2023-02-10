using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LongBirdMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer _bg;

	private const int _defaultDlgNum = 3;

	private const int _specialDlgNum = 2;

	private const int _defaultDlgNum2 = 3;

	private const float _singleDelayFinal = 3f;

	private const float _singleDelay = 1f;

	private const float _simpanTime = 3.5f;

	private const float _appearSoundTime = 0.25f;

	private const float _upSoundTime = 1.5f;

	private const float _blurStart = 2f;

	private const float _blurTime = 1.5f;

	private const float _bossBirdSoundTime = 1f;

	private const int _childID = 9080302;

	[SerializeField]
	private SpriteRenderer _filterPivot;

	[SerializeField]
	private GameObject _filter;

	private List<string> _creatureDlgIdList2;

	private CreatureDlgEffectUI _dlgEffect2;

	private int _dlgIdx2;

	private float _filterElapsed;

	private bool _childAlive;

	private bool _super;

	private bool _filterStarted;

	private bool _filterAppearSound;

	private bool _filterUpSound;

	private bool _blurFilter;

	private bool _bossPaternSound;

	private float _singleElapsed;

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
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSuper()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SingleSimpan_Final()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SingleSimpan()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SimpanOn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlurFilterCoroutine(CameraFilterPack_Blur_Movie targetScript)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LongBirdMapManager()
	{
		throw null;
	}
}
