using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIEnemyCharacterListPanel : UICharacterListPanel
	{
		[SerializeField]
		private RectTransform rect_Pivot;

		private StageClassInfo currentEnemyStageinfo;

		private int currentWave;

		[SerializeField]
		private GameObject StageEnemyListObject;

		[SerializeField]
		private List<UICustomGraphicObject> StageNumList;

		[SerializeField]
		private UICustomGraphicObject LeftStageButton;

		[SerializeField]
		private UICustomGraphicObject RightStageButton;

		[SerializeField]
		private UICustomSelectable leftSelectableObject;

		[SerializeField]
		private UICustomSelectable rightSelectableObject;

		[Header("Only blue contents")]
		[SerializeField]
		private GameObject ob_blueeffect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate(bool isTrue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSelect(UICharacterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseCurrentSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyInfo(StageClassInfo data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyWave(int targetWave)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyInfoInBattleSetting(StageClassInfo data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyWaveInBattleSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyCharacterListPanel(List<UnitDataModel> data, bool selectable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFrame(UIStoryLine story = UIStoryLine.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePanel(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickRight()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLeft()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNum(int num)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeEnemyWave(int num)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBattleSettingPanel GetBattleSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSelectableObject(int dir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEnemyCharacterListPanel()
		{
			throw null;
		}
	}
}
