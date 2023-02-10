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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDarknessFilter(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCharmFilter(bool existCharm)
	{
		throw null;
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
	protected override void Update()
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
	private void PauseRencounter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResumeRencounter()
	{
		throw null;
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
