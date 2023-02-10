using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class StageModel
{
	private StageClassInfo _classInfo;

	private List<StageWaveModel> _waveList;

	private List<StageLibraryFloorModel> _floorList;

	private List<SephirahType> _usedFloorList;

	private Dictionary<string, object> _stageDataStorage;

	private int _burnKillCount;

	private int _matanKillCount;

	private int _heartKillCount;

	public bool danggoUsed;

	public bool enemyTeamLevel5;

	public bool playerTeamLevel5;

	public bool enterBinah;

	private string _currentMapInfo;

	public StageClassInfo ClassInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int WaveCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<StageLibraryFloorModel> floorList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<StageWaveModel> waveList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<SephirahType> usedFloorList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(StageClassInfo classInfo, LibraryModel library, bool isRebattle = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartWaveBattle(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetCurrentMapInfo(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCurrentMapInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageWaveModel GetWave(int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageWaveModel GetFrontAvailableWave()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageLibraryFloorModel GetFloor(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageLibraryFloorModel GetFrontAvailableFloor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<StageLibraryFloorModel> GetAvailableFloorList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<SephirahType> GetUsedFloorList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAvailableFloorNumber()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyLibrarianGiftGain()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBurnKillCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddMatanKillCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddHeartKillCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinStage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAchievements()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUsedSephirah(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStageStorgeData(string name, object value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetStageStorageData<T>(string name, out T output)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageModel()
	{
		throw null;
	}
}
