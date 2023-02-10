using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Jaeheon_ControlFail : BattleUnitBuf
{
	private const int _breakDmg = 20;

	public override bool Hide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Jaeheon_ControlFail()
	{
		throw null;
	}
}
