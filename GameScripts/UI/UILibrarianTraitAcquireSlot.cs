using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UILibrarianTraitAcquireSlot : MonoBehaviour
	{
		public UILibrarianTraitAcquireSlot.LibrarianSlot[] librarianSlots;

		public Image FrameColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianTraitAcquireSlot()
		{
			throw null;
		}

		[Serializable]
		public class LibrarianSlot
		{
			public GameObject Pviot;

			public Image Portrait;

			public Image Frame;

			public TextMeshProUGUI LibrarianName;

			public TextMeshProUGUI AqcuiredText;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetLibrarian()
			{
				
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LibrarianSlot()
			{
				throw null;
			}
		}
	}
}
