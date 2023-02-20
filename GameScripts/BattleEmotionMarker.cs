using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BattleEmotionMarker : MonoBehaviour
{
	public AnimationCurve curve;

	public Image imgLibrarianIcon;

	public Image imgEnemyIcon;

	public bool isAlly;

	public int curEmotionLevel;

	private bool isPositive;

	private List<Vector3> standards;

	private BattleTeamModel teamModel;

	private Vector3 _curPos;

	private Vector3 _dstPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SetAlphaIntensity(Image frameImg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleTeamModel team, bool ally, List<Vector3> posList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionMarker()
	{
		throw null;
	}
}
