using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PinocchioMapManager : CreatureMapManager
{
	[SerializeField]
	private GameObject _lyingParticlePrefab;

	[SerializeField]
	private SpriteRenderer _filterSprite1;

	[SerializeField]
	private SpriteRenderer _filterSprite2;

	[SerializeField]
	private SpriteRenderer _filterSprite3;

	private List<string> creatureDlgIdList;

	private CreatureDlgEffectUI dlgEffect;

	private GameObject _lyingParticle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ActiveMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilter(string flag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PinocchioMapManager()
	{
		throw null;
	}
}
