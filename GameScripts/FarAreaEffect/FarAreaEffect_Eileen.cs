using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_Eileen : FarAreaEffect
{
	private string _PREFAB_PATH;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	protected Vector3 additionalScale;

	[SerializeField]
	private Vector2 offset;

	private float elapsedTime;

	public float hideStartTime;

	public float destroyTime;

	public List<GameObject> targeteffectlist;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestoryTargetEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideTargetEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStartEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamageEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroyEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Eileen()
	{
		throw null;
	}
}
