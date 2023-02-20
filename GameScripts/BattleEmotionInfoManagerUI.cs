using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class BattleEmotionInfoManagerUI : MonoBehaviour
{
	[Header("Reference Pos")]
	[SerializeField]
	private Transform[] left_lv1_fromTo;

	[SerializeField]
	private Transform[] left_lv2_fromTo;

	[SerializeField]
	private Transform[] left_lv3_fromTo;

	[SerializeField]
	private Transform[] left_lv4_fromTo;

	[SerializeField]
	private Transform[] left_lv5_fromTo;

	[SerializeField]
	private Transform[] right_lv1_fromTo;

	[SerializeField]
	private Transform[] right_lv2_fromTo;

	[SerializeField]
	private Transform[] right_lv3_fromTo;

	[SerializeField]
	private Transform[] right_lv4_fromTo;

	[SerializeField]
	private Transform[] right_lv5_fromTo;

	[Space]
	[Header("Runtime")]
	[SerializeField]
	private BattleEmotionBar[] enemyBars;

	[SerializeField]
	private BattleEmotionBar[] librarianBars;

	public BattleEmotionInfoManagerUI.ColorSet[] frameColors;

	[Space]
	[Header("Portrait List")]
	[SerializeField]
	private List<BattleEmotionBarPortraitUI> _ui_librarians;

	[SerializeField]
	private List<BattleEmotionBarPortraitUI> _ui_enemies;

	[Space]
	[Header("Team Slot")]
	[SerializeField]
	private BattleEmotionBarTeamSlotUI _playerTeam;

	[SerializeField]
	private BattleEmotionBarTeamSlotUI _enemyTEam;

	[Space]
	[SerializeField]
	private Image sephirahFrameImg;

	[SerializeField]
	private BookDropTypo _droppedBookUI;

	public List<GameObject> objList;

	[Header("Reward Info")]
	[SerializeField]
	private BattleEmotionRewardInfoUI RewardInfoPanel;

	[Header("Target Toggles")]
	public BattleEmotionInfo_TargetToggles targetingToggle;

	public BattleShortcutTooltipUI tooltipui;

	[Header("Buttons")]
	public BattleEmotionInfo_AutoCard autoCardButton;

	public BattleEmotionInfo_UnequipCardAll unequipcardallButton;

	[Header("Selectables")]
	[SerializeField]
	private List<UICustomSelectable> _leftSelectables;

	[SerializeField]
	private List<UICustomSelectable> _rightSelectables;

	[SerializeField]
	private GameObject ControlGuide;

	[SerializeField]
	private HorizontalLayoutGroup ControlGuideLayoutL;

	[SerializeField]
	private HorizontalLayoutGroup ControlGuideLayoutR;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitTeam()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(IList<BattleUnitModel> librarians, IList<BattleUnitModel> enemies)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSephirahFrameImgColor(Color c)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowRewardInfo(bool isover, BattleEmotionBarTeamSlotUI teamportrait = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLibrarianRewardInfo(bool isover, BattleEmotionBarPortraitUI pointeredUI)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnemyRewardInfo(bool isover, BattleEmotionBarPortraitUI pointeredUI)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DropBook(List<string> dropBooks)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCardsStateUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3[] GetSrcToDst(int emotionLv, Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color[] GetColor(int lv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEmotionBars(List<BattleUnitModel> list, BattleEmotionBar[] bars)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEmotionBarsByTeam(EmotionBattleTeamModel team, BattleEmotionBar[] bars)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusLeftPanel()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusRightPanel()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLTButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRTButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectPanel()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDeselectPanel()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionInfoManagerUI()
	{
		throw null;
	}

	[Serializable]
	public class ColorSet
	{
		public Color[] color;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorSet()
		{
			throw null;
		}
	}
}
