using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIFloorQuestPanel : MonoBehaviour
	{
		[Header("Quest Slot")]
		[SerializeField]
		private GameObject questSlotsRoot;

		[SerializeField]
		private UIFloorQuestSlot[] questSlotList;

		private QuestModel currentQuest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(LibraryFloorModel floor)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorQuestPanel()
		{
			throw null;
		}
	}
}
