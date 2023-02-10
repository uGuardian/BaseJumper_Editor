using System;
using System.Collections;
using System.Runtime.CompilerServices;

public class FarAreaeffect_Nosferatu_Area : FarAreaEffect
{
	private const float _filterTargetR = 0.7f;

	private const float _filterOnTime = 0.6f;

	private const float _filterKeepTime = 0.45f;

	private const float _filterOffTime = 0.6f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FilterCoroutine(CameraFilterPack_Colors_Adjust_ColorRGB f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaeffect_Nosferatu_Area()
	{
		throw null;
	}
}
