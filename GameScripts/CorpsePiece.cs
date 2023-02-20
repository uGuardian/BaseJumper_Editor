using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CorpsePiece : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve speedMaxCurve;

	[SerializeField]
	private AnimationCurve speedMinCurve;

	[SerializeField]
	private SpriteRenderer sprRenderer;

	private Vector3 _moveDirection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Vector3 pos, Vector3 dir, Sprite sp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator Move()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CorpsePiece()
	{
		throw null;
	}
}
