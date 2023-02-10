using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LOR_DiceSystem;

namespace CustomInvitation
{
	public class DiceCardXmlInfo : ItemXmlData
	{
		[XmlIgnore]
		public string pid;

		[XmlElement("Name")]
		public string name;

		[XmlElement("TextId")]
		public int _textId;

		[XmlElement("Artwork")]
		public string artwork;

		[XmlElement("Rarity")]
		public Rarity rarity;

		[XmlElement("Option")]
		public List<CardOption> cardOptionList;

		[XmlElement("Keyword")]
		public List<string> keywordList;

		[XmlElement("Spec")]
		public DiceCardSpec spec;

		[XmlElement("Script")]
		public string script;

		[XmlElement("ScriptDesc")]
		public string ScriptDesc;

		[XmlArray("BehaviourList")]
		[XmlArrayItem("Behaviour")]
		public List<DiceBehaviour> diceBehaviourList;

		[XmlElement("Chapter")]
		public int chapter;

		[XmlElement("SpecialEffect")]
		public string SpecialEffect;

		[XmlElement("SkinChange")]
		public string SkinChange;

		[XmlElement("SkinChangeType")]
		public CardSkinType SkinChangeType;

		[XmlElement("SkinHeight")]
		public int SkinHeight;

		[XmlElement("MapChange")]
		public string MapChange;

		[XmlElement("Priority")]
		public int priority;

		[XmlElement("PriorityScript")]
		public string PriorityScript;

		[XmlElement("Category")]
		public BookCategory category;

		[XmlElement("MaxCooltimeForEgo")]
		public int EgoMaxCooltimeValue;

		[XmlElement("MaxNum")]
		public int MaxNum;

		[XmlIgnore]
		public CustomId customId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlInfo()
		{
			throw null;
		}
	}
}
