﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ApocalypseBirdMapManager : CreatureMapManager
{
	[SerializeField]
	private ApocalypseBirdObjectController _birdController;

	[SerializeField]
	private ApocalypseBirdMapManager.EggSpriteInfo _bigBirdEggInfo;

	[SerializeField]
	private ApocalypseBirdMapManager.EggSpriteInfo _punishmentBirdEggInfo;

	[SerializeField]
	private ApocalypseBirdMapManager.EggSpriteInfo _judgementBirdEggInfo;

	public ApocalypseBirdObjectController birdController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBufState(bool bigEyeOn, bool smallBeakOn, bool longArmOn)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BreakBuf(bool bigEyeBreaked, bool smallBeakBreaked, bool longArmBreaked)
	{
		
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
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApocalypseBirdMapManager()
	{
		throw null;
	}

	[Serializable]
	public class EggSpriteInfo
	{
		public SpriteRenderer normal;

		public SpriteRenderer breaked;

		public GameObject particle;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBufActivated(bool active)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBrokenSprite()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EggSpriteInfo()
		{
			throw null;
		}
	}
}
