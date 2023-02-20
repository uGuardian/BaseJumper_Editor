using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EnemyUnitClassInfoList : Singleton<EnemyUnitClassInfoList>
{
	private List<EnemyUnitClassInfo> _list;

	private Dictionary<string, List<EnemyUnitClassInfo>> _workshopEnemyDict;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<EnemyUnitClassInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyUnitClassInfo GetData(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEnemyUnitByMod(string workshopId, List<EnemyUnitClassInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, List<EnemyUnitClassInfo>> GetAllWorkshopData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyUnitClassInfo GetDataFromWorkshop(string workshopId, int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetHeight(EnemyUnitClassInfo e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyUnitClassInfoList()
	{
		throw null;
	}
}
