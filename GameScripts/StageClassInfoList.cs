using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class StageClassInfoList : Singleton<StageClassInfoList>
{
	private List<StageClassInfo> _list;

	private List<StageClassInfo> _recipeCondList;

	private Dictionary<int, List<StageClassInfo>> _valueCondList;

	private Dictionary<string, List<StageClassInfo>> _workshopStageDict;

	private List<StageClassInfo> _workshopRecipeList;

	private Dictionary<int, List<StageClassInfo>> _workshopValueDict;

	public List<StageClassInfo> recipeCondList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<StageClassInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageClassInfo GetData(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageClassInfo GetData(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<StageClassInfo> GetDataListByChapter(int chapter)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<StageClassInfo> GetAllDataList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageClassInfo GetDataFromBooks(List<DropBookXmlInfo> books)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<StageClassInfo> GetWorkshopDataFromBooks(List<DropBookXmlInfo> books)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClassifyInvitationType(List<StageClassInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStageByMod(string workshopId, List<StageClassInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, List<StageClassInfo>> GetAllWorkshopData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClassifyWorkshopInvitation(List<StageClassInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSubscribeWorkshopInv()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageClassInfoList()
	{
		throw null;
	}
}
