using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitCostUI : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	private RectTransform rectParent;

	[SerializeField]
	private RectTransform upperLine;

	[SerializeField]
	private RectTransform lowerLine;

	[SerializeField]
	private GameObject prefab_cost;

	[SerializeField]
	private BattleUnitView _view;

	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private Image[] img_linebase;

	private List<BattleUnitCostUI.CostBattleUIImage> costLists;

	private float spacing;

	private float maskheight;

	private int fixedMaxcost;

	private int currentmaxcost;

	private int currentcost;

	private int currentOverlayCost;

	private Vector2 oneLinePos;

	private Vector2 twoLinePos;

	private Color _remainedCostColor;

	private Color _usedCostColor;

	private int startedCostInRound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableCanvas(bool enable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart(int p)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHightlightedCurrentCostCard(int overlaycost, int currentequipcardCost)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentMaxCost(int _maxcost)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentCost(int currentcost)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitCostUI()
	{
		throw null;
	}

	public struct CostBattleUIImage
	{
		public GameObject parent;

		public Image costBg;

		public Image costCotent;

		public Image costOverlay;

		public Animator costanim;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CostBattleUIImage(GameObject _p)
		{
			throw null;
		}
	}
}
