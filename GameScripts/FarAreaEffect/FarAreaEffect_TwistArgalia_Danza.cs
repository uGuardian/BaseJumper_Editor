using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_TwistArgalia_Danza : FarAreaEffect
{
	public static List<BattleUnitModel> firstDamagedUnits;

	public static GameObject bgEffect;

	public static List<TwistedArgalia_DanzaLine> lineEffectList;

	public static List<GameObject> starMarkEffectList;

	public static string defaultCharacterLayerName;

	public static string defaultCharacterUILayerName;

	[SerializeField]
	private GameObject _starMarkEffectRes;

	[SerializeField]
	private TwistedArgalia_DanzaLine _lineEffectRes;

	[SerializeField]
	private GameObject _backgroundEffectRes;

	[SerializeField]
	private float _activateBgEffectDelay;

	[SerializeField]
	private float _moveDelay;

	[SerializeField]
	private float _endDelay;

	[SerializeField]
	private GameObject _trailObject;

	[SerializeField]
	private GameObject _damagedEffectRes;

	[SerializeField]
	private AudioClip _damagedSound;

	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _endFgSound;

	[SerializeField]
	private GameObject _foregroundEffect;

	[SerializeField]
	private UIAnimationEventHandler _foregroundHandler;

	private float _elapsed;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private Vector3 _startPos;

	private Vector3 _srcPosAtkOneTarget;

	private Vector3 _dstPosAtkOneTarget;

	private int _sign;

	private bool _bDoneForeground;

	public override bool HasIndependentAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ActionPhase(float deltaTime, BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveDamage(BattleUnitModel attacker, BattleFarAreaPlayManager.VictimInfo v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDamagedEffect(BattleUnitView view)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitStarMarkEffect(BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnChangeLayer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_TwistArgalia_Danza()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FarAreaEffect_TwistArgalia_Danza()
	{
		throw null;
	}
}
