using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CreatureMapManager : MapManager
{
	protected List<string> _creatureDlgIdList;

	protected CreatureDlgEffectUI _dlgEffect;

	protected int _dlgIdx;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateDialog(Color txtColor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureMapManager()
	{
		throw null;
	}
}
