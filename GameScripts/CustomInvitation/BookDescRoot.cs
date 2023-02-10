using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CustomInvitation
{
	public class BookDescRoot
	{
		public List<BookDesc> bookDescList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookDescRoot()
		{
			throw null;
		}
	}
}
