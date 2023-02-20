using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISephirahFloor : MonoBehaviour
	{
		public SephirahType sephirah;

		public UICustomSelectable selectable;

		public _2dxFX_HSV frameHsv;

		public _2dxFX_HSV IconHsv;

		public Image img_floorimage;

		public Image imgLockIcon;

		public Animator LevelUpIcon;

		public Animator img_talkStoryIcon;

		public Animator img_BattleTheBlueReverberation;

		[Header("Only Keter")]
		public UICustomSelectable leftSelectable;

		public _2dxFX_HSV leftFrameHsv;

		public _2dxFX_HSV leftIconHsv;

		public Image img_Leftfloorimage;

		public Image imgLeftLockIcon;

		public Animator imgLeftLevelUpIcon;

		public Animator img_lefttalkStoryIcon;

		public Animator img_leftBattleTheBlueReverberation;

		public Animator img_BattleBlackSilence;

		public Animator img_LeftBattleBlackSilence;

		private UISephirahFloor.SephirahState currentstate;

		public bool isSelected;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSelectableActive(bool isActive)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenAnimation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapLevelUPIcon(bool over)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapOpenTalkStoryIcon(bool over)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapTheBlueReverberationPrimaryIcon(bool over)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapBlackSilence(bool over)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickTalkIconInEvent(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void talkEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIMainPanel GetMainPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISephirahFloor()
		{
			throw null;
		}

		public enum SephirahState
		{
			BlackOut,
			Locked,
			Opened,
			LevelUp,
			Remove,
			TalkStory,
			BattleTheBlueReverberation,
			BattleBlackSilence,
			BattleTwistedBlue
		}
	}
}
