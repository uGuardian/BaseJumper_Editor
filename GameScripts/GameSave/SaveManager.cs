using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameSave
{
	public class SaveManager : Singleton<SaveManager>
	{
		public List<SaveErrorLog> errorLog;

		private Dictionary<string, int> _packageIdTable;

		private int _packageIdIndex;

		private Dictionary<int, string> _packageIdTableReverse;

		public int iver;

		public string ver;

		private bool _saveEnable;

		public static string savePath
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSaveFilename(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSaveFilenameVersionUp(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTmpSaveFilename(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetErrorSaveFilename(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetWorkshopInvitationFileName(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetFullPath(string filename)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSaveFileFullPath(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSaveFileFullPathV2(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTemporarySaveFileFullPath(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetWorkshopInvitationSaveFilePath(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetErrorSaveFileFullPath(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetOptionFileFullPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetOptionFileName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetLatestFileFullPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetLatestFileName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSaveEnable(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ConvertPackageIdToInt(string packageId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ConvertIntToPackageId(int pidIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SavePlayData(int slot, bool force = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadPlayDataFromSaveFile(int slot, Action<bool> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckExistSaveData(int slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveOptionData(OptionDataModel option)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool LoadOptionData(OptionDataModel option)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveLatestData(LatestDataModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool LoadLatestData(LatestDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SaveData(string path, SaveData savedata)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData LoadData(string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddErrorLog(SaveErrorType type, LorId id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveManager()
		{
			throw null;
		}
	}
}
