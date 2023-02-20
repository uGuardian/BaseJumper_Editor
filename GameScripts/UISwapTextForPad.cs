using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class UISwapTextForPad : MonoBehaviour
{
	[Header("Key")]
	[SerializeField]
	private string padkey;

	private UITextDataLoader textloader;

	private string originkey;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UISwapTextForPad()
	{
		throw null;
	}
}
