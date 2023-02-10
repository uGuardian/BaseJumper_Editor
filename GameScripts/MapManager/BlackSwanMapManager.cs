using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BlackSwanMapManager : CreatureMapManager
{
	[SerializeField]
	private List<BlackSwanMapManager.UnitObject> _unitObjectList;

	[SerializeField]
	private SpriteRenderer _breakFilter;

	[SerializeField]
	private AnimationCurve _reviveFilterCurve;

	[SerializeField]
	private SpriteRenderer _reviveFilter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetReviveFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ReviveFilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnitObject(int enemyUnitId, bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakFilter(bool enable)
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
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BlackSwanMapManager()
	{
		throw null;
	}

	[Serializable]
	public class UnitObject
	{
		public SpriteRenderer unitSprite;

		public int unitId;

		public Vector3Int formationPos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitObject()
		{
			throw null;
		}
	}
}
