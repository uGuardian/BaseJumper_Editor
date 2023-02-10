using System;
using System.Runtime.CompilerServices;

public class FarAreaEffect_Philip : FarAreaEffect
{
	private const float attackDelay = 0.8f;

	private const float damageDelay = 1.8f;

	private const float animEndTime = 2.1f;

	private float elapsed;

	private bool attacked;

	private bool damaged;

	private bool ended;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
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
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Philip()
	{
		throw null;
	}
}
