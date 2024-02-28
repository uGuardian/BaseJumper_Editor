using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class BattleFloorEndUI : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private List<Image> victoryImgs;

	[SerializeField]
	private List<Image> defeatImgs;

	[SerializeField]
	private TextMeshProUGUI txt_desc;

	[Header("controller")]
	public UICustomSelectable selectable;

	private bool _bAppear;

	private bool _victory;

	private BattleFloorEndUI.AfterAnimationEvent _endFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndBattleInFloor(bool victory, StageType stageType, BattleFloorEndUI.AfterAnimationEvent endFunc)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAppearAnimEnd()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTypoAnim()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDisappearAnimEnd()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSubmit()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator asd()
	{
		throw null;
	}

	public delegate void AfterAnimationEvent(bool param);
}
