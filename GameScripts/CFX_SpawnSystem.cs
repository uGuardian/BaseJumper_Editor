using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CFX_SpawnSystem : MonoBehaviour
{
	private static CFX_SpawnSystem instance;

	public GameObject[] objectsToPreload;

	public int[] objectsToPreloadTimes;

	public bool hideObjectsInHierarchy;

	public bool spawnAsChildren;

	public bool onlyGetInactiveObjects;

	public bool instantiateIfNeeded;

	private bool allObjectsLoaded;

	private Dictionary<int, List<GameObject>> instantiatedObjects;

	private Dictionary<int, int> poolCursors;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnloadObjects(GameObject sourceObj)
	{
		
	}

	public static bool AllObjectsLoaded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addObjectToPool(GameObject sourceObject, int number)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void removeObjectsFromPool(GameObject sourceObject)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void increasePoolCursor(int uniqueId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CFX_SpawnSystem()
	{
		throw null;
	}
}
