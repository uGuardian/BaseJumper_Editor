using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleMapEffectManager : SingletonBehavior<BattleMapEffectManager>
{
	[SerializeField]
	private BloodStainBehavior _bloodStainPrefab;

	[SerializeField]
	private Transform _effectRoot;

	private List<GameObject> _createdBloodStainList;

	private List<GameObject> _createdCraterList;

	[SerializeField]
	private List<GameObject> _otherEffectList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BattleMapEffectManager()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEffectToList(GameObject go)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateScratch(float m, Vector3 pos, Vector3 dir, float unitScale)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateWallCrater(Vector3 pos, HexagonalMapManager.WallDirection dir)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateBloodStainEffect(Vector3 pos, Vector2 dir, float scaleFactor)
	{
		
	}
}
