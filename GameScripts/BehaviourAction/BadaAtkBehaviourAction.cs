using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BadaAtkBehaviourAction : MonoBehaviour
{
	[Header("Animation Curves")]
	public AnimationCurve moveUpSelfCurve;

	public AnimationCurve downAtkSelfCurve;

	public AnimationCurve airbornedOpponentCurve;

	public AnimationCurve moveUpOpponentCurve;

	public AnimationCurve knockdownOpponentCurve;

	[Header("Speed")]
	public float moveUpSelfSpeed;

	public float downAtkSelfSpeed;

	public float airbornedOpponentSpeed;

	public float moveUpOpponentSpeed;

	public float knockdownOpponentSpeed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BadaAtkBehaviourAction()
	{
		throw null;
	}
}
