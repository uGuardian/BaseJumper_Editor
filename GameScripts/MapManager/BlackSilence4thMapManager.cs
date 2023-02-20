using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BlackSilence4thMapManager : CreatureMapManager
{
	[SerializeField]
	private Color _dlgColor;

	[SerializeField]
	public GameObject[] weaponObjects;

	[SerializeField]
	public GameObject phaseEffect;

	[SerializeField]
	public GameObject dieEffect;

	[SerializeField]
	public GameObject weaponDisappearEffect;

	[SerializeField]
	public GameObject areaAuraEffect;

	[SerializeField]
	public GameObject areaBoomEffect;

	private int _remainedWeaponCnt;

	private GameObject _aura;

	private List<int> _weapons;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActiveWeapon(int id)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveWeapon(int id)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeactiveWeapon()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRemainedWeaponCnt()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinDirection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinDirectionEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PhaseChangeEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DieEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AttatchAura()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BoomFirst()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BoomSecond()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyAura()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllWeapons()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BlackSilence4thMapManager()
	{
		throw null;
	}
}
