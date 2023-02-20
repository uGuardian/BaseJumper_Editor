using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmotionCardAbility_blackswan1 : EmotionCardAbilityBase
{
	private const int _bind = 1;

	private const int _vuln = 1;

	private const int _bleed = 1;

	private const int _paral = 1;

	private const int _maxCnt = 2;

	private int cnt;

	private bool _sound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWinParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_blackswan1()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_BlackSwan_Aura : BattleUnitBuf
	{
		private GameObject aura;

		public override bool Hide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDie()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyAura()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_BlackSwan_Aura()
		{
			throw null;
		}
	}
}
