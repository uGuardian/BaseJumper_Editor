using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(_2dxFX_Ghost))]
public class BattleSimpleActionUI_TuneDice : MonoBehaviour
{
	private _2dxFX_Ghost _effect;

	[SerializeField]
	protected Image img_Dice;

	[SerializeField]
	private List<BattleFocusActionUI_Dice.DiceSprite> refSprites_dice;

	public AnimationCurve ghostCurve;

	private float _elapsedTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSprite(int face, int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleFocusActionUI_Dice.DiceSprite GetFaceSprite(int face)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleSimpleActionUI_TuneDice()
	{
		throw null;
	}
}
