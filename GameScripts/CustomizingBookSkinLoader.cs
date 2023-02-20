using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Workshop;

public class CustomizingBookSkinLoader : Singleton<CustomizingBookSkinLoader>
{
	private Dictionary<string, List<WorkshopSkinData>> _bookSkinData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBookSkinData(string workshopItemID, List<WorkshopSkinData> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<WorkshopSkinData> GetWorkshopBookSkinData(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WorkshopSkinData GetWorkshopBookSkinData(string id, string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizingBookSkinLoader()
	{
		throw null;
	}
}
