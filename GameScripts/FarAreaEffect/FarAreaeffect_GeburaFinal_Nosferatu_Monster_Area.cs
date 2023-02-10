using System;
using System.Collections;
using System.Runtime.CompilerServices;

public class FarAreaeffect_GeburaFinal_Nosferatu_Monster_Area : FarAreaEffect
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

	private MapManager _map;

	private MapManager Map
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
	public FarAreaeffect_GeburaFinal_Nosferatu_Monster_Area()
	{
		throw null;
	}
}
