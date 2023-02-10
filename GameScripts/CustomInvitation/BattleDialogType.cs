using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BattleDialogType
	{
		[XmlAttribute("ID")]
		public DialogType dialogType;

		[XmlElement("BattleDialog")]
		public List<BattleDialog> dialogList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogType()
		{
			throw null;
		}
	}
}
