using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	[SerializeField]
	private List<TKey> keys;

	[SerializeField]
	private List<TValue> values;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBeforeSerialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAfterDeserialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SerializableDictionary()
	{
		throw null;
	}
}
