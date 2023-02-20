using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_KingOfGreed_Reason_Special : FarAreaEffect
{
	private const string _PORTAL_PREFAB_PATH = "Battle/CreatureEffect/5/KingOfGreed_Portal";

	[SerializeField]
	private float _startPortalOffsetX;

	[SerializeField]
	private float _additionalDst;

	[SerializeField]
	private float _endDelay;

	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private float _moveSlowSpeed;

	[SerializeField]
	private float _knockbackSpeed;

	[SerializeField]
	private float _atkDelay;

	private GameObject _startPortal;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private float _elapsedStart;

	private float _elapsedGiveDamage;

	private float _elapsedEndAction;

	private Vector3 _srcPosAtkOneTarget;

	private Vector3 _dstPosAtkOneTarget;

	private BattleFarAreaPlayManager.VictimInfo _currentVictim;

	private int _knockbackEnergy;

	private KingOfGreedMapManager _map;

	private List<GameObject> _createdPortals;

	private CameraFilterPack_Blur_Radial filterRef;

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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ActionPhase(float deltaTime, BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetRadialFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RadialRoutine(CameraFilterPack_Blur_Radial filter)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyEffects()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_KingOfGreed_Reason_Special()
	{
		throw null;
	}
}
