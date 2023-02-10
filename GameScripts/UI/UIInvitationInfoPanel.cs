using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIInvitationInfoPanel : MonoBehaviour
	{
		[Header("Reference")]
		public UIInvitationPanel rootPanel;

		[Header("StageInfoPanel")]
		[SerializeField]
		private UIInvitationStageInfoPanel _stageInfoPanel;

		[Header("EnemyUnitInfoPanel")]
		[SerializeField]
		private UIShowEnemyInfoPanel _enemyCharacterinfoPanel;

		[Header("DropBookInfoPanel")]
		[SerializeField]
		private UIShowUsingBookInfoPanel _dropBookInfoPanel;

		private UIInvShowInfoState _currentShowState;

		public UIInvitationStageInfoPanel StageInfoPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIShowEnemyInfoPanel EnemyCharacterinfoPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIShowUsingBookInfoPanel DropBookInfoPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIInvShowInfoState CurrentShowState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetShowState(UIInvShowInfoState state, UnitDataModel unit = null, Texture rawimagetexture = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowStageInfoData(bool on, StageClassInfo stage = null, UIStoryLine story = UIStoryLine.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowEnemyInfo(bool on, UnitDataModel unit = null, Texture rawimagetexture = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDropBookInfo(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFilterPanel GetFilterPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationInfoPanel()
		{
			throw null;
		}
	}
}
