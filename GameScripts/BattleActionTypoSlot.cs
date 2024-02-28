using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleActionTypoSlot : MonoBehaviour
{
	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private Image img_Frame;

	[SerializeField]
	private Image img_Icon;

	[SerializeField]
	private Image img_IconGlow;

	[SerializeField]
	private TextMeshProUGUI txt_title;

	[SerializeField]
	private TextMeshProMaterialSetter msetter_title;

	[SerializeField]
	private TextMeshProUGUI txt_desc;

	[SerializeField]
	private CanvasGroup cg;

	private float defaultFrameHeight;

	private float TitleFrameHeight;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(EffectTypoData data, BattleUnitView view)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDir(Direction dir)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartReveal()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartHide()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideForcely()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RevealProcess()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator HideProcess()
	{
		throw null;
	}
}
