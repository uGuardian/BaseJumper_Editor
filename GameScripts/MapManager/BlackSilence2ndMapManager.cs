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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BlackSilence2ndMapManager()
	{
		throw null;
	}
}
