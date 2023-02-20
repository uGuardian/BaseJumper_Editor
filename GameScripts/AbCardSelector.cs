using System;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class AbCardSelector : MonoBehaviour
{
	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private BattleUnitView _view;

	[SerializeField]
	private CanvasGroup _selectionGroup;

	[SerializeField]
	private CanvasGroup _dialogGroup;

	[SerializeField]
	private TextMeshProUGUI _lvText;

	[SerializeField]
	private _2dxFX_PlasmaShield imgEffect;

	public UICustomSelectable_autofind selectable;

	private BattleUnitModel _model;

	private bool _initialized;

	public BattleUnitView view
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool isInitialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitModel model, int emotionLv = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSelectButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Over()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Unover()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplaySelectionDialog(EmotionCardXmlInfo card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOffUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbCardSelector()
	{
		throw null;
	}
}
