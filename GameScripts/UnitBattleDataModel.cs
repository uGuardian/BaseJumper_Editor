using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class UnitBattleDataModel
{
	public UnitDataModel unitData;

	public UnitBattleStageHistory historyInStage;

	public UnitBattleWaveHistory historyInWave;

	public bool isDead;

	public UnitBattleDataModel.ReviveState reviveState;

	public bool revivedByEgo;

	public float hp;

	public int gainExp;

	public readonly float plusExpPerByEmotionLevel;

	public List<GiftModel> gainGifts;

	public BattleUnitEmotionDetail emotionDetail;

	public SephirahType lastFloor;

	public bool enterTheBattle;

	private bool _isAddedBattle;

	public bool isLocked;

	public UnitBattleDataModel.FloorBattleData floorBattleData;

	public UnitHistoryModel historyInUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int TextureIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int MaxEmotionLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int MaxHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsAddedBattle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitBattleDataModel(StageModel stage, UnitDataModel data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refreshhp()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddGaindGifts(List<GiftModel> gifts)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddExp(int exp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnitBattleDataModel CreateUnitBattleDataByEnemyUnitId(StageModel stage, LorId id)
	{
		throw null;
	}

	public class FloorBattleData
	{
		public int param1;

		public int param2;

		public int param3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FloorBattleData()
		{
			throw null;
		}
	}

	public enum ReviveState
	{
		None,
		OneRound,
		Permanent
	}
}
