using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleUnitTargetArrowManagerUI : MonoBehaviour
{
	public BattleUnitTargetArrowUI targetArrowPrefab;

	public BattleUnitTargetArrowUI parryingArrowPrefab;

	public AnimationCurve thickWidth;

	public AnimationCurve thinWidth;

	public AnimationCurve ParryingThinWidth;

	public AnimationCurve ParryingThcikWidth;

	[SerializeField]
	private Transform cloneParent;

	public Gradient normalcolor;

	public Gradient gradientcolor;

	private List<BattleUnitTargetArrowData> TargetListData;

	private List<BattleUnitTargetArrowUI> allList;

	private List<BattleUnitTargetArrowUI> allyList;

	private List<BattleUnitTargetArrowUI> enemyList;

	private List<BattleUnitTargetArrowUI> parryingList;

	private List<BattleUnitTargetArrowUI> targetArrowList;

	private List<BattleUnitTargetArrowUI> parryingArrowList;

	private bool isVisibleAlly;

	private bool isVisibleEnemy;

	private bool isVisibleParrying;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitTargetArrowUI GetUsableTargetArrow()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitTargetArrowUI GetUsableParryingArrow()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawArrow(Transform from, Transform to, Faction faction, bool isParrying, bool istargetarrow = false, int heightparam = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearArrows()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowArrowsOf(BattleUnitModel unit, int diceIdx, bool istargetarrow = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAllyArrow(bool show)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowEnemyArrow(bool show)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowParryingArrow(bool show)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowTargetLines(List<BattleUnitTargetArrowUI> arrows, int flag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitTargetArrowUI DrawPreviewTargetLine(Transform from, Transform to, Faction faction, bool isParrying, bool istargetarrow = false, int heightparam = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCloneArrows()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OffArrows(List<BattleUnitTargetArrowUI> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTargetList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTargetListData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveTargetParent(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitTargetArrowManagerUI()
	{
		throw null;
	}
}
