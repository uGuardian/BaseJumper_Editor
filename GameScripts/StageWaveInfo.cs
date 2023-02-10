using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class StageWaveInfo
{
	[XmlElement("Unit")]
	public List<LorIdXml> _enemyUnitIdList;

	[XmlIgnore]
	public List<LorId> enemyUnitIdList;

	[XmlElement("Formation")]
	public int formationId;

	[XmlElement("FormationType")]
	public EnemyFormationType formationType;

	[XmlElement("AvailableUnit")]
	public int availableNumber;

	public List<int> emotionCardList;

	[XmlElement("AggroScript")]
	public string aggroScript;

	[XmlElement("ManagerScript")]
	public string managerScript;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageWaveInfo()
	{
		throw null;
	}
}
