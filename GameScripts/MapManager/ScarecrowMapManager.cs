using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ScarecrowMapManager : CreatureMapManager
{
	private const float _filterTime = 1.5f;

	private const float _filterX = 0.5f;

	private const float _filterY = 0.5f;

	private const float _filterSpeed = 1.2f;

	private const int _defaultNum = 8;

	private const int _special_1_num = 3;

	private const int _special_2_num = 3;

	private List<string> _creatureDlgIdList2;

	private CreatureDlgEffectUI _dlgEffect2;

	private ScarecrowMapManager.ScarecrowDlgState _state;

	private ScarecrowMapManager.ScarecrowDlgState _tempState;

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
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDlgStateWithTemp()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDlgTempState(ScarecrowMapManager.ScarecrowDlgState state)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCameraFilter(bool isExhausted)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScarecrowMapManager()
	{
		throw null;
	}

	public enum ScarecrowDlgState
	{
		Default,
		Success,
		Fail
	}
}
