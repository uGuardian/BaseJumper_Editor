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
		get
		{
			return this._unit;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitModel unit, BattleEmotionInfoManagerUI manager)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGrayScale()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPosDirect()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColor(Color frame, Color linearDodge)
	{

	}
}
