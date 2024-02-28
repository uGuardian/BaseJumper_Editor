using System;

public static class ArrayExt
{
	public static bool Contains<T>(this T[] haystack, T needle)
	{
		int num = haystack.Length;
		for (int i = 0; i < num; i++)
		{
			if (haystack[i] != null && haystack[i].Equals(needle))
			{
				return true;
			}
		}
		return false;
	}
}
