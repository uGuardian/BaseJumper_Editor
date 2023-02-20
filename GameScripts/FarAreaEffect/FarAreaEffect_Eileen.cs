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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestoryTargetEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideTargetEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStartEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamageEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroyEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Eileen()
	{
		throw null;
	}
}
