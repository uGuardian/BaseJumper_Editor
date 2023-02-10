using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class DiceCardXmlInfo
	{
		[XmlAttribute("ID")]
		public int _id;

		[XmlIgnore]
		public bool isError;

		[XmlIgnore]
		public string workshopID;

		[XmlElement("Name")]
		public string workshopName;

		[XmlElement("TextId")]
		public int _textId;

		[XmlElement("Artwork")]
		public string Artwork;

		[XmlElement("Rarity")]
		public Rarity Rarity;

		[XmlElement("Option")]
		public List<CardOption> optionList;

		[XmlElement("Keyword")]
		public List<string> Keywords;

		[XmlElement("Spec")]
		public DiceCardSpec Spec;

		[XmlElement("Script")]
		public string Script;

		[XmlElement("ScriptDesc")]
		public string ScriptDesc;

		[XmlArray("BehaviourList")]
		[XmlArrayItem("Behaviour")]
		public List<DiceBehaviour> DiceBehaviourList;

		[XmlElement("Chapter")]
		public int Chapter;

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
		public int Priority;

		[XmlElement("PriorityScript")]
		public string PriorityScript;

		[XmlElement("Category")]
		public BookCategory category;

		[XmlElement("MaxCooltimeForEgo")]
		public int EgoMaxCooltimeValue;

		[XmlElement("MaxNum")]
		public int MaxNum;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlInfo(LorId id)
		{
			throw null;
		}

		[XmlIgnore]
		public LorId id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public LorId TextId
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetCardLimit(Rarity rarity)
		{
			throw null;
		}

		public int FloorLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetFloorLimit(Rarity rarity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsFloorEgo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPersonal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEgo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsOnlyPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsExhaustOnUse()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsAssimilation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool isLockInBattle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlInfo Copy(bool deepCopy = false)
		{
			throw null;
		}
	}
}
