using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sound;
using TMPro;
using UnityEngine;

public class ThePriceOfSilenceMapManager : CreatureMapManager
{
	[Header("전투 책장 할당 시간 제한 체크")]
	[SerializeField]
	private SpriteRenderer _clockSecondHand;

	[SerializeField]
	private SoundEffectPlayer _loopSound;

	[Header("시간의 흔적 강제처치 시 사서 데미지 연출")]
	[SerializeField]
	private AnimationCurve _damageFilterCurve;

	[SerializeField]
	private float _damageFilterAnimSpeed;

	[SerializeField]
	private SpriteRenderer _damageFilter;

	private float _damageFilterElapsed;

	[Header("광역 공격 연출")]
	[SerializeField]
	private CameraFilterPack_TV_BrokenGlass _areaAtkCamFilter;

	[SerializeField]
	private SpriteRenderer _areaAtkSpriteFilter;

	[SerializeField]
	private TextMeshPro _areaAtkTxtFilter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTime(float elapsed)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDamageFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAreaAtkSpriteFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAreaCamFilterEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAreaAtkCamFilter(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutCamFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartUnitMoving()
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
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ThePriceOfSilenceMapManager()
	{
		throw null;
	}
}
