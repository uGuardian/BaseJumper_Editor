using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleActionTypoUI : MonoBehaviour
{
	[SerializeField]
	private BattleActionTypoSlot passivePrefab;

	[SerializeField]
	private RectTransform passiveRoot;

	private Direction currentdir;

	private List<BattleActionTypoSlot> prevActions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTypo(List<EffectTypoData> datas, BattleUnitView unitview)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator NewActionTextRoutine(List<EffectTypoData> strList, BattleUnitView _unitView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HidePrevActions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideActionsForcely()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleActionTypoUI()
	{
		throw null;
	}
}
