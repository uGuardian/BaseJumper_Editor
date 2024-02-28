using System;
using UnityEngine;

public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static bool _isQuit;

	public static T Instance
	{
		get
		{
			if (SingletonBehavior<T>._instance == null)
			{
				SingletonBehavior<T>._instance = (UnityEngine.Object.FindObjectOfType(typeof(T)) as T);
			}
			return SingletonBehavior<T>._instance;
		}
	}

	protected virtual void OnApplicationQuit()
	{
		SingletonBehavior<T>._isQuit = true;
		base.StopAllCoroutines();
	}
}
