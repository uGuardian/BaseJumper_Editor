﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mod
{
	public class ModContentManager : Singleton<ModContentManager>
	{
		public const string save_orders = "orders";

		public const string save_lastActivated = "lastActivated";

		private List<ModContent> _loadedContents;

		private List<ModContentInfo> _allMods;

		private List<string> _logs;

		private string _currentPid;

		private string savePath
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitModInfos()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<ModContentInfo> GetAllMods()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetModPath(string packageId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStoryStandingDirPath(string packageId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStoryStoryCgDirPath(string packageId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStoryStoryBgmDirPath(string packageId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveContents(List<ModContentInfo> targets)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddErrorLog(string msg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddWarningLog(string msg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddErrorLog(string msg, Exception e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddErrorLog(Exception e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> GetErrorLogs()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveSelectionData(List<ModContentInfo> allMods, List<ModContentInfo> activateds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadSelectionData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModContentManager()
		{
			throw null;
		}
	}
}
