using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleEmotionInfo_TargetToggles : MonoBehaviour
{
	[SerializeField]
	private List<Toggle> toggleList;

	private BattleUnitTargetArrowManagerUI targetArrowManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefault()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Toggle GetToggle(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToggle(int idx, bool on)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowEnemyArrowInToggle(bool show)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowParryingArrowInToggle(bool show)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAllyArrowInToggle(bool show)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSumbit_Enemy(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSumbit_Parrying(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSumbit_Ally(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdCancel(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionInfo_TargetToggles()
	{
		throw null;
	}
}
