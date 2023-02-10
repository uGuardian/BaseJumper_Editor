using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.BufEffect;
using Battle.CreatureEffect;
using Battle.DiceAttackEffect;
using LOR_DiceSystem;
using UnityEngine;

public class DiceEffectManager : SingletonBehavior<DiceEffectManager>
{
	[Header("Reference")]
	private string atkEffectResourcesPath;

	[SerializeField]
	private GameObject _sparkEffectPrefab;

	[SerializeField]
	private GameObject _defSuccessEffectPrefab;

	[SerializeField]
	private DiceDamagedEffect _effectDamagedByPenetrate;

	[SerializeField]
	private DiceDamagedEffect _effectDamagedBySlash;

	[SerializeField]
	private DiceDamagedEffect _effectDamagedByHit;

	public CharacterBloodSpriteEffect bloodSpriteObj;

	private Dictionary<string, DiceAttackEffect> atkEffectDic;

	private CreatureEffect_Spore _spore;

	private List<CreatureEffect> _creatureEffectList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected DiceEffectManager()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject CreateSparkByAtkVsAtk(Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDefSuccess(Vector3 pos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect CreateBehaviourEffect(string resource, float scaleFactor, BattleUnitView self, BattleUnitView target, float time = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDamagedEffectByBehaviour(BehaviourDetail atkType, float scaleFactor, BattleUnitView self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect CreateAbnormalityEffect(string resourcePath, float scaleFactor, BattleUnitView self, BattleUnitView target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureEffect CreateCreatureEffect(string resourcePath, float scaleFactor, BattleUnitView self, BattleUnitView target, float time = -1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureEffect CreateNewFXCreatureEffect(string resourcePath, float scaleFactor, BattleUnitView self, BattleUnitView target, float time = -1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BufEffect CreateBufEffect(string resourcePath, BattleUnitView self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect CreateAttackEffect(BattleUnitModel unit, float destroyTime = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDamagedBloodEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureEffect_Spore AddSporeEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveSporeEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureEffect_Spore GetSpore()
	{
		throw null;
	}
}
