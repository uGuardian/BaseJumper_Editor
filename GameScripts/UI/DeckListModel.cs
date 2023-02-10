using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

namespace UI
{
	public class DeckListModel : Singleton<DeckListModel>, Savable
	{
		public const int LISTLENGTH = 20;

		public const string save_slotlist = "deckList";

		private List<DeckSlotModel> DeckSlots;

		public List<DeckSlotModel> DeckListData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDeckListData(List<DeckSlotModel> _deckSlots)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData GetSaveData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadFromSaveData(SaveData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeckListModel()
		{
			throw null;
		}
	}
}
