using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class EnemyTeamStageManager_KeterFinal : EnemyTeamStageManager
{
	protected const int _PLAYER_ANGELA_ID = 9100501;

	private EnemyTeamStageManager_KeterFinal.AngelaEgoState _egoState;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetUsedEgoCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetAngelaUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitEgoState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStageClear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseAngelaEgoCard(LorId cardId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual List<int> GetPrevEgoList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SetAngelaEgos()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_KeterFinal()
	{
		throw null;
	}

	public class AngelaEgoState
	{
		private List<int> _usedList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetUsedCount()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(int id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Exists(int cardId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitFromList(List<int> list)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitFromCustomStorage(SaveData saveData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData GetSaveData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AngelaEgoState()
		{
			throw null;
		}
	}

	public class BattleDiceCardBuf_angelaEgoUsed : BattleDiceCardBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_angelaEgoUsed()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_angelaEgoUsed : BattleUnitBuf
	{
		public override KeywordBuf bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_angelaEgoUsed()
		{
			throw null;
		}
	}
}
