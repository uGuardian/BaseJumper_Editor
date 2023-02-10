using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ButterflyMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer _filterSprite1;

	[SerializeField]
	private SpriteRenderer _filterSprite2;

	[SerializeField]
	private SpriteRenderer _filterSprite3;

	private const int _defaultDlgNum = 5;

	private const int _specialDlgNum = 3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilter_Super(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ButterflyMapManager()
	{
		throw null;
	}
}
