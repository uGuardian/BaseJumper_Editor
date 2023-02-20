using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;
using UnityEngine.UI;

public class BattleFocusActionUI_Dice : MonoBehaviour
{
	private bool _isDestroyed;

	[Header("Reference")]
	[SerializeField]
	private List<Sprite> refSprite_numbers;

	[SerializeField]
	private List<BattleFocusActionUI_Dice.DiceSprite> refSprites_dice;

	[SerializeField]
	private List<Sprite> refSprite_typeDetails;

	[SerializeField]
	private List<Vector3> refRwbpHsv_typeDetails;

	[Header("Runtime")]
	[SerializeField]
	private Image img_tensPlaces;

	[SerializeField]
	private Image img_unitsPlaces;

	[SerializeField]
	private Image img_diceFace;

	[SerializeField]
	private Image img_diceFaceSecond;

	[SerializeField]
	private Image img_diceLinearDodge;

	[SerializeField]
	private Image img_diceActionDetail;

	[SerializeField]
	private Image img_diceFailFace;

	[SerializeField]
	private Image img_diceFailLinearDodge;

	[SerializeField]
	private Animator animator_diceFail;

	[SerializeField]
	private Image img_diceDestroy;

	[SerializeField]
	private Image img_diceDestroyLinearDodge;

	[SerializeField]
	private Animator animator_diceDestroy;

	private bool _bFadeoutValue;

	private float _elapsedFadeoutValue;

	private Vector3 diceNumScale;

	public bool IsDestroyed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableDetailIcon(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAlpha(float alpha)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableImgs(bool e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AppearDestroyIcon()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareDiceUI(BattleDiceBehavior diceBehaviour)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFace(int face)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFaceSprite(int face)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVanillaValue(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFinalValue(int value, DiceBehaviour behaviour)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeoutValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDicesColor(DiceBehaviour behaviour)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDicesFinalColor(DiceBehaviour behaviour)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDicesColor(BehaviourType behaviourType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDicesFinalColor(BehaviourType behaviourType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sprite GetBehaviourTypeDetailSprite(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleFocusActionUI_Dice.DiceSprite GetFaceSprite(int face)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sprite GetValueSprite(int number)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleFocusActionUI_Dice()
	{
		throw null;
	}

	[Serializable]
	public class DiceSprite
	{
		[SerializeField]
		internal Sprite sprDiceImg;

		[SerializeField]
		internal Sprite sprLinearDodge;

		[SerializeField]
		internal Sprite sprFailDiceImg;

		[SerializeField]
		internal Sprite sprFailLinearDodge;

		[SerializeField]
		internal Vector2 centerPos;

		[SerializeField]
		internal Vector2 centerOffset;

		[SerializeField]
		internal Vector2 detailIconOffset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceSprite()
		{
			throw null;
		}
	}
}
