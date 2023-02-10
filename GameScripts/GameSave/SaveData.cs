using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameSave
{
	public class SaveData
	{
		private List<SaveData> _list;

		private Dictionary<string, SaveData> _dic;

		private ulong _pdul;

		private int _pdi;

		private string _pds;

		private SaveDataType _type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveDataType GetDataType()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData(SaveDataType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData(List<int> listI)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData(ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData(string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddData(string key, SaveData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToList(SaveData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData GetData(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetInt(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetString(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<SaveData> GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetListCount()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetIntSelf()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ulong GetUnsignedLongSelf()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStringSelf()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, SaveData> GetDictionarySelf()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetSerializedData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadFromSerializedData(object serialized)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveData Copy()
		{
			throw null;
		}
	}
}
