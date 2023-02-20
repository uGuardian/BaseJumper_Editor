using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class BigBirdMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer _redemptionBg;

	[SerializeField]
	private SpriteRenderer _charmBg;

	[SerializeField]
	private UIAnimationEventHandler _redemptionAnimHandler;

	[SerializeField]
	private UIAnimationEventHandler _charmAnimHandler;

	private BigBirdMapManager.BigBirdState _state;

	[SerializeField]
	private SpriteRenderer _darknessBg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRedemptionFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDarknessFilter(bool on)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCharmFilter(bool existCharm)
	{
		
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
	public override void OnRoundStart()
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
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PauseRencounter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResumeRencounter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BigBirdMapManager()
	{
		throw null;
	}

	public enum BigBirdState
	{
		Normal,
		Lamp,
		Sleep
	}
}
