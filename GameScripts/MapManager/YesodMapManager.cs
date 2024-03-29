﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class YesodMapManager : MapManager
{
	[SerializeField]
	private Transform _upperBorder;

	[Header("Value Setting")]
	[SerializeField]
	private float _gearSpeedRatio;

	[SerializeField]
	private List<MapBgObjRotator> _gearList;

	[SerializeField]
	private List<SpriteRenderer> _spriteBuildingList;

	[SerializeField]
	private List<YesodMapManager.YesodSpriteBG> _spriteList;

	[SerializeField]
	private ParticleSystem[] _gearParticles;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private Transform _bgRootTransform;

	[SerializeField]
	private GameObject _groundParticle;

	private float _elapsed;

	private bool _isDefault;

	private Vector3 _upperBorderOriginScale;

	private Vector3 _upperBorderOriginPos;

	private Vector3 _bgRootOriginScale;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartUnitMoving()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator UpperBorderScaleRoutine(Vector3 pos, Vector3 scale)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDownAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndDownAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartUpAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndUpAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActiveSpark()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActiveDusts()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EarthQuake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public YesodMapManager()
	{
		throw null;
	}

	[Serializable]
	internal class YesodSpriteBG
	{
		[SerializeField]
		internal Vector3 originPos;

		[SerializeField]
		internal Vector3 targetPos;

		[SerializeField]
		internal Transform transform;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public YesodSpriteBG()
		{
			throw null;
		}
	}
}
