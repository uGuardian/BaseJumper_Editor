using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_RCorp_Rudolph_AreaAtk : FarAreaEffect
{
	[SerializeField]
	private AudioClip _soundCharging;

	[SerializeField]
	private AudioClip _soundCasting;

	[SerializeField]
	private RCorp_RudolphLaserController _laserController;

	[SerializeField]
	private GameObject _laserParticle;

	[SerializeField]
	private AnimationCurve _laserFadeoutCurve;

	[SerializeField]
	private ParticleSystem _chargeParticle;

	[SerializeField]
	private GameObject _damagedEffectRef;

	[SerializeField]
	private float _castDelay;

	private float _elapsed;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private List<BattleFarAreaPlayManager.VictimInfo> _defensedList;

	private bool _doneAction;

	private bool _initLaser;

	private bool _doneForcely;

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
	private IEnumerator InitRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GiveDamage(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndEffectForcely()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ActionPhase(float deltaTime, BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetDiceResultOfTarget(BattlePlayingCardDataInUnitModel targetCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDamagedEffect(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_RCorp_Rudolph_AreaAtk()
	{
		throw null;
	}
}
