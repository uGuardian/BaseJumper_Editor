using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CardResourceManager : MonoBehaviour
{
	private static CardResourceManager _instance;

	private List<Sprite> _allArtworkSpriteList;

	private Dictionary<int, Sprite> _allArtworkDictionary;

	public static CardResourceManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetArtworkSpriteByCardID(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetArtworkSpriteByName(string artworkName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardResourceManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CardResourceManager()
	{
		throw null;
	}
}
