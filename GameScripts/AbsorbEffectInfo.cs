using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AbsorbEffectInfo
{
	public GameObject effectObj;

	public SimpleBezier curve;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbsorbEffectInfo(GameObject effectObj, Vector3 src, Vector3 dst)
	{
		this.effectObj = effectObj;
		this.curve = new SimpleBezier(src, dst);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPos(float t)
	{

	}
}
