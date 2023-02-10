using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class EnemyDropItemTable
	{
		[XmlAttribute("Level")]
		public int emotionLevel;

		[XmlElement("DropItem")]
		public EnemyDropItem dropItem;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyDropItemTable()
		{
			throw null;
		}
	}
}
