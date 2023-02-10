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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActiveWeapon(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveWeapon(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeactiveWeapon()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRemainedWeaponCnt()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinDirection()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinDirectionEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PhaseChangeEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DieEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AttatchAura()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BoomFirst()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BoomSecond()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyAura()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllWeapons()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BlackSilence4thMapManager()
	{
		throw null;
	}
}
