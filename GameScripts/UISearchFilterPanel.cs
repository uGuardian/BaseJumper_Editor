using System;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UISearchFilterPanel : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField inputField;

	[SerializeField]
	private TMP_Text searchText;

	[SerializeField]
	private Image searchImage;

	[SerializeField]
	private UnityEvent onChangeFilterEvent;

	public UICustomSelectable selectable;

	[HideInInspector]
	public string SearchKey;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(string key)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColorDefault()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColorHighlight()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEditText()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UISearchFilterPanel()
	{
		throw null;
	}
}
