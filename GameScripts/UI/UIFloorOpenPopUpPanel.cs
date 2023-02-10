using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIFloorOpenPopUpPanel : UIPopup
	{
		private static UIFloorOpenPopUpPanel instance;

		[Header("Reference")]
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private TextMeshProUGUI nextlevel;

		[SerializeField]
		private List<LevelUPAbilitySlot> addAbilitySlot;

		public UICustomSelectable selectable;

		[Header("SetColor Reference")]
		[SerializeField]
		private Image img_Blackbg;

		[SerializeField]
		private Image img_UpperFrame;

		[SerializeField]
		private Image img_MaskFrame;

		[SerializeField]
		private TextMeshProUGUI txt_TitleText;

		[SerializeField]
		private Image img_CenterEdgeFrame;

		[SerializeField]
		private TextMeshProUGUI txt_QuestAlarmText;

		[SerializeField]
		private TextMeshProUGUI txt_QuestAlarmTextBg;

		private LibraryFloorModel currentFloor;

		public int currentabcount;

		private int clickcounter;

		public int missioncount;

		public static UIFloorOpenPopUpPanel _instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(LibraryFloorModel floor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLevelupPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGlowColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayStartSound(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayRevealLevlSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayRevealRewardSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayMissionSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IsShowInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorOpenPopUpPanel()
		{
			throw null;
		}
	}
}
