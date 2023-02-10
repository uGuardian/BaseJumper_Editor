using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class BattleSceneRoot : SingletonBehavior<BattleSceneRoot>
{
	private const string floorMapPrefabPath = "LibraryMaps/";

	public List<MapManager> mapList;

	public MapManager currentMapObject;

	public GameObject startAnimObj;

	public GameObject endAnimObj;

	public GameObject endAnimObjForKeterFinal;

	public UIAnimationEventHandler animHandler_endForKeterFinal;

	[SerializeField]
	private MapChangeFilter _mapChangeFilter;

	[SerializeField]
	private List<MapManager> _addedMapList;

	private bool _battleStarted;

	private int i;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BattleSceneRoot()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScreenAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartBattleRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFloorMapPreLoad()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearFloorMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideAllFloorMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadFloorAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFloor(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitFloorMap(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitCreatureMap(MapManager m)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBlackSilenceFirstPhase(MapManager m)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCreatureMap(string mapName, bool boss, bool enlarge = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitInvitationMap(MapManager m)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEgoMap(MapManager m)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ChangeToSpecialMap(string mapName, bool playEffect, bool scaleChange = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeToSephirahMap(SephirahType sephirah, bool playEffect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEgoMapAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeToEgoMap(string mapName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnFromEgoMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndBattle(bool force = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndBattleForKeterFinal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattleAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckInput()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExitStage()
	{
		throw null;
	}
}
