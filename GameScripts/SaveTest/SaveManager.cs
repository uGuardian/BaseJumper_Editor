using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SaveTest
{
	public class SaveManager
	{
		private static SaveManager _instance;

		private List<Thread> _threadList;

		private Queue<Data> _processingQueue;

		public List<string> errorLogList;

		private object _lockObj;

		private Thread _threadWriteFile;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveManager()
		{
			throw null;
		}

		public static SaveManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool end
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Save()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Data Load()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCloseApplication()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Count()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteFile()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Data LoadFile()
		{
			throw null;
		}
	}
}
