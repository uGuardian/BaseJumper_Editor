using System;
using System.Runtime.CompilerServices;
using GameSave;

namespace UI
{
	public class DeckSlotModel : Singleton<DeckSlotModel>, Savable
	{
		public const string save_name = "name";

		public const string save_deck = "deck";

		public string Name;

		public DeckModel Deck;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData GetSaveData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadFromSaveData(SaveData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeckSlotModel()
		{
			throw null;
		}
	}
}
