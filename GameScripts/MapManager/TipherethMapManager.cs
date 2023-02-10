using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TipherethMapManager : MapManager
{
	[SerializeField]
	private AnimationCurve _fadeCurve;

	[SerializeField]
	private Color _nightSephirahColor;

	[SerializeField]
	private List<SpriteRenderer> _dayTimeRendererList;

	[SerializeField]
	private List<GameObject> _createdScratches;

	[SerializeField]
	private float _frequency;

	[SerializeField]
	private bool _bUpdateDay;

	[SerializeField]
	private float _elapsedDay;

	[SerializeField]
	private TipherethMapManager.State _state;

	[SerializeField]
	private Transform borderObjRoot;

	[SerializeField]
	private SpriteRenderer[] borderSprites;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GameObject GetScratch(int lv, Transform parent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TipherethMapManager()
	{
		throw null;
	}

	public enum State
	{
		ToDaytime,
		ToNight
	}

	public class ScratchInfo
	{
		public GameObject daytimeScratch;

		public GameObject nightScratch;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ScratchInfo()
		{
			throw null;
		}
	}
}
