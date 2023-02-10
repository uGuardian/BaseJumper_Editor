using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WhiteNightApostleDeadFilter : MonoBehaviour
{
	public const string PREFAB_PATH = "Battle/CreatureEffect/FinalBattle/WhiteNight_DeadApostleImageFilter";

	private WhiteNightMapManager.DeadApostleFilterEndEvent _e;

	private List<BattleUnitModel> _deadList;

	[SerializeField]
	private AnimationCurve _hourHandCurve;

	[SerializeField]
	private Image _hourHand;

	[SerializeField]
	private Text _text;

	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _doneSound;

	private float _startAngle;

	private float _endAngle;

	private float _elapsed;

	private bool _bMoveHourHand;

	private BattleUnitModel _deadUnit;

	private bool _bAnimEnd;

	private float _elapsedEnd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(int start, int end, WhiteNightMapManager.DeadApostleFilterEndEvent e, BattleUnitModel deadUnit, List<BattleUnitModel> deadList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnim_HourHandEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WhiteNightApostleDeadFilter()
	{
		throw null;
	}
}
