using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEquipPageOperatingButton : Button
{
	[Header("Additional Reference")]
	[SerializeField]
	private Graphic[] g_changecolors;

	[SerializeField]
	private Image[] img_highlighted_enabled;

	[SerializeField]
	private TextMeshProUGUI[] txt_highlighted_enabled;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIEquipPageOperatingButton()
	{
		throw null;
	}
}
