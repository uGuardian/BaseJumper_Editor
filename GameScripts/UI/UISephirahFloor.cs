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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSelectableActive(bool isActive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenAnimation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapLevelUPIcon(bool over)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapOpenTalkStoryIcon(bool over)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapTheBlueReverberationPrimaryIcon(bool over)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapBlackSilence(bool over)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickTalkIconInEvent(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void talkEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			throw null;
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
