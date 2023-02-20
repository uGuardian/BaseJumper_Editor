using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShyLookTodayMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer bodyObject;

	[SerializeField]
	private Vector3[] pos;

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
	public void SetUpdateFace(bool b)
	{
		
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
	public ShyLookTodayMapManager()
	{
		throw null;
	}
}
