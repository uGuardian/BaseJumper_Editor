using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WhiteNightObjectController : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private SpriteRenderer _bodyNormal;

	[SerializeField]
	private SpriteRenderer _bodyPain;

	private Dictionary<string, WhiteNightObjectController.EventMethod> events;

	public Animator animator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEvent(string key, WhiteNightObjectController.EventMethod method)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEvent(string key)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCalled(string key)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WhiteNightObjectController()
	{
		throw null;
	}

	public delegate void EventMethod();
}
