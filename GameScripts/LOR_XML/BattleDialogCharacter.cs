using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BattleDialogCharacter
	{
		[XmlAttribute("ID")]
		public string characterID;

		[XmlElement("Type")]
		public List<BattleDialogType> dialogTypeList;

		[XmlIgnore]
		public string workshopId;

		[XmlIgnore]
		public int bookId;

		[XmlIgnore]
		public LorId id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogCharacter()
		{
			throw null;
		}
	}
}
