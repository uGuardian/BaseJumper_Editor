using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChapterUI : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private Image logo;

	[SerializeField]
	private Text index;

	[SerializeField]
	private Text title;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerClick(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTitle(string idx, string desc)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChapterUI()
	{
		throw null;
	}
}
