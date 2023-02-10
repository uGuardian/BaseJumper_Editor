using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class StageClassInfo
	{
		[XmlAttribute("id")]
		public int id;

		[XmlElement("Name")]
		public string stageName;

		[XmlElement("Wave")]
		public List<StageWaveInfo> waveList;

		[XmlElement("StageType")]
		public StageType stageType;

		[XmlElement("MapInfo")]
		public List<string> mapInfo;

		[XmlElement("FloorNum")]
		public int floorNum;

		[XmlElement("Chapter")]
		public int chapter;

		[XmlElement("Invitation")]
		public StageInvitationInfo invitationInfo;

		[XmlElement("Condition")]
		public StageExtraCondition extraCondition;

		[XmlElement("Story")]
		public List<StageStoryInfo> storyList;

		[XmlElement("IsChapterLast")]
		public bool isChapterLast;

		[XmlElement("StoryType")]
		public string storyType;

		[XmlElement("invitationtype")]
		public bool isStageFixedNormal;

		[XmlElement("FloorOnly")]
		public List<SephirahType> floorOnlyList;

		[XmlElement("ExceptFloor")]
		public List<SephirahType> exceptFloorList;

		[XmlElement("RewardItems")]
		public List<BookDropItemXmlInfo> _rewardList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageClassInfo()
		{
			throw null;
		}
	}
}
