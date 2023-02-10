using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MalkuthMapManager : MapManager
{
	public Transform bg4F;

	public Transform bg3F;

	public Transform bg2F;

	public Transform bgChild4F;

	public Transform bgChild3F;

	public Transform bgChild2F;

	public Transform fgChildB1;

	public float[] yOffsetBG4F;

	public float[] yOffsetBG3F;

	public float[] yOffsetBG2F;

	public float soarOffsetBG4F;

	public float soarOffsetBG3F;

	public float soarOffsetBG2F;

	public float soarOffsetFGB1;

	public float[] soarFrequency;

	public float soarSpeed;

	private float _curOffsetBG4F;

	private float _curOffsetBG3F;

	private float _curOffsetBG2F;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RefreshPos(Transform t, float yOffset, bool lerp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SoarRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MalkuthMapManager()
	{
		throw null;
	}

	public enum SoarState
	{
		None,
		Up,
		Down
	}
}
