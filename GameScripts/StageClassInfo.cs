using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UI;

public class StageClassInfo
{
	[XmlAttribute("id")]
	public int _id;

	[XmlIgnore]
	public string workshopID;

	[XmlElement("Wave")]
	public List<StageWaveInfo> waveList;

	[XmlElement("StageType")]
	public StageType stageType;

	[XmlElement("MapInfo")]
	public List<string> mapInfo;

	[XmlElement("FloorNum")]
	public int floorNum;

	[XmlElement("Name")]
	public string stageName;

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
	public string _storyType;

	[XmlElement("invitationtype")]
	public bool isStageFixedNormal;

	[XmlElement("FloorOnly")]
	public List<SephirahType> floorOnlyList;

	[XmlElement("ExceptFloor")]
	public List<SephirahType> exceptFloorList;

	[XmlElement("RewardItems")]
	public List<BookDropItemXmlInfo> _rewardList;

	[XmlIgnore]
	public List<BookDropItemInfo> rewardList;

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
	public string storyType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public StoryState currentState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsNamedStage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageClassInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageStoryInfo GetStartStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageStoryInfo GetPrevBattleStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageStoryInfo GetEndStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNormalInvitation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitializeIds(string defaultPid)
	{
		
	}
}
