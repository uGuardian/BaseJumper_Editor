using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EnemyUnitClassInfo
{
	[XmlAttribute("ID")]
	public int _id;

	[XmlIgnore]
	public string workshopID;

	[XmlElement("Name")]
	public string name;

	[XmlElement("FaceType")]
	public UnitFaceType faceType;

	[XmlElement("NameID")]
	public int nameId;

	[XmlElement("MinHeight")]
	public int minHeight;

	[XmlElement("MaxHeight")]
	public int maxHeight;

	[XmlElement("Unknown")]
	public bool isUnknown;

	[XmlElement("Gender")]
	public Gender gender;

	[XmlElement("Retreat")]
	public bool retreat;

	[XmlIgnore]
	public int height;

	[XmlElement("BookId")]
	public List<int> bookId;

	[XmlElement("BodyId")]
	public int bodyId;

	[XmlElement("Exp")]
	public int exp;

	[XmlElement("DropBonus")]
	public float dropBonus;

	[XmlElement("DropTable")]
	public List<EnemyDropItemTable> dropTableList;

	[XmlElement("Emotion")]
	public List<EmotionSetInfo> emotionCardList;

	[XmlElement("AiScript")]
	public string AiScript;

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
	public EnemyUnitClassInfo()
	{
		throw null;
	}
}
