using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitInformationUI_PassiveList : MonoBehaviour
{
	[SerializeField]
	private RectTransform rect_scrollview;

	[SerializeField]
	private RectTransform rect_passiveListPanel;

	[SerializeField]
	private List<BattleUnitInformationUI_PassiveList.BattleUnitInformationPassiveSlot> passiveSlotList;

	[SerializeField]
	private Animator showHideAnim;

	[SerializeField]
	private _2dxFX_HSV[] showHideIcons;

	[SerializeField]
	private GameObject BGImage;

	private float minimumheight;

	private float passivespacing;

	private bool isShow;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(List<PassiveAbilityBase> passivelist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActive(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickHideShowButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnterHideShowButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnExitHideShowButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(float val)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_PassiveList()
	{
		throw null;
	}

	[Serializable]
	public class BattleUnitInformationPassiveSlot
	{
		public RectTransform Rect;

		public TextMeshProUGUI txt_PassiveDesc;

		public Image img_Icon;

		public Image img_IconGlow;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(PassiveAbilityBase passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitInformationPassiveSlot()
		{
			throw null;
		}
	}
}
