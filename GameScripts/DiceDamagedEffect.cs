using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Animator))]
public class DiceDamagedEffect : MonoBehaviour
{
	[SerializeField]
	private Sprite[] sprites;

	[SerializeField]
	[Range(0f, 90f)]
	private float randomAngleRange;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(bool flip, float scaleFactor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimationEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceDamagedEffect()
	{
		throw null;
	}
}
