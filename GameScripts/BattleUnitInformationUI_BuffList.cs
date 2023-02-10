using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleUnitInformationUI_BuffList : MonoBehaviour
{
	[SerializeField]
	private BattleUnitInformationUI _parentUI;

	[SerializeField]
	private List<BattleUnitInformationUI_BuffSlot> BuffIconSlot;

	private List<BattleUnitInformationUI_BuffSlot> _activatedSlots;

	public List<BattleUnitInformationUI_BuffSlot> ActivatedSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(List<BattleUnitBuf> buflist)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefault()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_BuffList()
	{
		throw null;
	}
}
