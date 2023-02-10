using System;

namespace GameSave
{
	public interface Savable
	{
		SaveData GetSaveData();

		void LoadFromSaveData(SaveData data);
	}
}
