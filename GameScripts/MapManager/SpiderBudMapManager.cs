using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpiderBudMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer _bgNormal;

	[SerializeField]
	private SpriteRenderer _bgSpiderBudActivated;

	[SerializeField]
	private SpriteRenderer _bgSpiderBudActivated2;

	private Dictionary<SpiderBudMapManager.DlgType, CreatureBattleDlgInfo> _dlgDictionary;

	private SpiderBudMapManager.DlgType _curDlgType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProtectionFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpiderBudFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ProtectionRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBudActivated(bool isBudActivated)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ChangeBgRoutine(bool isBudActivated)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateDialog(SpiderBudMapManager.DlgType dlgType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpiderBudMapManager()
	{
		throw null;
	}

	public enum DlgType
	{
		NORMAL,
		CHILDDEAD
	}
}
