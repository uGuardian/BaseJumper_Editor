using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

[Serializable]
public class UIBgPositionByPhase
{
	public UIPhase phase;

	public Vector2 leftpos;

	public Vector2 rightpos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIBgPositionByPhase()
	{
		throw null;
	}
}
