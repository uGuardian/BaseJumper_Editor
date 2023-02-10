using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class PassiveXmlInfo
{
	[XmlAttribute("ID")]
	public int _id;

	[XmlIgnore]
	public bool isError;

	[XmlIgnore]
	public string workshopID;

	[XmlElement("Level")]
	public int level;

	[XmlElement("Negative")]
	public bool isNegative;

	[XmlElement("IsHide")]
	public bool isHide;

	[XmlElement("Param")]
	public List<int> param;

	[XmlElement("Rarity")]
	public Rarity rare;

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
	public bool CheckCanSuccession()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveXmlInfo()
	{
		throw null;
	}
}
