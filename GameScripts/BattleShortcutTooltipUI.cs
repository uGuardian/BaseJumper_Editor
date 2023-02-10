using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleShortcutTooltipUI : SingletonBehavior<BattleShortcutTooltipUI>
{
	[SerializeField]
	private GameObject tooltipslot;

	[SerializeField]
	private RectTransform ob_shorcutkey;

	[SerializeField]
	private TextMeshProUGUI txt_key;

	[SerializeField]
	private TextMeshProUGUI txt_content;

	[SerializeField]
	private Image img_frame;

	[SerializeField]
	private Image img_bg;

	private RectTransform rect_target;

	private Vector3 offsetPos;

	private readonly float keyheight;

	private readonly float mintextheight;

	[Range(1f, 100f)]
	public float offset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(string contentkey, string shortcutkey, RectTransform t, Vector3 offsetpos, bool showKey = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Show(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPosition(RectTransform t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleShortcutTooltipUI()
	{
		throw null;
	}
}
