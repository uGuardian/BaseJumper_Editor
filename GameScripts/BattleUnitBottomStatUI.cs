using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitBottomStatUI : MonoBehaviour
{
	[Header("Resources & References")]
	[SerializeField]
	private Color enemyLineColor;

	[SerializeField]
	private Color librarianLineColor;

	[SerializeField]
	private Sprite enemyCircle;

	[SerializeField]
	private Sprite librarianCircle;

	[SerializeField]
	private Sprite enemyIdentitySprite;

	[SerializeField]
	private Sprite librarianIdentitySprite;

	[SerializeField]
	private BattleUnitView _view;

	[SerializeField]
	private Mask hpBarMask;

	[SerializeField]
	private Image hpBar;

	[SerializeField]
	private Mask bpBarMask;

	[SerializeField]
	private Image bpBar;

	[SerializeField]
	private Image img_teamSprite;

	[SerializeField]
	private Image[] img_targetingLights;

	[SerializeField]
	private Image img_identityLight;

	[SerializeField]
	private Image img_teamSpriteBorder;

	[SerializeField]
	private Image[] bufIcons;

	[SerializeField]
	private TextMeshProUGUI[] txt_bufStacks;

	[SerializeField]
	private Image[] emotionLvImgs;

	[SerializeField]
	private TextMeshProUGUI _txtHp;

	[SerializeField]
	private TextMeshProUGUI _txtBp;

	private bool isHpBarAnimationRoutineRunning;

	public float AimHpValue;

	private float currentHpValue;

	private bool isBpBarAnimationRoutineRunning;

	public int AimBpValue;

	private float currentBpValue;

	private Coroutine _hpBarRoutine;

	private Coroutine _bpBarRoutine;

	[Header("Canvas attached this script")]
	[SerializeField]
	private Canvas _canvas;

	[Header("Canvas with informations")]
	[SerializeField]
	private Canvas _childCanvas;

	private bool _bClickedState;

	private float startangle;

	private float[] offsetwidth;

	private float[] offsetheight;

	private float[] intervalAngle;

	private float[] offsetsize;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Inits()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeLayer(string layer, string childCanvasLayer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeLayer(string layer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeChildLayer(string childCanvasLayer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeChildCanvasOrder(string sortingLayer, int order)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClickSpeedDice(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayChildCanvasOverSpeedDice(bool over)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateStatUI(float hp, int bp, BattleBufUIDataList bufList = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator HpBarAnimationRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BpBarAnimationRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEmotionLv()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBufs(BattleBufUIDataList bufDataList = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetClicked(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetingLightActive(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIdentityLightActive(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHOver(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableCanvas(bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableStatNumber(bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBottomStatUI()
	{
		throw null;
	}
}
