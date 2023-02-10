using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	[Serializable]
	public class ManualTitle
	{
		public GameObject ob;

		public List<ManualSubTitle> subtitles;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManualTitle()
		{
			throw null;
		}
	}
}
