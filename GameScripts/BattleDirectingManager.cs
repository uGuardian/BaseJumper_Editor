using System;
using UnityEngine;

public class BattleDirectingManager : SingletonBehavior<BattleDirectingManager>
{
	public void Add(GameObject g)
	{
		g.transform.parent = base.transform;
	}

	public void Clear()
	{
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>(true);
		if (componentsInChildren != null)
		{
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				UnityEngine.Object.Destroy(componentsInChildren[i].gameObject);
			}
		}
	}
}
