using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BattleDialogRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("GroupName")]
		public string groupName;

		[XmlElement("Character")]
		public List<BattleDialogCharacter> characterList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogRoot()
		{
			throw null;
		}
	}
}
