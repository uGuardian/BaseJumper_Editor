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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDeselectBar()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetScrollRectSize(float x, float y)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWindowPosition(float x, float y)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetScrollVector(Vector2 vec)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClampBarSize()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerDownUpButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerDownDownButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExitOrUp()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnExitEvent(BaseEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICustomScrollBar()
	{
		throw null;
	}
}
