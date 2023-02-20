using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EstherSwordEffect : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer forwardSprite;

	[SerializeField]
	private SpriteRenderer backwardSprite;

	private float _alpha;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static EstherSwordEffect CreateEstherSwordEffect(BattleUnitView unitView, Direction dir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EstherSwordEffect()
	{
		throw null;
	}
}
