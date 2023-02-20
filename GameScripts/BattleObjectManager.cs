using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleObjectManager
{
	private static BattleObjectManager _instance;

	private static int _idGen;

	private List<BattleUnitModel> _unitList;

	private int currentRow;

	private bool _gamePause;

	private List<BattleUnitModel> _allowedUnits;

	private float _battleFieldTimeScale;

	public static BattleObjectManager instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init_only()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BattleUnitModel CreateDefaultUnit(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitBehaviorTree(BattleUnitModel model)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterUnitByIndex(Faction faction, int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IList<BattleUnitModel> GetList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetList(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistsUnit(Predicate<BattleUnitModel> match)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetList(Predicate<BattleUnitModel> match)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetAliveList(bool includeKnockout = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetAliveList(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetAliveList_opponent(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetAliveListWithAvailable(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetAliveListExceptFaction(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetAliveList_random(Faction faction, int count)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetLevelUpList(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAccumulatedEmotionCoinAvr(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAccumulatedEmotionCoinSum(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetFriendlyAllList(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetEmotionGaugeMax()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetAverageHP()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetAverageHP(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetTotalHP()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdate(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetUnitWithIndex(Faction faction, int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetNearRandomTarget(BattleUnitModel actor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetNearOppositeTarget(BattleUnitModel actor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetFarOppositeTarget(BattleUnitModel actor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetTargetByCardForPlayer(BattleUnitModel actor, BattleDiceCardModel card, int idx, bool teamkill = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetTargetByCard(BattleUnitModel actor, BattleDiceCardModel card, int idx, bool teamkill = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetRandomTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetRandomTarget(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetTargetByIndex(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleObjectManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BattleObjectManager()
	{
		throw null;
	}
}
