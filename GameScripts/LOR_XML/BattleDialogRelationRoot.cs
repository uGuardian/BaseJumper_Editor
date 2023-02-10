using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BattleDialogRelationRoot
	{
		[XmlElement("Relation")]
		public List<BattleDialogRelationWithBookID> list;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogRelationRoot()
		{
			throw null;
		}
	}
}
