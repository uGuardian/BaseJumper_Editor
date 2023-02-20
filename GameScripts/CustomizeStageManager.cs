using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeStageManager : MonoBehaviour
{
	private static CustomizeStageManager _instance;

	public InputField[] inputFields;

	public Image[] CheckMarks;

	public Button ConfirmButton;

	private StageInfo StageInfoDetail;

	public static CustomizeStageManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearStageInfo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckValidate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickConfirmButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeName(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFormation(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeUnit1(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeUnit2(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeUnit3(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFloorNum(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeBook1(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeBook2(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeChapter(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeID(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizeStageManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomizeStageManager()
	{
		throw null;
	}
}
