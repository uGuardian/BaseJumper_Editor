using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Workshop
{
	public class WorkshopSkinData
	{
		public Dictionary<ActionDetail, ClothCustomizeData> dic;

		public string dataName;

		public string contentFolderIdx;

		public int id;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorkshopSkinData()
		{
			throw null;
		}
	}
}
