using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class BattleFinalEndUI : MonoBehaviour
{
	public List<Image> victoryImgs;

	public List<Image> defeatImgs;

	public Image borderImg;

	public TextMeshProUGUI txt_Result;

	public TextMeshProUGUI txt_ResultEffect;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private _2dxFX_GoldenFX victoryTextImgEffect;

	private float elapsed;

	private bool _bAnimEnd;

	private bool _victory;

	[SerializeField]
	private Image _enemyIconGlow;

	[SerializeField]
	private Image _enemyIconFrame;

	private BattleFinalEndUI.AfterAnimEvent _endFunc;

	[Header("controller")]
	public UICustomSelectable selectable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndFinalBattle(bool victory, BattleFinalEndUI.AfterAnimEvent endFunc)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTypoAnim(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDisableUI()
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
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSubmit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleFinalEndUI()
	{
		throw null;
	}

	public delegate void AfterAnimEvent(bool param);
}
