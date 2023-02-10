using System;
using System.Runtime.CompilerServices;

public class NosferatuMapManager : CreatureMapManager
{
	private const int _defaultDlgNum = 4;

	private const int _specialDlgNum = 4;

	private const int _bossDlgNum = 11;

	private NosferatuMapManager.DlgPhase _phase;

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
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDlgPhase(NosferatuMapManager.DlgPhase phase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NosferatuMapManager()
	{
		throw null;
	}

	public enum DlgPhase
	{
		DEFAULT,
		TRANSFORMED
	}
}
