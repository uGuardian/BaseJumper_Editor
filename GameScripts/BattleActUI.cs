using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleActUI : MonoBehaviour
{
	public bool isAnimPlaying;

	[SerializeField]
	private Image img_bgMask;

	[SerializeField]
	private Image frame;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private Image img_textShape;

	[SerializeField]
	private TextMeshProUGUI txtActTitle;

	[SerializeField]
	private TextMeshProUGUI txtActNumber;

	[SerializeField]
	private Animator animator;

	private bool _bAppear;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartAct(int actLv, List<BattleUnitModel> unitList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAppearAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDisappearAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator AnimRoutine(int actLv, List<BattleUnitModel> unitList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndActAnim(int actLv, List<BattleUnitModel> unitList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeAct(int actLv, List<BattleUnitModel> unitList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleActUI()
	{
		throw null;
	}
}
