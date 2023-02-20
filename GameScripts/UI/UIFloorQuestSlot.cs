using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIFloorQuestSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Image img_BgFrame;

		[SerializeField]
		private Image img_lineframe;

		[SerializeField]
		private Image img_Icon;

		[SerializeField]
		private TextMeshProUGUI txt_QuestName;

		[SerializeField]
		private TextMeshProUGUI txt_QuestProgress;

		private QuestMissionModel currentMission;

		private const float maxbgwidht = 370f;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(QuestMissionModel mission)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetExpQuestData(LibraryFloorModel floor)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorQuestSlot()
		{
			throw null;
		}
	}
}
