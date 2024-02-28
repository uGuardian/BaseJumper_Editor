using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class AttackEffectInfoManager : Singleton<AttackEffectInfoManager>
{
	public const string atkEffectResourcesPath = "Prefabs/Battle/DiceAttackEffects/New/";

	private Dictionary<string, string> _attackEffectPathTable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<AttackEffectPathXmlInfo> charResourceInfo)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<string, string> charResourceInfo)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadResourceInfo()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AttackEffectPathInfoRoot LoadNewResourceInfo(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPath(string name)
	{
		throw null;
	}
}
