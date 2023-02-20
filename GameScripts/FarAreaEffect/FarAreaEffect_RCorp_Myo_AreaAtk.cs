using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_RCorp_Myo_AreaAtk : FarAreaEffect
{
	[SerializeField]
	private bool _bLastAtk;

	[SerializeField]
	private bool _RANDOM_MOTION;

	[SerializeField]
	private float _DELAY_AFTER_ARRIVED;

	[SerializeField]
	private int _LAST_ATK_COUNT;

	[SerializeField]
	private float _DELAY_LAST_MOTION_CHANGE;

	[SerializeField]
	private float _DELAY_AFTER_GIVING_DMG;

	[SerializeField]
	private float _DELAY_END_ACTION;

	[SerializeField]
	private float _DELAY_DESTROY;

	[SerializeField]
	private float _DELAY_FINAL_MOTION;

	[SerializeField]
	private AudioClip _soundS1;

	[SerializeField]
	private AudioClip _soundS2;

	[SerializeField]
	private AudioClip _soundS3;

	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private AnimationCurve _moveRatioCurve;

	[SerializeField]
	private GameObject _atkParticle;

	[SerializeField]
	private GameObject _trailParticle;

	[SerializeField]
	private GameObject _bloodEffect;

	private List<GameObject> _atkParticleInstanceList;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private List<BattleFarAreaPlayManager.VictimInfo> _defensedList;

	private FarAreaEffect_RCorp_Myo_AreaAtk.Phase _phase;

	private bool _bLastTarget;

	private float _timerLastMotion;

	private float _elapsedFinalPenetrateMotion;

	private int _lastMotionCount;

	private bool _bDoneGivingDmg;

	private float _elapsedAfterGiveDmg;

	private float _elapsedAfterArrived;

	private float _elapsedEnd;

	private float _elapsedDestroy;

	private float _elapsedMovingToTarget;

	private BattleFarAreaPlayManager.VictimInfo _curVictim;

	private int _motionIdx;

	private bool _bLastBehaviour;

	private Vector3 _dstPos;

	private Vector3 _srcPos;

	private bool _bCamReturning;

	private float _elapsedCamReturn;

	public override bool HasIndependentAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ActionPhase(float deltaTime, BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTargetPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveToTargetPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeMotionPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveDamagePhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SuccessAtk()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FailAtk()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EndPhase(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FocusCam(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyForcely()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateBloodEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_RCorp_Myo_AreaAtk()
	{
		throw null;
	}

	public enum Phase
	{
		Start,
		SetTarget,
		MoveToTarget,
		ChangeMotion,
		GiveDamage,
		End
	}
}
