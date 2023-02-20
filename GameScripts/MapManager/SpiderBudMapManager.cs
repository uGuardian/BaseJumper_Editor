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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpiderBudFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ProtectionRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBudActivated(bool isBudActivated)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ChangeBgRoutine(bool isBudActivated)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateDialog(SpiderBudMapManager.DlgType dlgType)
	{
		
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
