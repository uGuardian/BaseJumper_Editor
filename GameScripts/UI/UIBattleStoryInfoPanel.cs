using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleStoryInfoPanel : MonoBehaviour
	{
		[SerializeField]
		private UIBattleStoryPanel panel;

		[Header("stage Info")]
		[SerializeField]
		private Image IconGlow;

		[SerializeField]
		private Image Icon;

		[SerializeField]
		private TextMeshProUGUI stageName;

		[SerializeField]
		private Image CG;

		[Header("story Buttons")]
		[SerializeField]
		private UICustomGraphicObject startStoryButton;

		[SerializeField]
		private UICustomGraphicObject endStoryButton;

		[Header("Controller")]
		public UICustomSelectablePanel selectablePanel;

		private const string _storyDirectoryPath = "StoryResource/";

		private const string _bgSpritesPath = "BgSprites/";

		private StageClassInfo currentStage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(StageClassInfo stage)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButton(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReturnFromEndStory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEnemyCharacterListPanel GetEnemyListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleStoryInfoPanel()
		{
			throw null;
		}
	}
}
