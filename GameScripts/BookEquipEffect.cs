using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

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

	[XmlElement]
	public int Speed;

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

	public int MaxPlayPoint;

	[XmlElement("StartPlayPoint")]
	public int StartPlayPoint;

	[XmlElement("AddedStartDraw")]
	public int AddedStartDraw;

	[XmlIgnore]
	public int PassiveCost;

	[XmlElement("OnlyCard")]
	public List<int> OnlyCard;

	[XmlElement("Card")]
	public List<BookSoulCardInfo> CardList;

	[XmlElement("Passive")]
	public List<LorIdXml> _PassiveList;

	[XmlIgnore]
	public List<LorId> PassiveList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookEquipEffect()
	{
		throw null;
	}
}
