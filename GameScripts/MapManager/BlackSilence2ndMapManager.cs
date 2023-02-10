using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BlackSilence2ndMapManager : CreatureMapManager
{
	[SerializeField]
	private Color _dlgColor;

	[SerializeField]
	private AudioClip _effectSound;

	[SerializeField]
	private GameObject _phaseStartPrefab;

	private bool _bFirstRound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BlackSilence2ndMapManager()
	{
		throw null;
	}
}
