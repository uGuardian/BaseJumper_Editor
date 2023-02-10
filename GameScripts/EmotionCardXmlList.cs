using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EmotionCardXmlList : Singleton<EmotionCardXmlList>
{
	private List<EmotionCardXmlInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<EmotionCardXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardXmlInfo GetData(int id, SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardXmlInfo GetRandomPassive(SephirahType sephirah, bool neutralOnly)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCardXmlInfo> GetEnemyEmotionNeutralCardList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCardXmlInfo> GetEnemyEmotionCardList(List<int> ids)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCardXmlInfo> GetDataList(SephirahType sephirah, int level, MentalState state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCardXmlInfo> GetDataList(SephirahType sephirah, int floorLevel, int emotionLevel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCardXmlInfo> GetDataListByLevel(SephirahType sephirah, int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCardXmlInfo> GetDataList_enemy(SephirahType sephirah, int grade, MentalState state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCardXmlInfo> GetDataList_enemy(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsEmotionCardEnable(EmotionCardXmlInfo target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardXmlList()
	{
		throw null;
	}
}
