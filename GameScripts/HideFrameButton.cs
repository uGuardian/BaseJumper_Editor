using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HideFrameButton : CustomButton
{
	[Header("Additional Reference")]
	public Image img_bg;

	public Image img_Frame;

	public TextMeshProUGUI txt_name;

	public float minimumWidth;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSize()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HideFrameButton()
	{
		throw null;
	}
}
