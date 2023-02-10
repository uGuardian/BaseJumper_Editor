using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CamRootRotator : MonoBehaviour
{
	public AnimationCurve xOffsetCurve;

	public SpriteRenderer mapBorder;

	public Transform lookAt;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float amplitude;

	private float _elapsed;

	[SerializeField]
	private float _yDstPos;

	public float ySpeed;

	private bool _bExpanding;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBorder(float ortho, float yOffsetLv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MovePos(float dstX)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CamRootRotator()
	{
		throw null;
	}
}
