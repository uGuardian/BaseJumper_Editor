using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PEButtonScript : MonoBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	private Button myButton;

	public ButtonTypes ButtonType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnButtonClicked()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PEButtonScript()
	{
		throw null;
	}
}
