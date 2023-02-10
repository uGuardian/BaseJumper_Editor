using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleFocusActionUI : SingletonBehavior<BattleFocusActionUI>
{
	[Header("Reference")]
	public Color[] color_rwbp;

	public Color[] color_rwbpLinearDodge;

	public Color[] color_rwbpFinal;

	public Color[] color_rwbpLinearDodgeFinal;

	public Color color_atkDice;

	public Color color_atkDiceLinearDodge;

	public Color color_atkDiceNum;

	public Color color_atkDiceFinal;

	public Color color_atkDiceLinearDodgeFinal;

	public Color color_atkDiceNumFinal;

	public Color color_defDice;

	public Color color_defDiceLinearDodge;

	public Color color_defDiceNum;

	public Color color_defDiceFinal;

	public Color color_defDiceLinearDodgeFinal;

	public Color color_defDiceNumFinal;

	public Color color_destroyDice;

	public Color color_destroyDiceLinearDodge;

	public BattleFocusActionUI_Info rightInfo;

	public BattleFocusActionUI_Info leftInfo;

	public Canvas rightInfoCanvas;

	public Canvas leftInfoCanvas;

	public BattlePlayingCardDataInUnitModel leftCard;

	public BattlePlayingCardDataInUnitModel rightCard;

	public bool IsFocusActionEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsExtraActionEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetInfo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusAction(BattlePlayingCardDataInUnitModel playingCard, float speed = 1f)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutAction(BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFocusActionUI(BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFailDiceActionUI(BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndActionAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusFrameAppear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleFocusActionUI()
	{
		throw null;
	}
}
