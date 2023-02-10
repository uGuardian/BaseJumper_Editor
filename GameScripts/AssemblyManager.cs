using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using LOR_XML;

public class AssemblyManager : Singleton<AssemblyManager>
{
	private Dictionary<string, List<Assembly>> _assemblyDict;

	private AssemblyManager.TypeDictionary<DiceCardSelfAbilityBase> _diceCardSelfAbilityDict;

	private AssemblyManager.TypeDictionary<DiceCardAbilityBase> _diceCardAbilityDict;

	private AssemblyManager.TypeDictionary<BehaviourActionBase> _behaviourActionDict;

	private AssemblyManager.TypeDictionary<PassiveAbilityBase> _passiveAbilityDict;

	private AssemblyManager.TypeDictionary<DiceCardPriorityBase> _diceCardPriorityDict;

	private AssemblyManager.TypeDictionary<EnemyUnitAggroSetter> _enemyUnitAggroSetterDict;

	private AssemblyManager.TypeDictionary<EnemyTeamStageManager> _enemyTeamStageManagerDict;

	private AssemblyManager.TypeDictionary<EnemyUnitTargetSetter> _enemyUnitTargetSetterDict;

	private List<ModInitializer> _initializer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallAllInitializer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadTypesFromAssembly(Assembly assembly)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadAllAssembly(string uid, string[] filenames, out Dictionary<string, BattleCardAbilityDesc> abilityText)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbilityBase CreateInstance_DiceCardSelfAbility(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbilityBase CreateInstance_DiceCardAbility(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourActionBase CreateInstance_BehaviourAction(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbilityBase CreateInstance_PassiveAbility(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardPriorityBase CreateInstance_DiceCardPriority(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyUnitAggroSetter CreateInstance_EnemyUnitAggroSetter(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager CreateInstance_EnemyTeamStageManager(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyUnitTargetSetter CreateInstance_EnemyUnitTargetSetter(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AssemblyManager()
	{
		throw null;
	}

	private class TypeDictionary<T> where T : class
	{
		private Dictionary<string, Type> _dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Add(string key, Type value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(string key, out Type value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T CreateInstance(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeDictionary()
		{
			throw null;
		}
	}
}
