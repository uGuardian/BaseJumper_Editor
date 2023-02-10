using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AlriuneMapManager : CreatureMapManager
{
	[SerializeField]
	private GameObject _windEffect;

	[SerializeField]
	private GameObject _windLoopEffect;

	[SerializeField]
	private GameObject _windStrongLoopEffect;

	private const int _defaultDlgNum = 5;

	private const int _specialDlg1Num = 3;

	private const int _bossDlgNum = 9;

	private bool super;

	private CreatureEffect_Alriune_Curtain _curtain;

	protected CreatureEffect_Alriune_Curtain Curtain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

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
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Super()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindOnce()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindOn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindStrong()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindOff()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AlriuneMapManager()
	{
		throw null;
	}
}
