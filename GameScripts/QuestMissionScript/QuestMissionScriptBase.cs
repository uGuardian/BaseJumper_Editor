using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class QuestMissionScriptBase
{
	protected QuestMissionModel _mission;

	private int _waveCount;

	private int _stageCount;

	public int WaveCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int StageCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected virtual int targetID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual int[] Param
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddWaveCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStageCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFinished()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMissionModel(QuestMissionModel mission)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsHide()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetWaveCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetStageCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseBook(int bookId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGetBook(int bookId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCustomize()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCustomizeSpeech(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEditFormation(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEditCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEquipBook(SephirahType sephirah, int unitIndex, BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSendInvitation(LorId stageId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnClearStage(StageModel stage)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinWave(StageLibraryFloorModel floor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEmotionLevelUp(BattleUnitModel unit, int level)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSelectEmotionCard(EmotionCardXmlInfo selected)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBreak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGetGift()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCoreEquip()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<int> GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadFromSaveData(List<int> data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetDesc(string id, int[] param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestMissionScriptBase()
	{
		throw null;
	}
}
