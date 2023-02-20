using System;
using System.Runtime.CompilerServices;

public class FarAreaEffect_RedHoodThrowEgo : FarAreaEffect_RedHoodThrow
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_RedHoodThrowEgo()
	{
		throw null;
	}
}
