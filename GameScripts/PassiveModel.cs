using System;
using System.Runtime.CompilerServices;
using GameSave;

public class PassiveModel : Savable
{
	public const string save_currentpassiveid = "passivecurrentid";

	public const string save_originpassiveidid = "passiveprevid";

	public const string save_receivebookInstanceId = "receivebookinstanceid";

	public const string save_bookxmlid = "bookxmlid";

	public const string save_isAddedPassiveId = "addedpassiveid";

	public const string save_givebookInstanceId = "givebookinstanceid";

	public PassiveXmlInfo originpassive;

	public PassiveModel.PassiveModelSavedData originData;

	public PassiveModel.PassiveModelSavedData reservedData;

	private int _bookInstanceId;

	public int BookInstanceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool CanToGivePassive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsReceivedSuccessionPassive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveModel(LorId id, int bookinstanceid, int isaddedpassive = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveModel(int bookinstanceid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveXmlInfo DeepCopy(PassiveXmlInfo passive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitReservedData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsChangedReserved()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyReserved()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetReservedPassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SuccessionPassiveForReserved(PassiveModel passivemodel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGiveBookId(int instanceid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseSuccesionReceivePassive(bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseSuccesionGivePassive(bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGiveFromPassiveModel(PassiveModel targetpassive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data)
	{
		throw null;
	}

	public class PassiveModelSavedData
	{
		public PassiveXmlInfo currentpassive;

		public int receivepassivebookId;

		public int givePassiveBookId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveModelSavedData(PassiveXmlInfo currentpassive, int receivepassivebookId, int givePassiveBookId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveModelSavedData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeepCopy(PassiveModel.PassiveModelSavedData data)
		{
			throw null;
		}
	}
}
