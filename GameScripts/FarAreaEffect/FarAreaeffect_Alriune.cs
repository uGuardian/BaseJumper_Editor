using System;
using System.Runtime.CompilerServices;

public class FarAreaeffect_Alriune : FarAreaEffect
{
	private const float _filterTime = 0.5f;

	private const float _filterSpeed = 1.8f;

	private const float _filterSize = 5f;

	protected float elapsed;

	protected float attackDelay;

	protected float animEndTime;

	private bool damaged;

	private bool ended;

	private AlriuneMapManager _map;

	private CreatureEffect_Alriune_Curtain _curtain;

	protected AlriuneMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected CreatureEffect_Alriune_Curtain Curtain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
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
	public FarAreaeffect_Alriune()
	{
		throw null;
	}
}
