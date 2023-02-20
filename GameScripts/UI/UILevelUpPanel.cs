using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UILevelUpPanel : UIPopup
	{
		private static UILevelUpPanel instance;

		[Header("Reference")]
		public UICustomSelectablePanel selectablePanel;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private TextMeshProUGUI prevlevel;

		[SerializeField]
		private TextMeshProUGUI nextlevel;

		[SerializeField]
		private List<LevelUPAbilitySlot> addAbilitySlot;

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

		[SerializeField]
		private Image img_blackbgForKeterMax;

		private LibraryFloorModel currentFloor;

		public int currentabcount;

		public int clickcounter;

		public int missioncount;

		public static UILevelUpPanel _instance
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(LibraryFloorModel floor)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLevelupPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGlowColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayStartSound(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayRevealLevlSound()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayRevealRewardSound()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayMissionSound()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IsShowInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILevelUpPanel()
		{
			throw null;
		}
	}
}
