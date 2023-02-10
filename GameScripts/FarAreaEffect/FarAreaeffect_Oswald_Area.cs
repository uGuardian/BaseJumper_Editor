using System;
using System.Runtime.CompilerServices;

public class FarAreaeffect_Oswald_Area : FarAreaEffect
{
	private const float attackDelay = 1.5f;

	private const float animEndTime = 2.5f;

	private float elapsed;

	private bool damaged;

	private bool ended;

	private ReverberationBand_Map2 _map;

	private ReverberationBand_Map2 Map
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
	public virtual void PrintSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaeffect_Oswald_Area()
	{
		throw null;
	}
}
