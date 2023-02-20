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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate(bool isTrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSelect(UICharacterSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseCurrentSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyInfo(StageClassInfo data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyWave(int targetWave)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyInfoInBattleSetting(StageClassInfo data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyWaveInBattleSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyCharacterListPanel(List<UnitDataModel> data, bool selectable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFrame(UIStoryLine story = UIStoryLine.None)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePanel(UIPhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickRight()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLeft()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNum(int num)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeEnemyWave(int num)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBattleSettingPanel GetBattleSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSelectableObject(int dir)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEnemyCharacterListPanel()
		{
			throw null;
		}
	}
}
