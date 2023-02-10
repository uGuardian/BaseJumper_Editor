using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class EnemyUnitClassInfo
	{
		[XmlAttribute("ID")]
		public int id;

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
		public int bookId;

		[XmlElement("BodyId")]
		public int bodyId;

		[XmlElement("Exp")]
		public int exp;

		[XmlElement("DropBonus")]
		public float dropBonus;

		[XmlElement("DropTable")]
		public EnemyDropItemTable dropTable;

		[XmlElement("Emotion")]
		public List<EmotionSetInfo> emotionCardList;

		[XmlElement("AiScript")]
		public string AiScript;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyUnitClassInfo()
		{
			throw null;
		}
	}
}
