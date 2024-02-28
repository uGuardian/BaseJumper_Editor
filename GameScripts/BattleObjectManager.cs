using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleObjectManager
{
	private static BattleObjectManager _instance;

	private static int _idGen = 1;

	private List<BattleUnitModel> _unitList = new List<BattleUnitModel>();

	private int currentRow;

	private bool _gamePause;

	private List<BattleUnitModel> _allowedUnits = new List<BattleUnitModel>();

	private float _battleFieldTimeScale = 1f;

	public static BattleObjectManager instance
	{
		get
		{
			if (BattleObjectManager._instance == null)
			{
				BattleObjectManager._instance = new BattleObjectManager();
			}
			return BattleObjectManager._instance;
		}
	}

	public void Init_only()
	{
		this._unitList = new List<BattleUnitModel>();
	}

	public void InitUI()
	{
		SingletonBehavior<BattleManagerUI>.Instance.ui_unitInformation.Init();
		SingletonBehavior<BattleManagerUI>.Instance.ui_unitInformationPlayer.Init();
		SingletonBehavior<BattleManagerUI>.Instance.ui_unitListInfoSummary.Initialize(BattleObjectManager.instance.GetList());
		SingletonBehavior<BattleManagerUI>.Instance.ui_levelup.SetRootCanvas(false);
		SingletonBehavior<BattleManagerUI>.Instance.ui_emotionInfoBar.InitTeam();
		SingletonBehavior<BattleManagerUI>.Instance.ui_battleEmotionCoinUI.Init();
	}

	public static BattleUnitModel CreateDefaultUnit(Faction faction)
	{
		return new BattleUnitModel(BattleObjectManager._idGen++)
		{
			faction = faction
		};
	}

	public static void InitBehaviorTree(BattleUnitModel model)
	{
	}

	public void Clear()
	{
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			battleUnitModel.Book.SetOriginalResists();
			if (battleUnitModel.faction == Faction.Player)
			{
				battleUnitModel.Book.SetOriginalCharacterName();
			}
			battleUnitModel.passiveDetail.PassiveList.ForEach(delegate(PassiveAbilityBase x)
			{
				x.OnEndBattlePhase();
			});
			battleUnitModel.emotionDetail.GetSelectedCardList().ForEach(delegate(BattleEmotionCardModel x)
			{
				x.OnEndBattlePhase();
			});
			battleUnitModel.bufListDetail.GetActivatedBufList().ForEach(delegate(BattleUnitBuf x)
			{
				x.OnEndBattlePhase();
			});
		}
		this._unitList.Clear();
		BattleObjectLayer.instance.Clear();
	}

	public void RegisterUnit(BattleUnitModel unit)
	{
		unit.Book.SetOriginalResists();
		this._unitList.Add(unit);
		BattleObjectLayer.instance.AddUnit(unit);
	}

	public void UnregisterUnit(BattleUnitModel unit)
	{
		BattleObjectLayer.instance.RemoveUnit(unit);
		this._unitList.Remove(unit);
	}

	public void UnregisterUnitByIndex(Faction faction, int index)
	{
		BattleUnitModel battleUnitModel = this._unitList.Find((BattleUnitModel x) => x.faction == faction && x.index == index);
		if (battleUnitModel == null)
		{
			return;
		}
		BattleObjectLayer.instance.RemoveUnit(battleUnitModel);
		this._unitList.Remove(battleUnitModel);
	}

	public IList<BattleUnitModel> GetList()
	{
		return this._unitList;
	}

	public List<BattleUnitModel> GetList(Faction faction)
	{
		return this._unitList.FindAll((BattleUnitModel x) => x.faction == faction);
	}

	public bool ExistsUnit(Predicate<BattleUnitModel> match)
	{
		return this._unitList.Exists(match);
	}

	public List<BattleUnitModel> GetList(Predicate<BattleUnitModel> match)
	{
		return this._unitList.FindAll(match);
	}

	public List<BattleUnitModel> GetAliveList(bool includeKnockout = false)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		for (int i = 0; i < this._unitList.Count; i++)
		{
			BattleUnitModel battleUnitModel = this._unitList[i];
			if (!battleUnitModel.IsDead() || (includeKnockout && !battleUnitModel.IsDeadReal()))
			{
				list.Add(battleUnitModel);
			}
		}
		return list;
	}

	public List<BattleUnitModel> GetAliveList(Faction faction)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		for (int i = 0; i < this._unitList.Count; i++)
		{
			BattleUnitModel battleUnitModel = this._unitList[i];
			if (battleUnitModel.faction == faction && !battleUnitModel.IsDead())
			{
				list.Add(battleUnitModel);
			}
		}
		return list;
	}

	public List<BattleUnitModel> GetAliveList_opponent(Faction faction)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		for (int i = 0; i < this._unitList.Count; i++)
		{
			BattleUnitModel battleUnitModel = this._unitList[i];
			if (battleUnitModel.faction != faction && !battleUnitModel.IsDead())
			{
				list.Add(battleUnitModel);
			}
		}
		return list;
	}

	public List<BattleUnitModel> GetAliveListWithAvailable(Faction faction)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		for (int i = 0; i < this._unitList.Count; i++)
		{
			BattleUnitModel battleUnitModel = this._unitList[i];
			if (battleUnitModel.faction == faction && !battleUnitModel.IsDead() && !battleUnitModel.IsExtinction())
			{
				list.Add(battleUnitModel);
			}
		}
		return list;
	}

	public List<BattleUnitModel> GetAliveListExceptFaction(Faction faction)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		for (int i = 0; i < this._unitList.Count; i++)
		{
			BattleUnitModel battleUnitModel = this._unitList[i];
			if (battleUnitModel.faction != faction && !battleUnitModel.IsDead())
			{
				list.Add(battleUnitModel);
			}
		}
		return list;
	}

	public List<BattleUnitModel> GetAliveList_random(Faction faction, int count)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		List<BattleUnitModel> list2 = new List<BattleUnitModel>();
		using (List<BattleUnitModel>.Enumerator enumerator = BattleObjectManager.instance.GetAliveList(faction).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				BattleUnitModel item = enumerator.Current;
				list2.Add(item);
			}
			goto IL_65;
		}
		IL_47:
		BattleUnitModel item2 = RandomUtil.SelectOne<BattleUnitModel>(list2);
		list2.Remove(item2);
		list.Add(item2);
		count--;
		IL_65:
		if (list2.Count <= 0 || count <= 0)
		{
			return list;
		}
		goto IL_47;
	}

	public List<BattleUnitModel> GetLevelUpList(Faction faction)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			if (battleUnitModel.faction == faction && !battleUnitModel.IsDead() && battleUnitModel.emotionDetail.skillPoint > 0)
			{
				list.Add(battleUnitModel);
			}
		}
		return list;
	}

	public int GetAccumulatedEmotionCoinAvr(Faction faction)
	{
		int num = 0;
		int num2 = 0;
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			if (battleUnitModel.faction == faction)
			{
				num += battleUnitModel.emotionDetail.EmotionLevel * 10 + battleUnitModel.emotionDetail.AllEmotionCoins.Count;
				num2++;
			}
		}
		return num / num2;
	}

	public int GetAccumulatedEmotionCoinSum(Faction faction)
	{
		int num = 0;
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			if (battleUnitModel.faction == faction)
			{
				num += battleUnitModel.emotionDetail.EmotionLevel * 10 + battleUnitModel.emotionDetail.AllEmotionCoins.Count;
			}
		}
		return num;
	}

	public List<BattleUnitModel> GetFriendlyAllList(Faction faction)
	{
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			if (battleUnitModel.faction == faction)
			{
				list.Add(battleUnitModel);
			}
		}
		return list;
	}

	public float GetEmotionGaugeMax()
	{
		return this.GetAverageHP();
	}

	public float GetAverageHP()
	{
		return this.GetTotalHP() / (float)this._unitList.Count;
	}

	public float GetAverageHP(Faction faction)
	{
		int num = 0;
		float num2 = 0f;
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			if (battleUnitModel.faction == faction)
			{
				num2 += (float)battleUnitModel.MaxHp;
				num++;
			}
		}
		return num2 / (float)num;
	}

	public float GetTotalHP()
	{
		float num = 0f;
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			num += (float)battleUnitModel.MaxHp;
		}
		return num;
	}

	public void OnUpdate()
	{
	}

	public void OnFixedUpdate(float deltaTime)
	{
		BattleEffectLayer.instance.OnFixedUpdate(deltaTime);
		if (this._gamePause)
		{
			using (List<BattleUnitModel>.Enumerator enumerator = this._unitList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					BattleUnitModel battleUnitModel = enumerator.Current;
					battleUnitModel.SetTimeScale(0f);
				}
				return;
			}
		}
		foreach (BattleUnitModel battleUnitModel2 in this._unitList)
		{
			battleUnitModel2.SetTimeScale(1f);
			battleUnitModel2.OnFixedUpdate(deltaTime);
		}
	}

	public BattleUnitModel GetUnitWithIndex(Faction faction, int index)
	{
		return this._unitList.Find((BattleUnitModel x) => x.faction == faction && x.index == index);
	}

	public BattleUnitModel GetNearRandomTarget(BattleUnitModel actor)
	{
		float num = 99999f;
		BattleUnitModel battleUnitModel = null;
		foreach (BattleUnitModel battleUnitModel2 in this._unitList)
		{
			if (battleUnitModel2 != actor && battleUnitModel2.disposed && (battleUnitModel == null || (battleUnitModel2.view.WorldPosition - actor.view.WorldPosition).magnitude < num))
			{
				battleUnitModel = battleUnitModel2;
				num = (battleUnitModel2.view.WorldPosition - actor.view.WorldPosition).magnitude;
			}
		}
		return battleUnitModel;
	}

	public BattleUnitModel GetNearOppositeTarget(BattleUnitModel actor)
	{
		int num = int.MaxValue;
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			if (battleUnitModel.faction != actor.faction && !battleUnitModel.IsDead())
			{
				int cellDistance = SingletonBehavior<HexagonalMapManager>.Instance.GetCellDistance(actor.view.WorldPosition, battleUnitModel.view.WorldPosition);
				if (cellDistance < num)
				{
					num = cellDistance;
				}
			}
		}
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		foreach (BattleUnitModel battleUnitModel2 in this._unitList)
		{
			if (battleUnitModel2.faction != actor.faction && !battleUnitModel2.IsDead())
			{
				int cellDistance2 = SingletonBehavior<HexagonalMapManager>.Instance.GetCellDistance(actor.view.WorldPosition, battleUnitModel2.view.WorldPosition);
				if (num == cellDistance2)
				{
					list.Add(battleUnitModel2);
				}
			}
		}
		return list[UnityEngine.Random.Range(0, list.Count)];
	}

	public BattleUnitModel GetFarOppositeTarget(BattleUnitModel actor)
	{
		int num = int.MinValue;
		foreach (BattleUnitModel battleUnitModel in this._unitList)
		{
			if (battleUnitModel.faction != actor.faction && !battleUnitModel.IsDead())
			{
				int cellDistance = SingletonBehavior<HexagonalMapManager>.Instance.GetCellDistance(actor.view.WorldPosition, battleUnitModel.view.WorldPosition);
				if (cellDistance > num)
				{
					num = cellDistance;
				}
			}
		}
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		foreach (BattleUnitModel battleUnitModel2 in this._unitList)
		{
			if (battleUnitModel2.faction != actor.faction && !battleUnitModel2.IsDead())
			{
				int cellDistance2 = SingletonBehavior<HexagonalMapManager>.Instance.GetCellDistance(actor.view.WorldPosition, battleUnitModel2.view.WorldPosition);
				if (num == cellDistance2)
				{
					list.Add(battleUnitModel2);
				}
			}
		}
		return list[UnityEngine.Random.Range(0, list.Count)];
	}

	public BattleUnitModel GetTargetByCardForPlayer(BattleUnitModel actor, BattleDiceCardModel card, int idx, bool teamkill = false)
	{
		List<BattleUnitModel> aliveList = BattleObjectManager.instance.GetAliveList((actor.faction == Faction.Enemy) ? Faction.Player : Faction.Enemy);
		if (teamkill)
		{
			aliveList = BattleObjectManager.instance.GetAliveList(false);
		}
		if (aliveList.Contains(actor))
		{
			aliveList.Remove(actor);
		}
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		List<BattleUnitModel> fixedTargets = actor.GetFixedTargets();
		if (fixedTargets != null && fixedTargets.Count > 0)
		{
			foreach (BattleUnitModel battleUnitModel in fixedTargets)
			{
				if (battleUnitModel.IsTargetable(actor))
				{
					list.Add(battleUnitModel);
				}
			}
		}
		if (list.Count <= 0)
		{
			foreach (BattleUnitModel battleUnitModel2 in aliveList)
			{
				if (battleUnitModel2.IsTargetable(actor))
				{
					list.Add(battleUnitModel2);
				}
			}
		}
		BattleUnitModel battleUnitModel3 = null;
		if (list.Count > 0)
		{
			if (actor.faction == Faction.Enemy)
			{
				BattleUnitModel battleUnitModel4 = actor.ChangeAttackTarget(card, idx);
				if (battleUnitModel4 != null)
				{
					battleUnitModel3 = battleUnitModel4;
				}
			}
			else if (!actor.bufListDetail.IsControlable())
			{
				BattleUnitModel battleUnitModel5 = actor.ChangeAttackTarget(card, idx);
				if (battleUnitModel5 != null)
				{
					battleUnitModel3 = battleUnitModel5;
				}
			}
			if (battleUnitModel3 == null)
			{
				battleUnitModel3 = actor.targetSetter.SelectTargetUnit(list);
			}
		}
		return battleUnitModel3;
	}

	public BattleUnitModel GetTargetByCard(BattleUnitModel actor, BattleDiceCardModel card, int idx, bool teamkill = false)
	{
		List<BattleUnitModel> aliveList = BattleObjectManager.instance.GetAliveList((actor.faction == Faction.Enemy) ? Faction.Player : Faction.Enemy);
		if (teamkill)
		{
			aliveList = BattleObjectManager.instance.GetAliveList(false);
		}
		if (aliveList.Contains(actor))
		{
			aliveList.Remove(actor);
		}
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		List<BattleUnitModel> fixedTargets = actor.GetFixedTargets();
		if (fixedTargets != null && fixedTargets.Count > 0)
		{
			foreach (BattleUnitModel battleUnitModel in fixedTargets)
			{
				if (battleUnitModel.IsTargetable(actor))
				{
					list.Add(battleUnitModel);
				}
			}
		}
		if (list.Count <= 0)
		{
			foreach (BattleUnitModel battleUnitModel2 in aliveList)
			{
				if (battleUnitModel2.IsTargetable(actor))
				{
					list.Add(battleUnitModel2);
				}
			}
		}
		BattleUnitModel battleUnitModel3 = null;
		if (list.Count > 0)
		{
			if (actor.faction == Faction.Enemy)
			{
				BattleUnitModel battleUnitModel4 = actor.ChangeAttackTarget(card, idx);
				if (battleUnitModel4 != null)
				{
					battleUnitModel3 = battleUnitModel4;
				}
			}
			else if (!actor.bufListDetail.IsControlable())
			{
				BattleUnitModel battleUnitModel5 = actor.ChangeAttackTarget(card, idx);
				if (battleUnitModel5 != null)
				{
					battleUnitModel3 = battleUnitModel5;
				}
			}
			if (battleUnitModel3 == null)
			{
				battleUnitModel3 = actor.targetSetter.SelectTargetUnit(list);
			}
		}
		return battleUnitModel3;
	}

	public BattleUnitModel GetRandomTarget()
	{
		List<BattleUnitModel> aliveList = BattleObjectManager.instance.GetAliveList(false);
		return aliveList[UnityEngine.Random.Range(0, aliveList.Count)];
	}

	public BattleUnitModel GetRandomTarget(Faction faction)
	{
		List<BattleUnitModel> aliveList = BattleObjectManager.instance.GetAliveList(false);
		List<BattleUnitModel> list = new List<BattleUnitModel>();
		foreach (BattleUnitModel battleUnitModel in aliveList)
		{
			if (battleUnitModel.faction == faction)
			{
				list.Add(battleUnitModel);
			}
		}
		if (list.Count == 0)
		{
			return aliveList[UnityEngine.Random.Range(0, aliveList.Count)];
		}
		return list[UnityEngine.Random.Range(0, list.Count)];
	}

	public BattleUnitModel GetTargetByIndex(int index)
	{
		BattleUnitModel result;
		try
		{
			result = this._unitList[index];
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}
}
