using System;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitInformationUI_BuffSlot : MonoBehaviour
{
	[SerializeField]
	private Image _img_icon;

	public TextMeshProUGUI _txt_stacknum;

	[SerializeField]
	private UICustomSelectableUnitInfoSlot _selectable;

	private UIBufOverlay _tooltip_buff;

	private Camera _camera;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICustomSelectableUnitInfoSlot GetSelectable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCamera(Camera camera)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(Sprite sp, int stacknum)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToolTipData(BattleUnitBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_BuffSlot()
	{
		throw null;
	}
}
