using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class DirectingDataSetter : SingletonBehavior<DirectingDataSetter>
{
	[Header("Battle Effect Typo")]
	[Range(0f, 10f)]
	public float Typo_revealSpeed;

	[Range(0f, 1f)]
	public float Typo_revealInterval;

	[Range(0f, 2f)]
	public float Typo_hidewaiting;

	public float Typo_intervalHeight;

	public AnimationCurve Typo_revealXposCurve;

	public AnimationCurve Typo_revealAlphaCurve;

	public float Typo_hidespeed;

	public bool OnGrayScale;

	public Color graycolor;

	[Header("Battle Targeting Arrow")]
	[Header("Move Speed")]
	[Range(0.1f, 10f)]
	public float target_MoveSpeed;

	[Header("Battle Dice Action Result Destroyed Vibe")]
	[Range(0.1f, 3f)]
	public float battleDice_VibePeriod;

	[Range(0.1f, 10f)]
	public float battleDice_VibePower;

	public AnimationCurve battleDice_VibePowerCurve;

	[Header("UI MAIN BG POS")]
	[SerializeField]
	private List<UIBgPositionByPhase> _mainBgPos;

	[Header("UI ENEMY TITLE ICON SIZE")]
	public float EnemyTitleIconQuestionSize;

	public float EnemyTitleIconNormalScaleSize;

	[Header("Keter Xmark Speed")]
	[Range(0f, 5f)]
	public float keterXmarkSpeed;

	[Header("Battle Typo Damage Text SIZE")]
	[Range(10f, 30f)]
	[SerializeField]
	private float _Default_SIZE;

	[Range(1f, 10f)]
	[SerializeField]
	private float _maxScale;

	[Range(10f, 30f)]
	[SerializeField]
	private float _Default_SIZE_ForTypo;

	[Range(1f, 10f)]
	[SerializeField]
	private float _maxScale_fortypo;

	[Range(10f, 30f)]
	[SerializeField]
	private float _Default_SIZE_Height;

	[Range(1f, 10f)]
	[SerializeField]
	private float _maxScale_height;

	[Range(1f, 10f)]
	[SerializeField]
	private float _maxdivdevalue_height;

	public List<UIBgPositionByPhase> MainBgPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIBgPositionByPhase GetBGPosData(UIPhase phase)
	{
		throw null;
	}

	public float DEFAULT_SIZE
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float MaxScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float DEFAULT_SIZE_ForTypo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float MaxScale_fortypo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float DEFAULT_SIZE_Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float MaxScale_height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float Maxdivdevalue_height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DirectingDataSetter()
	{
		throw null;
	}
}
