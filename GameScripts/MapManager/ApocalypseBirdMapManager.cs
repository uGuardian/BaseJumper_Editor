using System;
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BreakBuf(bool bigEyeBreaked, bool smallBeakBreaked, bool longArmBreaked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBufActivated(bool active)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBrokenSprite()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EggSpriteInfo()
		{
			throw null;
		}
	}
}
