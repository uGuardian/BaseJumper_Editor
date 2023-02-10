using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitBottomUIInBattle : MonoBehaviour
{
	public BattleUnitView view;

	[Header("Resources")]
	[SerializeField]
	private Color[] refcolors_factionColor;

	[SerializeField]
	private Image img_glowfaction;

	[SerializeField]
	private CircleSliderBar hpslider;

	[SerializeField]
	private CircleSliderBar bpslider;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetHp(int currenthp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetBreakGauge(int currentbp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBottomUIInBattle()
	{
		throw null;
	}
}
