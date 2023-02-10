using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BookEquipEffect
	{
		[XmlElement("HpReduction")]
		public int HpReduction;

		[XmlElement("HP")]
		public int Hp;

		[XmlElement("DeadLine")]
		public int DeadLine;

		[XmlElement]
		public int Break;

		[XmlElement("SpeedMin")]
		public int SpeedMin;

		[XmlElement("Speed")]
		public int SpeedMax;

		[XmlElement]
		public int SpeedDiceNum;

		[XmlElement]
		public AtkResist SResist;

		[XmlElement]
		public AtkResist PResist;

		[XmlElement]
		public AtkResist HResist;

		[XmlElement]
		public AtkResist SBResist;

		[XmlElement]
		public AtkResist PBResist;

		[XmlElement]
		public AtkResist HBResist;

		[XmlElement("MaxPlayPoint")]
		public int MaxPlayPoint;

		[XmlElement("StartPlayPoint")]
		public int StartPlayPoint;

		[XmlElement("AddedStartDraw")]
		public int AddedStartDraw;

		[XmlElement("OnlyCard")]
		public List<int> OnlyCard;

		[XmlElement("Card")]
		public List<BookSoulCardInfo> CardList;

		[XmlElement("Passive")]
		public List<BookPassiveXmlInfo> PassiveList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookEquipEffect()
		{
			throw null;
		}
	}
}
