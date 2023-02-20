using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitProfileInfoUI_EmotionLvTooltip_Slot : MonoBehaviour
{
	[SerializeField]
	private Color _activatedColor;

	[SerializeField]
	private Color _disabledColor;

	[SerializeField]
	private RefineHsv _imgFrame;

	[SerializeField]
	private Image _imgLinearDodge;

	[SerializeField]
	private TextMeshProUGUI _textUI;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActivated(bool b, int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitProfileInfoUI_EmotionLvTooltip_Slot()
	{
		throw null;
	}
}
