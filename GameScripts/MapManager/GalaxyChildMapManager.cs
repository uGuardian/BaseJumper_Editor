using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class GalaxyChildMapManager : MapManager
{
	[SerializeField]
	private GalaxyChildMap_StarfallObj starfallobj;

	[SerializeField]
	private Sprite[] sprites;

	[SerializeField]
	private Sprite[] filterSprite;

	[SerializeField]
	private GalaxyChildMap_StarfallObj2[] _stars;

	private Vector3[] _starsPos;

	[SerializeField]
	private SpriteRenderer _filterRenderer;

	private List<string> creatureDlgIdList;

	[SerializeField]
	private SpriteRenderer galaxyBoySpriteRenderer;

	private int dlgIdx;

	private CreatureDlgEffectUI dlgEffect;

	private bool _bCrying;

	private float _elapsedStarfallCreation;

	private float _cooldownStarfallCreation;

	private bool _bStarfall;

	private SoundEffectPlayer _loopSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Cry(bool cry)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GalaxyChildMapManager()
	{
		throw null;
	}
}
