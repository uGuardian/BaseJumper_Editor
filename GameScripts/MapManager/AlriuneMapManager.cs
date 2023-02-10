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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Super()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindOnce()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindOn()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindStrong()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WindOff()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AlriuneMapManager()
	{
		throw null;
	}
}
