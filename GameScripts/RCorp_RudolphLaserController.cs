using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RCorp_RudolphLaserController : MonoBehaviour
{
	[SerializeField]
	private FarAreaEffect_RCorp_Rudolph_AreaAtk _farAreaEffectRoot;

	[SerializeField]
	private RCorp_RudolphLaserRenderer _rendererInfo;

	[SerializeField]
	private RCorp_RudolphLaserAnimUV _textureUvInfo;

	private BattleUnitModel _actor;

	private List<BattleUnitModel> _targetList;

	public RCorp_RudolphLaserRenderer RendererInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitModel actor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ArrivedToTarget(int vertexIdx, int posCountInOneCurve)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RCorp_RudolphLaserController()
	{
		throw null;
	}
}
