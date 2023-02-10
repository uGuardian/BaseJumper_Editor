using System;
using System.Runtime.CompilerServices;

public class FarAreaEffect_Bremen : FarAreaEffect
{
	private const float attackDelay = 0.3f;

	private const float animEndTime = 3.1f;

	private float elapsed;

	private bool damaged;

	private bool ended;

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
	public virtual void PrintSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Bremen()
	{
		throw null;
	}
}
