using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ReverberationBand_Map1 : CreatureMapManager
{
	[SerializeField]
	private Material _matBgRef;

	[SerializeField]
	private SpriteRenderer _bg;

	[SerializeField]
	private float _bgSpeed;

	[SerializeField]
	private Color _philipDlgColor;

	[SerializeField]
	private Color _eileenDlgColor;

	[SerializeField]
	private Color _gretaDlgColor;

	[SerializeField]
	private Color _bremenDlgColor;

	[SerializeField]
	private Color[] _gradientColors;

	private float _elapsedGradient;

	private int _gradientIdx;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeBremenDlgColor(CreatureDlgEffectUI dlg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReverberationBand_Map1()
	{
		throw null;
	}
}
