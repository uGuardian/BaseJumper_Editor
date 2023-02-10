using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UICustomScrollBar : MonoBehaviour
{
	public ScrollRect scrollRect;

	public Scrollbar scrollbar;

	public UICustomSelectable selectable;

	public RectTransform scrollWindow;

	public Image ImageUp;

	public Image ImageDown;

	public float controllerSpeed;

	public UnityEvent ExitEvent;

	private float value;

	private float width;

	private float height;

	private bool isMovingBar;

	public float Top
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectBar()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDeselectBar()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetScrollRectSize(float x, float y)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWindowPosition(float x, float y)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetScrollVector(Vector2 vec)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClampBarSize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerDownUpButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerDownDownButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExitOrUp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnExitEvent(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICustomScrollBar()
	{
		throw null;
	}
}
