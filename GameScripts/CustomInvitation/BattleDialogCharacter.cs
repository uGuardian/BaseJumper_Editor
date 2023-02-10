using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BattleDialogCharacter
	{
		[XmlAttribute("ID")]
		public int characterID;

		[XmlElement("Type")]
		public List<BattleDialogType> dialogTypeList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogCharacter()
		{
			throw null;
		}
	}
}
