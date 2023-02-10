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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(string key)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColorDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColorHighlight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEditText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UISearchFilterPanel()
	{
		throw null;
	}
}
