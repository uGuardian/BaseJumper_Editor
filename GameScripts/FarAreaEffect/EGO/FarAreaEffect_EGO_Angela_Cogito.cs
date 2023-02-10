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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapChangeEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnChangeToCarmen()
	{
		throw null;
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
