using System;
using System.Collections;
using System.Runtime.CompilerServices;

public class FarAreaeffect_Nosferatu_Monster_Area : FarAreaEffect
{
	private const float _filterTargetR = 0.7f;

	private const float _filterOnTime = 0.6f;

	private const float _filterKeepTime = 0.45f;

	private const float _filterOffTime = 0.6f;

	private const float _filterAnimOpenTime = 0.5f;

	private const float _filterAnimOffTime = 1f;

	private const float _filterAnimKeepTime = 0.3f;

	private const float _filterAnimCloseTime = 0.5f;

	private const string _PREFAB_PATH = "Battle/SpecialEffect/NosferatuFilterEffect";

	private NosferatuMapManager _map;

	private NosferatuMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FilterCoroutine(CameraFilterPack_Colors_Adjust_ColorRGB f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaeffect_Nosferatu_Monster_Area()
	{
		throw null;
	}
}
