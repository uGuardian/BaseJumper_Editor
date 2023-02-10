using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using CustomInvitation;
using UnityEngine;

public class BookXmlInfo
{
	[XmlAttribute("ID")]
	public int _id;

	[XmlIgnore]
	public bool isError;

	[XmlIgnore]
	public string workshopID;

	[XmlElement("Name")]
	public string InnerName;

	[XmlElement("TextId")]
	public int TextId;

	[XmlElement("BookIcon")]
	public string _bookIcon;

	[XmlElement("Option")]
	public List<BookOption> optionList;

	[XmlElement("Category")]
	public List<BookCategory> categoryList;

	[XmlElement]
	public BookEquipEffect EquipEffect;

	[XmlElement("Rarity")]
	public Rarity Rarity;

	[XmlElement("CharacterSkin")]
	public List<string> CharacterSkin;

	[XmlElement("CharacterSkinType")]
	public string skinType;

	[XmlElement("SkinGender")]
	public Gender gender;

	[XmlElement("Chapter")]
	public int Chapter;

	[XmlElement("Episode")]
	public int episode;

	[XmlElement("RangeType")]
	public EquipRangeType RangeType;

	[XmlElement("NotEquip")]
	public bool canNotEquip;

	[XmlElement("RandomFace")]
	public bool RandomFace;

	[XmlElement("SpeedDiceNum")]
	public int speedDiceNumber;

	[XmlElement("SuccessionPossibleNumber")]
	public int SuccessionPossibleNumber;

	[XmlElement("SoundInfo")]
	public List<BookSoundInfo> motionSoundList;

	[XmlIgnore]
	public int remainRewardValue;

	[XmlIgnore]
	public LorId id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string BookIcon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public int Limit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public LorId DeckId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public List<string> Desc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetThumbSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCharacterSkin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookXmlInfo Copy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookXmlInfo()
	{
		throw null;
	}
}
