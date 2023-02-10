using System;
using System.Runtime.CompilerServices;

public class Singleton<T> where T : class, new()
{
	private static T _instance;

	public static T Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Singleton()
	{
		throw null;
	}
}
