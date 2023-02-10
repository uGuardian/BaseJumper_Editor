using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_EGO_SilentGirl_Phase3 : FarAreaEffect
{
	[SerializeField]
	private Sprite[] _bgSpriteAry;

	[SerializeField]
	private SpriteRenderer _bgRenderer;

	[SerializeField]
	private AnimationCurve _bgAlphaFadeInCurve;

	[SerializeField]
	private AnimationCurve _bgAlphaFadeOutCurve;

	[SerializeField]
	private GameObject[] _changeMotionEffectResAry;

	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _fallingSound;

	[SerializeField]
	private AudioClip _atkSound;

	[SerializeField]
	private AudioClip _lastAtkSound;

	[SerializeField]
	private GameObject _librarianDeadEffectRes;

	[SerializeField]
	private GameObject _damagedEffectRes;

	[SerializeField]
	private GameObject _atkEffectRes;

	[SerializeField]
	private GameObject _bgEffect;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private float _waitFirstAtkTime;

	[SerializeField]
	private float _waitAfterAtkTime;

	[SerializeField]
	private float _waitAfterLastAtkTime;

	[SerializeField]
	private float _waitKillForcelyTime;

	private FarAreaEffect_EGO_SilentGirl_Phase3.Phase _phase;

	private float _elapsedFirstAtk;

	private float _elapsedAtkEnd;

	private float _elapsedKillForcely;

	private GameObject _loopEffect;

	private CameraFilterPack_Noise_TV_2 _filter;

	private Queue<BattleUnitModel> _aliveUnits;

	private List<BattleUnitModel> _aliveUnitList;

	private const int _ANGELA_LIBRARIAN_BOOK_ID = 9100501;

	public int atkCount
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitAtk(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitLastAtk(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLastDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapEyeEffect(bool eye, bool start)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateChangeEffect(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_SilentGirl_Phase3()
	{
		throw null;
	}

	public enum Phase
	{
		WaitFirstAtk,
		FirstAtk,
		Atk,
		WaitLastAtk,
		LastAtk,
		CheckAliveLibrarian
	}
}
