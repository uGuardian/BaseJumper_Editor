using System;
using System.Runtime.CompilerServices;

namespace UI
{
	[Serializable]
	public class UICharacter
	{
		public UnitDataModel unitModel;

		public CharacterAppearance unitAppearance;

		public string resName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacter(UnitDataModel model, CharacterAppearance appearance)
		{
			throw null;
		}
	}
}
