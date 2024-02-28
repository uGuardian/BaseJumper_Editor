using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class ApocalypseBirdObjectController : MonoBehaviour
{
	[SerializeField]
	private UIAnimationEventHandler _animEventHandler;

	private FarAreaEffect_EGO_ApcBird_PutDownAtk _areaAtkScript;

	[SerializeField]
	private List<Transform> _areaLaserPivotList;

	public List<Transform> areaLaserPivotList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return new List<Transform>(this._areaLaserPivotList);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayHandAtk(Direction handDirection, FarAreaEffect_EGO_ApcBird_PutDownAtk areaAtkScript)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disappear()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnAnimEvent_StartAtk()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnAnimEvent_Damage()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnAnimEvent_EndAtk()
	{

	}
}
