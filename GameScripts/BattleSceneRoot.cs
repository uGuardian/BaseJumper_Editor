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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScreenAnimEnd()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideAllFloorMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadFloorAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFloor(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitFloorMap(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitCreatureMap(MapManager m)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBlackSilenceFirstPhase(MapManager m)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCreatureMap(string mapName, bool boss, bool enlarge = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitInvitationMap(MapManager m)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEgoMap(MapManager m)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ChangeToSpecialMap(string mapName, bool playEffect, bool scaleChange = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeToSephirahMap(SephirahType sephirah, bool playEffect)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEgoMapAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeToEgoMap(string mapName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnFromEgoMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndBattle(bool force = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndBattleForKeterFinal()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattleAnimEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckInput()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExitStage()
	{
		
	}
}
