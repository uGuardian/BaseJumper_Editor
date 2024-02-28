using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogUI : MonoBehaviour
{
	[SerializeField]
	private BattleUnitView view;

	[SerializeField]
	private TextMeshProUGUI _txtAbnormalityDlg;

	[SerializeField]
	private Canvas _canvas;

	private Coroutine _routine;

	[SerializeField]
	private Image _speechBubble;

	[SerializeField]
	private TextMeshProUGUI _battleDialog;

	private bool _bEndedDisplay;

	private float xPos;

	public bool IsEndedDisplay
	{
		get
		{
			return this._bEndedDisplay;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableCanvas(bool b)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOnAbnormalityDlg(EmotionCardXmlInfo card)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOffAbnormalityDlg()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator AbnormalityDlgRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOnDialog(string dlg, float duration)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOffDialog()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DlgRoutine(string str, float duration)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{

	}
}
