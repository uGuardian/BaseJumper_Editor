using System;
using System.Collections;
using System.Collections.Generic;
using LOR_BattleUnit_UI;
using LOR_DiceSystem;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleDiceCardUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler, IEndDragHandler
{
	[Header("Resource")]
	[SerializeField]
	private RectTransform vibeRect;

	[SerializeField]
	private Sprite[] costNumberSprite;

	[Header("Color")]
	[SerializeField]
	private Color[] refColors_Cost;

	[Header("References")]
	public TextMeshProUGUI txt_cardName;

	public Image[] img_Frames;

	public Image[] img_linearDodges;

	public GameObject selfAbilityArea;

	public TextMeshProUGUI txt_selfAbility;

	public List<BattleDiceCard_BehaviourDescUI> ui_behaviourDescList;

	public List<Image> img_behaviourDetatilList;

	public Animator anim;

	public Image img_artwork;

	public Image img_icon;

	public RefineHsv hsv_rangeIcon;

	[SerializeField]
	private RefineHsv hsv_Cost;

	private float _glowElapsedTime;

	[Header("added icons")]
	public BattleDiceCardBufUI[] bufIconListUI;

	[Header("Keyword")]
	public KeywordListUI KeywordListUI;

	[Header("Resist")]
	[SerializeField]
	private List<RefineHsv> hsv_behaviourIcons;

	[SerializeField]
	private List<TextMeshProUGUI> txt_Resist;

	[SerializeField]
	private List<TextMeshProUGUI> txt_bpResist;

	[Header("Frames")]
	[SerializeField]
	private GameObject[] ob_NormalFrames;

	[SerializeField]
	private GameObject[] ob_EgoFrames;

	[Header("Pad")]
	public UICustomSelectable selectable;

	[Header("Other Card")]
	public bool isProfileCard;

	[SerializeField]
	private bool isEmotionSelectedPopup;

	[HideInInspector]
	public Canvas _parentCanvas;

	private Transform mouseTransform;

	private int _defaultIdx;

	private BattleDiceCardModel _cardModel;

	private bool _bClicked;

	private bool _bAvailable;

	private bool _bFirstClicked;

	private bool _bEntered;

	private BattleUnitTargetArrowUI arrow;

	private Color colorFrame;

	private Color colorLineardodge;

	private Color colorLineardodge_deactive;

	public Vector3 scaleOrigin;

	[SerializeField]
	private NumbersData costNumbers;

	private int _cost;

	private int _originCost;

	private bool _editor;

	private bool isRunningVibeCard;

	private float vibeCounter;

	private Vector2 rangeIconOriginPos = new Vector2(305f, 189f);

	private Vector2 rangeIconEgoPos = new Vector2(335f, 189f);

	private EmotionEgoXmlInfo egoxmldata;

	[Header("Ego Gauge")]
	[SerializeField]
	private GameObject ob_EgoCoolTime;

	[SerializeField]
	private RectTransform rect_Gauge;

	[SerializeField]
	private Image img_Bg;

	[SerializeField]
	private Image img_BgGlow;

	[SerializeField]
	private RefineHsv hsv_bgGlow;

	[SerializeField]
	private Animator anim_gaugebgglow;

	[SerializeField]
	private Graphic[] graphics_EgoLockFrames;

	[SerializeField]
	private RefineHsv[] hsv_EgoLockFrames;

	private bool isEgoCoolTimeLock;

	private readonly float gaugeLength = 950f;

	public BattleDiceCardModel CardModel
	{
		get
		{
			return this._cardModel;
		}
	}

	public bool IsClicked
	{
		get
		{
			return this._bClicked;
		}
	}

	public bool IsEntered
	{
		get
		{
			return this._bEntered;
		}
	}

	public EmotionEgoXmlInfo EgoXmlData
	{
		get
		{
			return this.egoxmldata;
		}
	}

	public void EditorMode()
	{
		this._editor = true;
		base.transform.localScale = (this.scaleOrigin = new Vector3(1f, 1f, 1f));
		Animator animator = this.anim;
		if (animator == null)
		{
			return;
		}
		animator.SetBool("hOvered", true);
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private IEnumerator VibeCard(float time)
	{
		this.isRunningVibeCard = true;
		Vector3 localPosition = base.transform.localPosition;
		this.vibeCounter = 0f;
		while (this.vibeCounter <= time)
		{
			this.vibeCounter += TimeManager.GetUIDeltaTime();
			this.vibeRect.localPosition = UnityEngine.Random.insideUnitSphere * (this.IsEntered ? (((double)this.vibeCounter < 0.1) ? 50f : (10f / this.vibeCounter)) : (5f / this.vibeCounter));
			yield return YieldCache.waitFrame;
		}
		this.isRunningVibeCard = false;
		yield break;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		this.OnPdSubmit(eventData);
	}

	public void OnPdSubmit(BaseEventData data)
	{
		if (UIControlManager.GetInpuTypeOf(data) != InputType.ControllerInput)
		{
			PointerEventData pointerEventData = data as PointerEventData;
			if (pointerEventData == null || pointerEventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
		}
		BattleDiceCardUI.ClickableState clickableState = this.GetClickableState();
		if (clickableState == BattleDiceCardUI.ClickableState.CanClick_emotion)
		{
			SingletonBehavior<BattleManagerUI>.Instance.ui_levelup.OnSelectEgoCard(this);
			return;
		}
		if (clickableState == BattleDiceCardUI.ClickableState.CanClick)
		{
			this.OnClick();
			return;
		}
		if (clickableState == BattleDiceCardUI.ClickableState.NotEnoughCost)
		{
			this.PlayVibeCard();
			return;
		}
		if (clickableState == BattleDiceCardUI.ClickableState.NoTarget)
		{
			this.PlayVibeCard();
			return;
		}
		if (clickableState == BattleDiceCardUI.ClickableState.CannotClick)
		{
			this.PlayVibeCard();
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		this.ShowDetail();
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		this.HideDetail();
	}

	public void OnPdCursorEnter()
	{
		this.ShowDetail();
	}

	public void OnPdCursorExit()
	{
		this.HideDetail();
	}

	public void ShowDetail()
	{
		if (this.isProfileCard)
		{
			return;
		}
		if (this._editor)
		{
			return;
		}
		if (SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.IsCardSelected())
		{
			return;
		}
		if (!this.isEmotionSelectedPopup && this._cardModel != null && this._cardModel.XmlData.IsEgo())
		{
			if (this.isEgoCoolTimeLock)
			{
				return;
			}
			if (this._cardModel.XmlData.IsFloorEgo())
			{
				if (!Singleton<SpecialCardListModel>.Instance.ExistEgoCardHand(this._cardModel))
				{
					return;
				}
			}
			else
			{
				this._cardModel.XmlData.IsPersonal();
			}
		}
		this._bEntered = true;
		Animator animator = this.anim;
		if (animator != null)
		{
			animator.SetBool("hOvered", true);
		}
		if (!this.isEmotionSelectedPopup)
		{
			base.transform.SetSiblingIndex(base.transform.parent.childCount - 1);
			this.SetCostHightlighted(this.CardModel.GetCost());
			this.KeywordListUI.Activate();
		}
		base.transform.localScale = this.scaleOrigin * 1.25f;
		this.SetLinearDodgeColor(true);
		SingletonBehavior<BattleSoundManager>.Instance.PlaySound(EffectSoundType.CARD_OVER, false);
		this.KeywordListUI.Init(this.CardModel.XmlData, this.CardModel.GetBehaviourList());
	}

	public void HideDetail()
	{
		if (this.isProfileCard)
		{
			return;
		}
		if (this._editor)
		{
			return;
		}
		if (SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.IsCardSelected())
		{
			return;
		}
		this._bEntered = false;
		this.SetLinearDodgeColor(false);
		Animator animator = this.anim;
		if (animator != null)
		{
			animator.SetBool("hOvered", false);
		}
		this.KeywordListUI.Deactivate();
		base.transform.SetSiblingIndex(this._defaultIdx);
		base.transform.localScale = this.scaleOrigin;
		this.SetCostHightlighted(0);
		this.KeywordListUI.Deactivate();
	}

	public bool IsActivatedObject()
	{
		return base.gameObject.activeSelf;
	}

	public BattleDiceCardUI.ClickableState GetClickableState()
	{
		if (this.isEmotionSelectedPopup)
		{
			return BattleDiceCardUI.ClickableState.CanClick_emotion;
		}
		if (this.isProfileCard)
		{
			return BattleDiceCardUI.ClickableState.CannotClick;
		}
		if (Singleton<StageController>.Instance.Phase == StageController.StagePhase.RoundStartPhase_System)
		{
			return BattleDiceCardUI.ClickableState.CannotClick;
		}
		if (this._editor)
		{
			return BattleDiceCardUI.ClickableState.CannotClick;
		}
		if (SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.SelectedModel.turnState == BattleUnitTurnState.BREAK)
		{
			return BattleDiceCardUI.ClickableState.CannotClick;
		}
		if (this._cardModel == null)
		{
			return BattleDiceCardUI.ClickableState.CannotClick;
		}
		if (this._cardModel.XmlData.IsEgo())
		{
			if (this.isEgoCoolTimeLock)
			{
				return BattleDiceCardUI.ClickableState.CannotClick;
			}
			if (this._cardModel.XmlData.IsFloorEgo())
			{
				if (!Singleton<SpecialCardListModel>.Instance.ExistEgoCardHand(this._cardModel))
				{
					return BattleDiceCardUI.ClickableState.CannotClick;
				}
			}
			else
			{
				this._cardModel.XmlData.IsPersonal();
			}
		}
		if (!this._bEntered || this._bFirstClicked)
		{
			return BattleDiceCardUI.ClickableState.CannotClick;
		}
		BattleUnitModel selectedModel = SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.SelectedModel;
		if (selectedModel == null)
		{
			return BattleDiceCardUI.ClickableState.CannotClick;
		}
		if (!selectedModel.CheckCardAvailable(this.CardModel))
		{
			return BattleDiceCardUI.ClickableState.NotEnoughCost;
		}
		if (!BattleObjectManager.instance.GetAliveList(false).Exists(new Predicate<BattleUnitModel>(this.CheckTargetable)))
		{
			return BattleDiceCardUI.ClickableState.NoTarget;
		}
		return BattleDiceCardUI.ClickableState.CanClick;
	}

	public void PlayVibeCard()
	{
		this.vibeCounter = 0f;
		if (!this.isRunningVibeCard)
		{
			base.StartCoroutine(this.VibeCard(0.4f));
		}
		SingletonBehavior<BattleSoundManager>.Instance.PlaySound(EffectSoundType.CARD_LOCK, false);
	}

	public void OnClick()
	{
		BattleUnitModel selectedModel = SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.SelectedModel;
		if (selectedModel == null)
		{
			return;
		}
		if (this._cardModel == null)
		{
			return;
		}
		SingletonBehavior<BattleCamManager>.Instance.OnClickCardInHand();
		this._bFirstClicked = true;
		this.SetLinearDodgeColor(true);
		SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.SetSelectedCardUI(this);
		((Singleton<StageController>.Instance.AllyFormationDirection == Direction.RIGHT) ? SingletonBehavior<BattleManagerUI>.Instance.ui_unitInformationPlayer : SingletonBehavior<BattleManagerUI>.Instance.ui_unitInformation).OpenUnitInformationBySelectedCard(selectedModel, this.CardModel, -1);
		base.transform.SetSiblingIndex(base.transform.parent.childCount - 1);
		if (this.arrow != null)
		{
			if (this.arrow.gameObject != null)
			{
				UnityEngine.Object.Destroy(this.arrow.gameObject);
			}
			this.arrow = null;
		}
		SingletonBehavior<BattleSoundManager>.Instance.PlaySound(EffectSoundType.CARD_SELECT, false);
		SpeedDiceUI selectedAllyDice = SingletonBehavior<BattleManagerUI>.Instance.selectedAllyDice;
		if (selectedAllyDice != null)
		{
			this.arrow = SingletonBehavior<BattleManagerUI>.Instance.ui_TargetArrow.DrawPreviewTargetLine(selectedAllyDice.transform, this.mouseTransform, Faction.Player, false, false, 1);
		}
		BattleUIInputController.Instance.UpdateChracterSlots(true, new Predicate<BattleUnitModel>(this.CheckTargetable), true);
		if (SingletonBehavior<BattleTutorialManagerUI>.Instance.IsRunningTutorial && SingletonBehavior<BattleTutorialManagerUI>.Instance.selectCardFuncForTutorial != null)
		{
			SingletonBehavior<BattleTutorialManagerUI>.Instance.selectCardFuncForTutorial();
		}
	}

	private bool CheckTargetable(BattleUnitModel target)
	{
		BattleUnitModel selectedModel = SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.SelectedModel;
		return selectedModel != null && selectedModel != target && BattleUnitModel.IsTargetableUnit(this._cardModel, selectedModel, target, -1);
	}

	public void SetCard(BattleDiceCardModel cardModel, params BattleDiceCardUI.Option[] options)
	{
		bool isHide = false;
		if (options.Contains(BattleDiceCardUI.Option.HideDiceAbilityInfo))
		{
			isHide = true;
		}
		this.egoxmldata = null;
		this._cardModel = cardModel;
		bool flag = this._cardModel.XmlData.IsEgo();
		GameObject[] array = this.ob_NormalFrames;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(!flag);
		}
		array = this.ob_EgoFrames;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(flag);
		}
		if (LorId.IsModId(cardModel.XmlData.workshopID))
		{
			this.txt_cardName.text = cardModel.XmlData.workshopName;
		}
		else
		{
			this.txt_cardName.text = Singleton<BattleCardDescXmlList>.Instance.GetCardName(cardModel.GetTextId());
		}
		this.SetDefaultPreviewResistText();
		this._cost = this.CardModel.GetCost();
		this._originCost = this.CardModel.GetOriginCost();
		Sprite[] cardCostAddGlow = this.costNumberSprite;
		if (this._cost < this._originCost || this._cost > this._originCost)
		{
			cardCostAddGlow = UISpriteDataManager.instance.CardCostAddGlow;
		}
		this.costNumbers.SetOneValue(this.CardModel.GetCost(), cardCostAddGlow);
		Sprite rangeIconSprite = UISpriteDataManager.instance.GetRangeIconSprite(cardModel.GetSpec().Ranged);
		this.img_icon.sprite = rangeIconSprite;
		this.img_icon.rectTransform.anchoredPosition = (flag ? this.rangeIconEgoPos : this.rangeIconOriginPos);
		List<DiceBehaviour> behaviourList = cardModel.GetBehaviourList();
		int b = 4 - behaviourList.Count;
		string text = Singleton<BattleCardDescXmlList>.Instance.GetAbilityDesc(cardModel.GetID());
		if (string.IsNullOrEmpty(text))
		{
			List<string> abilityDesc = Singleton<BattleCardAbilityDescXmlList>.Instance.GetAbilityDesc(cardModel.XmlData);
			if (abilityDesc.Count > 0)
			{
				text = string.Join("\n", abilityDesc);
			}
		}
		else
		{
			string defaultAbilityDescString = Singleton<BattleCardAbilityDescXmlList>.Instance.GetDefaultAbilityDescString(cardModel.XmlData);
			if (!string.IsNullOrEmpty(defaultAbilityDescString))
			{
				text = defaultAbilityDescString + "\n" + text;
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			this.selfAbilityArea.SetActive(true);
			this.txt_selfAbility.text = TextUtil.TransformConditionKeyword(text);
			float preferredHeight = this.txt_selfAbility.preferredHeight;
			int num;
			if (preferredHeight < 260f)
			{
				num = 0;
			}
			else if (preferredHeight < 480f)
			{
				num = 1;
			}
			else if (preferredHeight < 700f)
			{
				num = 2;
			}
			else
			{
				num = 3;
			}
			num = Mathf.Min(num, b);
			RectTransform component = this.selfAbilityArea.GetComponent<RectTransform>();
			if (component != null)
			{
				if (num == 3)
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 880f);
				}
				else if (num == 2)
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 660f);
				}
				else if (num == 1)
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 440f);
				}
				else
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 220f);
				}
			}
		}
		else
		{
			this.selfAbilityArea.SetActive(false);
		}
		for (int j = 0; j < behaviourList.Count; j++)
		{
			this.ui_behaviourDescList[j].SetBehaviourInfo(behaviourList[j], cardModel.GetID(), cardModel.GetBehaviourList(), isHide);
			this.ui_behaviourDescList[j].gameObject.SetActive(true);
			Sprite sprite = (behaviourList[j].Type == BehaviourType.Standby) ? UISpriteDataManager.instance.CardStandbyBehaviourDetailIcons[(int)behaviourList[j].Detail] : UISpriteDataManager.instance._cardBehaviourDetailIcons[(int)behaviourList[j].Detail];
			this.img_behaviourDetatilList[j].sprite = sprite;
			this.img_behaviourDetatilList[j].gameObject.SetActive(true);
		}
		for (int k = behaviourList.Count; k < this.ui_behaviourDescList.Count; k++)
		{
			this.ui_behaviourDescList[k].gameObject.SetActive(false);
			this.img_behaviourDetatilList[k].gameObject.SetActive(false);
		}
		this.colorFrame = (flag ? UIColorManager.Manager.CardEgoCostColor : UIColorManager.Manager.GetCardRarityColor(cardModel.GetRarity()));
		this.colorLineardodge = (flag ? UIColorManager.Manager.CardEgoLinearColor : UIColorManager.Manager.GetCardRarityLinearColor(cardModel.GetRarity()));
		this.colorLineardodge_deactive = this.colorLineardodge;
		this.colorLineardodge_deactive.a = 1f;
		this.hsv_Cost._ValueBrightness = (flag ? 1.5f : 1f);
		this.hsv_Cost.CallUpdate();
		this.SetFrameColor(this.colorFrame);
		this.SetLinearDodgeColor(this.colorLineardodge);
		this.SetRangeIconHsv(flag ? UIColorManager.Manager.CardRangeHsvValue[5] : UIColorManager.Manager.CardRangeHsvValue[(int)this._cardModel.GetRarity()]);
		this.KeywordListUI.Deactivate();
		if (this._editor)
		{
			return;
		}
		Sprite sprite2;
		if (LorId.IsModId(cardModel.XmlData.workshopID))
		{
			sprite2 = Singleton<CustomizingCardArtworkLoader>.Instance.GetSpecificArtworkSprite(cardModel.XmlData.workshopID, cardModel.GetArtworkSrc());
		}
		else
		{
			sprite2 = Singleton<AssetBundleManagerRemake>.Instance.LoadCardSprite(cardModel.GetArtworkSrc());
		}
		if (sprite2 != null)
		{
			this.img_artwork.sprite = sprite2;
		}
		else
		{
			Debug.Log("Can't find sprite");
		}
		this.isEgoCoolTimeLock = false;
		this.SetEgoCoolTimeGauge();
		this.EnableAddedIcons();
	}

	public void SetEgoCardForPopup(EmotionEgoXmlInfo egoxmlinfo)
	{
		this.egoxmldata = egoxmlinfo;
		BattleDiceCardModel battleDiceCardModel = BattleDiceCardModel.CreatePlayingCard(ItemXmlDataList.instance.GetCardItem(egoxmlinfo.CardId, false));
		this._cardModel = battleDiceCardModel;
		this.isEgoCoolTimeLock = false;
		if (this.ob_EgoCoolTime != null && this.ob_EgoCoolTime.activeSelf)
		{
			this.ob_EgoCoolTime.SetActive(false);
		}
		bool flag = this._cardModel.XmlData.IsEgo();
		GameObject[] array = this.ob_NormalFrames;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
		array = this.ob_EgoFrames;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(true);
		}
		if (LorId.IsModId(battleDiceCardModel.XmlData.workshopID))
		{
			this.txt_cardName.text = battleDiceCardModel.XmlData.workshopName;
		}
		else
		{
			this.txt_cardName.text = Singleton<BattleCardDescXmlList>.Instance.GetCardName(battleDiceCardModel.GetTextId());
		}
		this.SetDefaultPreviewResistText();
		this._cost = this.CardModel.GetCost();
		this._originCost = this.CardModel.GetOriginCost();
		Sprite[] cardCostAddGlow = this.costNumberSprite;
		if (this._cost < this._originCost || this._cost > this._originCost)
		{
			cardCostAddGlow = UISpriteDataManager.instance.CardCostAddGlow;
		}
		this.costNumbers.SetOneValue(this.CardModel.GetCost(), cardCostAddGlow);
		Sprite rangeIconSprite = UISpriteDataManager.instance.GetRangeIconSprite(this._cardModel.GetSpec().Ranged);
		this.img_icon.sprite = rangeIconSprite;
		this.img_icon.rectTransform.anchoredPosition = this.rangeIconEgoPos;
		List<DiceBehaviour> behaviourList = battleDiceCardModel.GetBehaviourList();
		int b = 4 - behaviourList.Count;
		string text = Singleton<BattleCardDescXmlList>.Instance.GetAbilityDesc(battleDiceCardModel.GetID());
		if (string.IsNullOrEmpty(text))
		{
			List<string> abilityDesc = Singleton<BattleCardAbilityDescXmlList>.Instance.GetAbilityDesc(battleDiceCardModel.XmlData);
			if (abilityDesc.Count > 0)
			{
				text = string.Join("\n", abilityDesc);
			}
		}
		else
		{
			string defaultAbilityDescString = Singleton<BattleCardAbilityDescXmlList>.Instance.GetDefaultAbilityDescString(battleDiceCardModel.XmlData);
			if (!string.IsNullOrEmpty(defaultAbilityDescString))
			{
				text = defaultAbilityDescString + "\n" + text;
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			this.selfAbilityArea.SetActive(true);
			this.txt_selfAbility.text = TextUtil.TransformConditionKeyword(text);
			float preferredHeight = this.txt_selfAbility.preferredHeight;
			int num;
			if (preferredHeight < 260f)
			{
				num = 0;
			}
			else if (preferredHeight < 480f)
			{
				num = 1;
			}
			else if (preferredHeight < 700f)
			{
				num = 2;
			}
			else
			{
				num = 3;
			}
			num = Mathf.Min(num, b);
			RectTransform component = this.selfAbilityArea.GetComponent<RectTransform>();
			if (component != null)
			{
				if (num == 3)
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 880f);
				}
				else if (num == 2)
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 660f);
				}
				else if (num == 1)
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 440f);
				}
				else
				{
					component.sizeDelta = new Vector2(component.sizeDelta.x, 220f);
				}
			}
		}
		else
		{
			this.selfAbilityArea.SetActive(false);
		}
		for (int j = 0; j < behaviourList.Count; j++)
		{
			this.ui_behaviourDescList[j].SetBehaviourInfo(behaviourList[j], battleDiceCardModel.GetID(), battleDiceCardModel.GetBehaviourList(), false);
			this.ui_behaviourDescList[j].gameObject.SetActive(true);
			Sprite sprite = (behaviourList[j].Type == BehaviourType.Standby) ? UISpriteDataManager.instance.CardStandbyBehaviourDetailIcons[(int)behaviourList[j].Detail] : UISpriteDataManager.instance._cardBehaviourDetailIcons[(int)behaviourList[j].Detail];
			this.img_behaviourDetatilList[j].sprite = sprite;
			this.img_behaviourDetatilList[j].gameObject.SetActive(true);
		}
		for (int k = behaviourList.Count; k < this.ui_behaviourDescList.Count; k++)
		{
			this.ui_behaviourDescList[k].gameObject.SetActive(false);
			this.img_behaviourDetatilList[k].gameObject.SetActive(false);
		}
		this.colorFrame = UIColorManager.Manager.CardEgoCostColor;
		this.colorLineardodge = UIColorManager.Manager.CardEgoLinearColor;
		this.colorLineardodge_deactive = this.colorLineardodge;
		this.colorLineardodge_deactive.a = 1f;
		this.hsv_Cost._ValueBrightness = (flag ? 1.5f : 1f);
		this.hsv_Cost.CallUpdate();
		this.SetRangeIconHsv(UIColorManager.Manager.CardRangeHsvValue[5]);
		this.SetFrameColor(this.colorFrame);
		this.SetLinearDodgeColor(this.colorLineardodge);
		this.KeywordListUI.Deactivate();
		if (this._editor)
		{
			return;
		}
		Sprite sprite2;
		if (LorId.IsModId(battleDiceCardModel.XmlData.workshopID))
		{
			sprite2 = Singleton<CustomizingCardArtworkLoader>.Instance.GetSpecificArtworkSprite(battleDiceCardModel.XmlData.workshopID, battleDiceCardModel.GetArtworkSrc());
		}
		else
		{
			sprite2 = Singleton<AssetBundleManagerRemake>.Instance.LoadCardSprite(battleDiceCardModel.GetArtworkSrc());
		}
		if (sprite2 != null)
		{
			this.img_artwork.sprite = sprite2;
		}
		else
		{
			Debug.Log("Can't find sprite");
		}
		this.DisableAddedIcons();
	}

	private void DisableAddedIcons()
	{
		for (int i = 0; i < this.bufIconListUI.Length; i++)
		{
			this.bufIconListUI[i].SetEnable(false);
		}
	}

	private void EnableAddedIcons()
	{
		List<BattleDiceCardBuf> bufList = this._cardModel.GetBufList();
		int num = 0;
		foreach (BattleDiceCardBuf battleDiceCardBuf in bufList)
		{
			if (num >= this.bufIconListUI.Length)
			{
				break;
			}
			if (!(battleDiceCardBuf.GetBufIcon() == null))
			{
				this.bufIconListUI[num].SetBufIcon(battleDiceCardBuf);
				this.bufIconListUI[num].SetEnable(true);
				num++;
			}
		}
		for (int i = num; i < this.bufIconListUI.Length; i++)
		{
			this.bufIconListUI[i].SetEnable(false);
		}
	}

	public void ResetSiblingIndex()
	{
		base.transform.SetSiblingIndex(this._defaultIdx);
	}

	public void SetDefault()
	{
		this._bFirstClicked = false;
		this._bEntered = false;
		this.SetLinearDodgeColor(false);
		Animator animator = this.anim;
		if (animator != null)
		{
			animator.SetBool("hOvered", false);
		}
		this.KeywordListUI.Deactivate();
		base.transform.localScale = this.scaleOrigin;
		if (this.arrow != null)
		{
			if (this.arrow.gameObject != null)
			{
				UnityEngine.Object.Destroy(this.arrow.gameObject);
			}
			this.arrow = null;
		}
		this.SetCostHightlighted(0);
	}

	public void SetLinearDodgeColor(bool activated)
	{
		if (activated)
		{
			this.SetLinearDodgeColor(this.colorLineardodge);
			return;
		}
		this.SetLinearDodgeColor(this.colorLineardodge_deactive);
	}

	private void SetLinearDodgeColor(Color c)
	{
		for (int i = 0; i < this.img_linearDodges.Length; i++)
		{
			this.img_linearDodges[i].color = c;
		}
	}

	private void SetFrameColor(Color c)
	{
		for (int i = 0; i < this.img_Frames.Length; i++)
		{
			this.img_Frames[i].color = c;
		}
		if (this._cost == this._originCost)
		{
			this.costNumbers.SetContentColor(c);
			this.hsv_Cost._HueShift = 0f;
			this.hsv_Cost.CallUpdate();
			return;
		}
		if (this._cost < this._originCost)
		{
			this.costNumbers.SetContentColor(Color.white);
			this.hsv_Cost._HueShift = 0f;
			this.hsv_Cost.CallUpdate();
			return;
		}
		if (this._cost > this._originCost)
		{
			this.costNumbers.SetContentColor(Color.white);
			this.hsv_Cost._HueShift = 150f;
			this.hsv_Cost.CallUpdate();
		}
	}

	private void SetRangeIconHsv(Vector3 hsvvalue)
	{
		this.img_icon.color = Color.white;
		if (this.hsv_rangeIcon == null)
		{
			this.hsv_rangeIcon = this.img_icon.GetComponent<RefineHsv>();
		}
		if (this.hsv_rangeIcon == null)
		{
			Debug.LogError("Hsv Not Reference");
			return;
		}
		this.hsv_rangeIcon._HueShift = hsvvalue.x;
		this.hsv_rangeIcon._Saturation = hsvvalue.y;
		this.hsv_rangeIcon._ValueBrightness = hsvvalue.z;
		this.hsv_rangeIcon.CallUpdate();
	}

	private void SetCostHightlighted(int cost)
	{
		BattleUnitModel selectedModel = SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.SelectedModel;
		if (selectedModel == null)
		{
			return;
		}
		BattlePlayingCardDataInUnitModel battlePlayingCardDataInUnitModel = selectedModel.cardSlotDetail.cardAry[(selectedModel.cardOrder == -1) ? 0 : selectedModel.cardOrder];
		selectedModel.view.costUI.SetHightlightedCurrentCostCard(cost, (battlePlayingCardDataInUnitModel != null) ? battlePlayingCardDataInUnitModel.card.GetCost() : 0);
	}

	private void Awake()
	{
		this._defaultIdx = base.transform.GetSiblingIndex();
		if (SingletonBehavior<BattleManagerUI>.Instance != null)
		{
			this.mouseTransform = SingletonBehavior<BattleManagerUI>.Instance.ui_unitCardsInHand.mouseFollowingTransform;
		}
		this.scaleOrigin = base.transform.localScale;
	}

	private void Start()
	{
		string a = Singleton<LocalizedTextLoader>.Instance.CurrentLanguage.ToLower();
		if (a == "cn" || a == "trcn")
		{
			SingletonBehavior<LocalizedFontSetter>.Instance.SetLocalizedFont(this.txt_cardName, FontType.FONT_HEAD);
		}
		else
		{
			SingletonBehavior<LocalizedFontSetter>.Instance.SetLocalizedFont(this.txt_cardName, FontType.FONT_BODY);
		}
		SingletonBehavior<LocalizedFontSetter>.Instance.SetLocalizedFont(this.txt_selfAbility, FontType.FONT_BODY);
	}

	private void OnEnable()
	{
		string a = Singleton<LocalizedTextLoader>.Instance.CurrentLanguage.ToLower();
		if (a == "cn" || a == "trcn")
		{
			SingletonBehavior<LocalizedFontSetter>.Instance.SetLocalizedFont(this.txt_cardName, FontType.FONT_HEAD);
		}
		else
		{
			SingletonBehavior<LocalizedFontSetter>.Instance.SetLocalizedFont(this.txt_cardName, FontType.FONT_BODY);
		}
		SingletonBehavior<LocalizedFontSetter>.Instance.SetLocalizedFont(this.txt_selfAbility, FontType.FONT_BODY);
	}

	private void OnDisable()
	{
		this.SetDefault();
	}

	private void Update()
	{
		if (base.transform.localScale.magnitude < this.scaleOrigin.magnitude)
		{
			base.transform.localScale = this.scaleOrigin;
		}
		if (this._cardModel == null)
		{
			return;
		}
		this._glowElapsedTime += TimeManager.GetUIDeltaTime();
		if (this._glowElapsedTime > 1f)
		{
			this._glowElapsedTime = 0f;
		}
	}

	public void SetPreviewResist(BattleUnitModel targetunit, BattleDiceCardModel parryingCard = null)
	{
		this.SetDefaultPreviewResistText();
		if (targetunit == null)
		{
			return;
		}
		List<DiceBehaviour> behaviourList = this._cardModel.GetBehaviourList();
		for (int i = 0; i < behaviourList.Count; i++)
		{
			string resistHP_Text = targetunit.GetResistHP_Text(behaviourList[i].Detail);
			this.txt_Resist[i].text = resistHP_Text;
			AtkResist resistHP = targetunit.GetResistHP(behaviourList[i].Detail);
			float saturation = 1f;
			switch (resistHP)
			{
			case AtkResist.Weak:
				saturation = 1f;
				break;
			case AtkResist.Vulnerable:
				saturation = 0.8f;
				break;
			case AtkResist.Normal:
				saturation = 0.6f;
				break;
			case AtkResist.Endure:
				saturation = 0.4f;
				break;
			case AtkResist.Resist:
				saturation = 0.2f;
				break;
			}
			this.hsv_behaviourIcons[i]._Saturation = saturation;
			this.hsv_behaviourIcons[i].CallUpdate();
			string resistBP_Text = targetunit.GetResistBP_Text(behaviourList[i].Detail);
			this.txt_bpResist[i].text = resistBP_Text;
		}
	}

	public void SetDefaultPreviewResistText()
	{
		foreach (TextMeshProUGUI textMeshProUGUI in this.txt_Resist)
		{
			textMeshProUGUI.text = "";
		}
		foreach (TextMeshProUGUI textMeshProUGUI2 in this.txt_bpResist)
		{
			textMeshProUGUI2.text = "";
		}
		foreach (RefineHsv refineHsv in this.hsv_behaviourIcons)
		{
			refineHsv._Saturation = 1f;
			refineHsv.CallUpdate();
		}
	}

	public void SetEgoCoolTimeGauge()
	{
		if (this.ob_EgoCoolTime == null)
		{
			return;
		}
		if (!this._cardModel.XmlData.IsEgo())
		{
			this.ob_EgoCoolTime.SetActive(false);
			this.SetEgoFrameLockColor(false);
			return;
		}
		if ((this.isProfileCard || this.isEmotionSelectedPopup) && this.ob_EgoCoolTime != null && this.ob_EgoCoolTime.activeSelf)
		{
			this.ob_EgoCoolTime.gameObject.SetActive(false);
			return;
		}
		this.ob_EgoCoolTime.gameObject.SetActive(true);
		float num = 0f;
		if (this._cardModel.MaxCooltimeValue != 0f)
		{
			num = this._cardModel.CurrentCooltimeValue / this._cardModel.MaxCooltimeValue;
		}
		if (num >= 1f)
		{
			this.ob_EgoCoolTime.gameObject.SetActive(false);
			this.SetEgoFrameLockColor(false);
			return;
		}
		this.rect_Gauge.anchoredPosition = new Vector2(this.gaugeLength * num, 0f);
		this.hsv_bgGlow.CallUpdate();
		if (num < 0.7f)
		{
			Color color = this.img_BgGlow.color;
			color.a = 1f;
			this.img_BgGlow.color = color;
			this.anim_gaugebgglow.enabled = false;
			this.hsv_bgGlow._ValueBrightness = 0.3f;
			Color white = Color.white;
			white.a = 0.3f;
			this.img_Bg.color = white;
		}
		else
		{
			this.hsv_bgGlow._ValueBrightness = num * 1.2f;
			this.anim_gaugebgglow.enabled = true;
			Color white2 = Color.white;
			white2.a = 0.7f;
			this.img_Bg.color = white2;
		}
		this.SetEgoLock();
	}

	public void SetEgoLock()
	{
		this.isEgoCoolTimeLock = true;
		Color uicolor = UIColorManager.Manager.GetUIColor(UIColor.Disabled);
		this.SetFrameColor(uicolor);
		this.SetLinearDodgeColor(uicolor);
		this.SetEgoFrameLockColor(true);
		this.SetRangeIconHsv(new Vector3(0f, 0f, 1f));
	}

	public void SetEgoFrameLockColor(bool on)
	{
		Color color = on ? UIColorManager.Manager.GetUIColor(UIColor.Disabled) : Color.white;
		foreach (Graphic graphic in this.graphics_EgoLockFrames)
		{
			if (!(graphic == null))
			{
				graphic.color = color;
			}
		}
		float saturation = (float)(on ? 0 : 1);
		foreach (RefineHsv refineHsv in this.hsv_EgoLockFrames)
		{
			refineHsv._Saturation = saturation;
			refineHsv.CallUpdate();
		}
		foreach (RefineHsv refineHsv2 in this.hsv_behaviourIcons)
		{
			refineHsv2._Saturation = saturation;
			refineHsv2.CallUpdate();
		}
	}

	public enum Option
	{
		HideDiceAbilityInfo
	}

	public enum ClickableState
	{
		CanClick_emotion,
		CanClick,
		CannotClick,
		NotEnoughCost,
		NoTarget
	}
}
