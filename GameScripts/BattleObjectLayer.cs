using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class BattleObjectLayer : MonoBehaviour
{
	private static BattleObjectLayer _instance;

	public BattleUnitView battleUnitPrefab;

	private List<BattleUnitView> _unitList;

	public List<BattleObjectLayer.UnitViewportPosInfo> unitViewportList;

	public UICustomSelectablePanel selectablePanel;

	public static BattleObjectLayer instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<BattleUnitView> UnitViewList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddUnit(BattleUnitModel model)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveUnit(BattleUnitModel model)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleObjectLayer()
	{
		throw null;
	}

	public class UnitViewportPosInfo
	{
		public BattleUnitView view;

		public Vector3 viewportPos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitViewportPosInfo()
		{
			throw null;
		}
	}
}
