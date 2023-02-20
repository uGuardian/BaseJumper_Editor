using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShyLookTodayFinalMapManager : CreatureMapManager
{
	[SerializeField]
	private AudioClip _smileFaceParticleSound;

	[SerializeField]
	private AudioClip _noSmileFaceParticleSound;

	[SerializeField]
	private List<SpriteRenderer> faceObjectList;

	[SerializeField]
	private List<GameObject> faceParticles;

	[SerializeField]
	private List<Sprite> _faceFilterSprites;

	[SerializeField]
	private SpriteRenderer _particleRoot;

	[SerializeField]
	private SpriteRenderer _filter;

	private int _flag;

	private bool _bUpdateFace;

	private float _elapsedUpdateFace;

	private int _faceIdx;

	public int Face
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFaceParticle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUpdateFace(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCardFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentFace(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShyLookTodayFinalMapManager()
	{
		throw null;
	}
}
