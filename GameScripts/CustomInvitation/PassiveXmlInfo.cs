using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class PassiveXmlInfo : ItemXmlData
	{
		[XmlElement("Negative")]
		public bool isNegative;

		[XmlElement("IsHide")]
		public bool isHide;

		[XmlElement("Rarity")]
		public Rarity rarity;

		[XmlElement("Lock")]
		public bool isLock;

		[XmlElement("CanGivePassive")]
		public bool CanGivePassive;

		[XmlElement("CanReceivePassive")]
		public bool CanReceivePassive;

		[XmlElement("InnerType")]
		public int InnerTypeId;

		[XmlElement("Cost")]
		public int cost;

		[XmlElement("Script")]
		public string script;

		[XmlElement("Name")]
		public string name;

		[XmlElement("Desc")]
		public string desc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveXmlInfo()
		{
			throw null;
		}
	}
}
