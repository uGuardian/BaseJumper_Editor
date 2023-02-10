using System;
using System.IO;
using System.Runtime.CompilerServices;
using Workshop;

namespace Mod
{
	public class ModContentInfo
	{
		public readonly ModSourceType modType;

		public readonly NormalInvitation invInfo;

		public readonly DirectoryInfo dirInfo;

		public readonly Version modVer;

		public bool activated;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Version ConvertModVer(string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModContentInfo(ModSourceType modType, NormalInvitation invInfo, DirectoryInfo dirInfo)
		{
			throw null;
		}
	}
}
