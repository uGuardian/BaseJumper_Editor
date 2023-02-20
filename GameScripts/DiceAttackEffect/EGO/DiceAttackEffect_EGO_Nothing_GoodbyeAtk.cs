using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DiceAttackEffect_EGO_Nothing_GoodbyeAtk : MonoBehaviour
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _bloodSound;

	[SerializeField]
	private AudioClip _atkSound;

	[SerializeField]
	private GameObject _silhouettePrefab;

	[SerializeField]
	private GameObject _bloodPrefab;

	[SerializeField]
	private SpriteRenderer _bg;

	[SerializeField]
	private AnimationCurve _bgAlphaCurve;

	[SerializeField]
	private float _speed;

	private List<GameObject> _silhouetteObjList;

	private List<GameObject> _bloodObjList;

	private BattleUnitModel _actor;

	private BattleUnitModel _target;

	private bool _bPrintBlood;

	private bool _bChangeMotion;

	private float _elapsedAtk;

	private float _elapsedDestroy;

	private float _elapsedBlood;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitModel actor, BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_EGO_Nothing_GoodbyeAtk()
	{
		throw null;
	}
}
