using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActionCharacter : MonoBehaviour
{
	public Transform spriteRoot;

	public Transform effectRoot;

	public bool isActionEnd;

	public bool isReadyAction;

	[SerializeField]
	private CharacterAppearance _cloneAppearance;

	public Direction direction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(CharacterAppearance cloneAppearance)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeAction(ResultData r)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ReadyAction()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoAction(ResultData r, Vector3 dstPos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator AfterAction(ResultData r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ActionCharacter()
	{
		throw null;
	}
}
