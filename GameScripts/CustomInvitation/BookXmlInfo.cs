using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BookXmlInfo : ItemXmlData
	{
		[XmlElement("Name")]
		public string innerName;

		[XmlElement("TextId")]
		public int textId;

		[XmlElement("BookIcon")]
		public string bookIcon;

		[XmlElement("Option")]
		public List<BookOption> optionList;

		[XmlElement("Category")]
		public List<BookCategory> categoryList;

		[XmlElement]
		public BookEquipEffect EquipEffect;

		[XmlElement("Rarity")]
		public Rarity Rarity;

		[XmlElement("CharacterSkin")]
		public string CharacterSkin;

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
		public List<BookSoundInfo> soundInfoList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookXmlInfo()
		{
			throw null;
		}
	}
}
