using System;
using System.Runtime.CompilerServices;

namespace UI
{
	public class CustomizingSavedData
	{
		public string Name;

		public int NameID;

		public int PrefixID;

		public int PostfixID;

		public UnitCustomizingData LookData;

		public BattleDialogueModel ScriptData;

		public BookXmlInfo customBookInfo;

		public string WorkshopSkinData;

		public Gender appearanceType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomizingSavedData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Copy(CustomizingSavedData origin)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckSameAll(CustomizingSavedData param)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckSameName(CustomizingSavedData param)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckSameLook(CustomizingSavedData param)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckSameScript(CustomizingSavedData param)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckSameCloth(CustomizingSavedData param)
		{
			throw null;
		}
	}
}
