using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BattleDialogRelationWithBookID
	{
		[XmlAttribute("BookID")]
		public int bookID;

		[XmlAttribute("StoryID")]
		public int storyID;

		[XmlElement("GroupName")]
		public string groupName;

		[XmlElement("CharacterID")]
		public string characterID;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogRelationWithBookID()
		{
			throw null;
		}
	}
}
