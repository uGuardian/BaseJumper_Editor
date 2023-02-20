using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_EGO_Angela_Cogito : FarAreaEffect
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _atkStartSound;

	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private ActionDetail _specialMotion;

	[SerializeField]
	private GameObject _atkEffect;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private GameObject _carmenChangeEffect;

	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private float _timeAfterAtk;

	private float _elapsedAfterAtk;

	private FarAreaEffect_EGO_Angela_Cogito.Phase _curPhase;

	private BattleUnitModel _silentGirl;

	private int _silentGirlSkinChangedCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapChangeEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnChangeToCarmen()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_Angela_Cogito()
	{
		throw null;
	}

	public enum Phase
	{
		Start,
		AfterDmg,
		AfterChangeSkin
	}
}
