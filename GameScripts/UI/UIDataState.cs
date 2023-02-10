using System;
using System.Runtime.CompilerServices;

namespace UI
{
	public class UIDataState
	{
		public SephirahType sephirah;

		public UnitDataModel unit;

		public StageClassInfo stage;

		public UnitEquipPart equipPart;

		public ItemModel item;

		public BookModel book;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDataState()
		{
			throw null;
		}
	}
}
