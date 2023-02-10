using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BattleEmotionBarPortraitUI : MonoBehaviour
{
	[SerializeField]
	private Image _frame;

	[SerializeField]
	private Image _linearDodge;

	[SerializeField]
	private RawImage _portrait;

	[SerializeField]
	private Canvas _canvas;

	public Vector3 from;

	public Vector3 to;

	private BattleUnitModel _unit;

	private BattleEmotionInfoManagerUI _manager;

	private bool _bGrayscaled;

	private int _parentCanvasOrder;

	public BattleUnitModel unit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitModel unit, BattleEmotionInfoManagerUI manager)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGrayScale()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPosDirect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColor(Color frame, Color linearDodge)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionBarPortraitUI()
	{
		throw null;
	}
}
