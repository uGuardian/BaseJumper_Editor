using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Workshop;

public class CustomizingCardArtworkLoader : Singleton<CustomizingCardArtworkLoader>
{
	private Dictionary<string, List<ArtworkCustomizeData>> _artworkData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddArtworkData(string workshopItemID, List<ArtworkCustomizeData> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ArtworkCustomizeData> GetWorkshopArtworkData(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArtworkCustomizeData GetSpecificArtworkData(string id, string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetSpecificArtworkSprite(string id, string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizingCardArtworkLoader()
	{
		throw null;
	}
}
