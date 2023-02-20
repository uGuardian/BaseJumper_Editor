using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class KeywordUI : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI KeywordNameText;

	[SerializeField]
	private TextMeshProUGUI KeywordDescText;

	private string _name;

	private string _desc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(string name, string desc)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeywordUI()
	{
		throw null;
	}
}
