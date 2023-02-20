using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class ReverberationBand_Map3 : CreatureMapManager
{
	[SerializeField]
	private Color _elenaDlgColor;

	[SerializeField]
	private Color _plutoDlgColor;

	[SerializeField]
	private Color _argaliaDlgColor;

	[SerializeField]
	private GameObject _finalEffect;

	[SerializeField]
	private UIAnimationEventHandler _finalHandler;

	[SerializeField]
	private GameObject _castingEffect;

	[SerializeField]
	private UIAnimationEventHandler _castingHandler;

	[SerializeField]
	private AudioClip _castingSound;

	[SerializeField]
	private AudioClip _rolandAppearSound;

	[SerializeField]
	private AudioClip _breakSound;

	[SerializeField]
	private AudioClip _breakSound2;

	private BattleUnitModel _argalia;

	private BattleUnitModel _roland;

	private bool _bDisplayDlg;

	private float _delay;

	private float _elapsedDelay;

	private bool _bDelayed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRunningEffect(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFinalEffect(BattleUnitModel argalia, BattleUnitModel roland, float delay)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActivateCastingEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStartFinal()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnAppear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEndEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnBreak()
	{
		
	}

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
	public ReverberationBand_Map3()
	{
		throw null;
	}
}
