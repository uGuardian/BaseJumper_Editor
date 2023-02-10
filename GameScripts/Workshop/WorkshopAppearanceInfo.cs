using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Workshop
{
	public class WorkshopAppearanceInfo
	{
		public Dictionary<FaceCustomType, Sprite> faceCustomInfo;

		public Dictionary<ActionDetail, ClothCustomizeData> clothCustomInfo;

		public bool isFaceCustom;

		public bool isClothCustom;

		public bool isStageCustom;

		public string path;

		public string uniqueId;

		public string bookName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorkshopAppearanceInfo()
		{
			throw null;
		}
	}
}
