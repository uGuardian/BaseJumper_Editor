using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	[Serializable]
	public class ManualSubTitle
	{
		public GameObject ob;

		public List<UIManualScreenPage> ContentList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManualSubTitle()
		{
			throw null;
		}
	}
}
