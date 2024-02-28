using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterAppearance : MonoBehaviour
{
	private static GiftPosition[] AllGiftPosition = new GiftPosition[]
	{
		GiftPosition.Eye,
		GiftPosition.Nose,
		GiftPosition.Cheek,
		GiftPosition.Mouth,
		GiftPosition.Ear,
		GiftPosition.HairAccessory,
		GiftPosition.Hood,
		GiftPosition.Mask,
		GiftPosition.Helmet
	};

	public float customHeadScaleFactor = 1f;

	[SerializeField]
	private bool _customizable = true;

	public bool isActionCharacter;

	[HideInInspector]
	public int bookID;

	public CharacterSpriteMaskController maskControl;

	public Transform atkEffectRoot;

	[SerializeField]
	private Transform atkEffectPivot_H;

	[SerializeField]
	private Transform atkEffectPivot_J;

	[SerializeField]
	private Transform atkEffectPivot_Z;

	[SerializeField]
	private Transform atkEffectPivot_G;

	[SerializeField]
	private Transform atkEffectPivot_E;

	[SerializeField]
	private Transform atkEffectPivot_S;

	[SerializeField]
	private Transform atkEffectPivot_F;

	[SerializeField]
	private List<CharacterAppearance.MotionPivot> _specialMotionPivotList;

	[SerializeField]
	public List<CharacterMotion> _motionList;

	[SerializeField]
	private CustomizedAppearance _customAppearance;

	private Dictionary<GiftPosition, GiftAppearance> _giftAppearanceDic = new Dictionary<GiftPosition, GiftAppearance>();

	protected Dictionary<ActionDetail, CharacterMotion> _characterMotionDic = new Dictionary<ActionDetail, CharacterMotion>();

	protected CharacterMotion _currentMotion;

	protected string _layerName = "Character";

	protected Coroutine _imgColorRoutine;

	protected Color _curSpriteColor = Color.white;

	protected Color _curSkinColor = Color.white;

	protected CharacterSound _soundInfo;

	protected bool _initialized;

	private string _resourceName = "";

	private CharacterAppearance.OnCharMotionChanged _onCharMotionChanged;

	private List<CharacterBloodSpriteEffect> _bloodSpriteList = new List<CharacterBloodSpriteEffect>();

	private List<GameObject> _addedChildren = new List<GameObject>();

	protected Dictionary<ActionDetail, ActionDetail> _altMotion = new Dictionary<ActionDetail, ActionDetail>();

	public Transform cameraPivot;

	public CharacterSound soundInfo
	{
		get
		{
			return this._soundInfo;
		}
	}

	public bool isCustomizable
	{
		get
		{
			return this._customizable;
		}
	}

	public IDictionary<ActionDetail, CharacterMotion> CharacterMotions
	{
		get
		{
			return this._characterMotionDic;
		}
	}

	public Color CurSpritesColor
	{
		get
		{
			return this._curSpriteColor;
		}
	}

	public CustomizedAppearance CustomAppearance
	{
		get
		{
			return this._customAppearance;
		}
	}

	public Dictionary<GiftPosition, GiftAppearance> GiftAppearances
	{
		get
		{
			return this._giftAppearanceDic;
		}
	}

	public string resourceName
	{
		get
		{
			return this._resourceName;
		}
	}

	public Transform GetAtkEffectPivot(ActionDetail action)
	{
		switch (action)
		{
		case ActionDetail.Guard:
			if (this.atkEffectPivot_G == null)
			{
				return this.atkEffectRoot;
			}
			return this.atkEffectPivot_G;
		case ActionDetail.Evade:
			if (this.atkEffectPivot_E == null)
			{
				return this.atkEffectRoot;
			}
			return this.atkEffectPivot_E;
		case ActionDetail.Slash:
			if (this.atkEffectPivot_J == null)
			{
				return this.atkEffectRoot;
			}
			return this.atkEffectPivot_J;
		case ActionDetail.Penetrate:
			if (this.atkEffectPivot_Z == null)
			{
				return this.atkEffectRoot;
			}
			return this.atkEffectPivot_Z;
		case ActionDetail.Hit:
			if (this.atkEffectPivot_H == null)
			{
				return this.atkEffectRoot;
			}
			return this.atkEffectPivot_H;
		case ActionDetail.Fire:
			if (this.atkEffectPivot_F == null)
			{
				return this.atkEffectRoot;
			}
			return this.atkEffectPivot_F;
		}
		return this.atkEffectRoot;
	}

	public Transform GetSpecialMotionPivot(ActionDetail motion)
	{
		if (this._specialMotionPivotList == null || this._specialMotionPivotList.Count == 0)
		{
			return this.atkEffectRoot;
		}
		CharacterAppearance.MotionPivot motionPivot = this._specialMotionPivotList.Find((CharacterAppearance.MotionPivot x) => x.motion == motion);
		Transform pivot;
		if (motionPivot != null)
		{
			pivot = motionPivot.pivot;
		}
		else
		{
			pivot = this.atkEffectRoot;
		}
		return pivot;
	}

	public void SetList(List<CharacterMotion> m)
	{
		this._motionList = m;
	}

	public void AddChild(GameObject go)
	{
		this._addedChildren.Add(go);
		go.transform.parent = base.transform;
		go.layer = LayerMask.NameToLayer(this.GetLayerName());
	}

	public CharacterMotion GetCharacterMotion(ActionDetail action)
	{
		return this._motionList.Find((CharacterMotion x) => x.actionDetail == action);
	}

	public virtual void InitCustomData(UnitCustomizingData customizeData, LorId defaultBookId)
	{
		if (defaultBookId == 1409021)
		{
			this._customizable = true;
		}
		if (this._customizable)
		{
			if (!customizeData.UseCustomData)
			{
				bool flag = (defaultBookId.IsBasic() && defaultBookId.id >= 1 && defaultBookId.id <= 20) || defaultBookId == 9100501;
				foreach (CharacterMotion characterMotion in this._motionList)
				{
					characterMotion.SetSkinSprite(false);
					if (!flag)
					{
						characterMotion.DisableSpritesByType(CharacterAppearanceType.LibrarianOnly);
					}
				}
				this.ChangeMotion(ActionDetail.Standing);
			}
			else
			{
				CustomizedAppearance customAppearance = this._customAppearance;
				if (((customAppearance != null) ? customAppearance.gameObject : null) != null)
				{
					UnityEngine.Object.Destroy(this._customAppearance.gameObject);
				}
				this._customAppearance = Singleton<CustomizingResourceLoader>.Instance.CreateCustomizedAppearance(customizeData, base.transform);
				this._customAppearance.InitCustomData(customizeData, this);
				this._customAppearance.SetScaleFactor(this.customHeadScaleFactor);
				this._customAppearance.ChangeLayer(this._layerName);
				foreach (CharacterMotion characterMotion2 in this._motionList)
				{
					characterMotion2.SetSkinSprite(true);
					bool isLibrarian = (defaultBookId.IsBasic() && defaultBookId.id >= 1 && defaultBookId.id <= 20) || defaultBookId == 9070402 || defaultBookId == 9070542;
					characterMotion2.DisableSpritesByCustomizing(isLibrarian);
					characterMotion2.CustomizeSkinColor(customizeData.skinColor);
					this._curSkinColor = customizeData.skinColor;
				}
				this.ChangeMotion(ActionDetail.Standing);
			}
		}
		if (this.maskControl == null)
		{
			this.maskControl = base.gameObject.AddComponent<CharacterSpriteMaskController>();
		}
		this.maskControl.maskList.Clear();
		foreach (CharacterMotion characterMotion3 in this._motionList)
		{
			foreach (SpriteSet spriteSet in characterMotion3.motionSpriteSet)
			{
				SpriteMask spriteMask = spriteSet.sprRenderer.GetComponent<SpriteMask>();
				if (spriteMask == null)
				{
					spriteMask = spriteSet.sprRenderer.gameObject.AddComponent<SpriteMask>();
				}
				spriteMask.sprite = spriteSet.sprRenderer.sprite;
				this.maskControl.maskList.Add(spriteMask);
			}
		}
		foreach (KeyValuePair<GiftPosition, GiftAppearance> keyValuePair in this._giftAppearanceDic)
		{
			foreach (SpriteRenderer spriteRenderer in keyValuePair.Value.GetSpriteRenderers())
			{
				SpriteMask spriteMask2 = spriteRenderer.GetComponent<SpriteMask>();
				if (spriteMask2 == null)
				{
					spriteMask2 = spriteRenderer.gameObject.AddComponent<SpriteMask>();
				}
				spriteMask2.sprite = spriteRenderer.sprite;
				this.maskControl.maskList.Add(spriteMask2);
			}
		}
		if (this._customizable && this._customAppearance != null)
		{
			foreach (SpriteRenderer spriteRenderer2 in this._customAppearance.allSpriteList)
			{
				SpriteMask spriteMask3 = spriteRenderer2.GetComponent<SpriteMask>();
				if (spriteMask3 == null)
				{
					spriteMask3 = spriteRenderer2.gameObject.AddComponent<SpriteMask>();
				}
				spriteMask3.sprite = spriteRenderer2.sprite;
				this.maskControl.maskList.Add(spriteMask3);
			}
		}
	}

	public virtual void InitGiftDataAll(List<GiftModel> equippedGiftList)
	{
		if (equippedGiftList.Count >= 0)
		{
			List<GiftPosition> list = new List<GiftPosition>();
			using (Dictionary<GiftPosition, GiftAppearance>.Enumerator enumerator = this._giftAppearanceDic.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<GiftPosition, GiftAppearance> kv = enumerator.Current;
					if (!equippedGiftList.Exists((GiftModel x) => x.ClassInfo.Position == kv.Key))
					{
						UnityEngine.Object.Destroy(kv.Value.gameObject);
						list.Add(kv.Key);
					}
				}
			}
			foreach (GiftPosition key in list)
			{
				this._giftAppearanceDic.Remove(key);
			}
			foreach (GiftModel gift in equippedGiftList)
			{
				this.InitGiftData(gift, false);
			}
			this.RefreshAppearanceByGifts();
		}
	}

	protected virtual GiftAppearance CreateGiftData(GiftModel gift, string resPath)
	{
		if (this._customAppearance == null)
		{
			return null;
		}
		bool flag = false;
		GiftAppearance giftAppearance = null;
		if (this._giftAppearanceDic.ContainsKey(gift.ClassInfo.Position))
		{
			giftAppearance = this._giftAppearanceDic[gift.ClassInfo.Position];
			if (giftAppearance.ResourceName != resPath)
			{
				this._giftAppearanceDic.Remove(gift.ClassInfo.Position);
				UnityEngine.Object.Destroy(giftAppearance.gameObject);
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			GameObject gameObject = Resources.Load<GameObject>(resPath);
			if (!(gameObject != null))
			{
				Debug.LogError("gift not found");
				return null;
			}
			giftAppearance = UnityEngine.Object.Instantiate<GameObject>(gameObject, base.transform).GetComponent<GiftAppearance>();
			this._giftAppearanceDic.Add(gift.ClassInfo.Position, giftAppearance);
		}
		if (giftAppearance != null)
		{
			giftAppearance.Init(gift, this._layerName);
			BodyAura[] componentsInChildren = giftAppearance.gameObject.GetComponentsInChildren<BodyAura>();
			if (componentsInChildren != null && componentsInChildren.Length != 0)
			{
				BodyAura[] array = componentsInChildren;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetAppearance(this);
				}
			}
			giftAppearance.RefreshAppearance(this._customAppearance, this._currentMotion);
		}
		return giftAppearance;
	}

	public void InitGiftData(GiftModel gift, bool refreshAppearance = true)
	{
		if (this._customAppearance == null)
		{
			return;
		}
		this.CreateGiftData(gift, gift.GetResourcePath());
		if (refreshAppearance)
		{
			this.RefreshAppearanceByGifts();
		}
	}

	public GiftAppearance SetTemporaryGift(string resPath, GiftPosition position, bool refreshAppearance = true)
	{
		if (this._customAppearance == null)
		{
			return null;
		}
		GiftModel gift = new GiftModel(Singleton<GiftXmlList>.Instance.CreateTemporaryGift("", position));
		GiftAppearance result = this.CreateGiftData(gift, "Prefabs/Gifts/OnlyBattle/" + resPath);
		if (refreshAppearance)
		{
			this.RefreshAppearanceByGifts();
		}
		return result;
	}

	public virtual void SetDamagedSprite(int dmg, float curHp)
	{
		CharacterBloodSpriteEffect characterBloodSpriteEffect = UnityEngine.Object.Instantiate<CharacterBloodSpriteEffect>(SingletonBehavior<DiceEffectManager>.Instance.bloodSpriteObj, base.transform);
		if (curHp - (float)dmg <= 0f)
		{
			curHp = (float)dmg;
		}
		float scaleFactor = (float)dmg / curHp;
		characterBloodSpriteEffect.Init(scaleFactor);
		characterBloodSpriteEffect.gameObject.layer = LayerMask.NameToLayer(this._layerName);
		this._bloodSpriteList.Add(characterBloodSpriteEffect);
		if (this._bloodSpriteList.Count > 5)
		{
			this._bloodSpriteList[0].Destroy();
			this._bloodSpriteList.RemoveAt(0);
		}
	}

	public virtual void ClearDamagedSprite()
	{
		if (this._bloodSpriteList != null && this._bloodSpriteList.Count > 0)
		{
			foreach (CharacterBloodSpriteEffect characterBloodSpriteEffect in this._bloodSpriteList)
			{
				UnityEngine.Object.Destroy(characterBloodSpriteEffect.gameObject);
			}
			this._bloodSpriteList.Clear();
		}
	}

	public virtual void SetLibrarianOnlySprites(Faction faction)
	{
		bool librarianOnlySprite = faction == Faction.Player;
		foreach (CharacterMotion characterMotion in this._motionList)
		{
			characterMotion.SetLibrarianOnlySprite(librarianOnlySprite);
		}
	}

	public ActionDetail GetCurrentMotionDetail()
	{
		return this._currentMotion.actionDetail;
	}

	public CharacterMotion GetCurrentMotion()
	{
		return this._currentMotion;
	}

	public string GetLayerName()
	{
		return this._layerName;
	}

	public void ChangeLayer(string layerName)
	{
		this._layerName = layerName;
		CustomizedAppearance customAppearance = this._customAppearance;
		if (customAppearance != null)
		{
			customAppearance.ChangeLayer(layerName);
		}
		foreach (KeyValuePair<ActionDetail, CharacterMotion> keyValuePair in this._characterMotionDic)
		{
			List<SpriteSet> motionSpriteSet = keyValuePair.Value.motionSpriteSet;
			for (int i = 0; i < motionSpriteSet.Count; i++)
			{
				if (motionSpriteSet[i].sprType == CharacterAppearanceType.Effect)
				{
					motionSpriteSet[i].sprRenderer.gameObject.layer = LayerMask.NameToLayer("Effect");
				}
				else
				{
					motionSpriteSet[i].sprRenderer.gameObject.layer = LayerMask.NameToLayer(this._layerName);
				}
			}
			foreach (KeyValuePair<GiftPosition, GiftAppearance> keyValuePair2 in this._giftAppearanceDic)
			{
				keyValuePair2.Value.SetLayer(this._layerName);
			}
		}
		foreach (CharacterBloodSpriteEffect characterBloodSpriteEffect in this._bloodSpriteList)
		{
			characterBloodSpriteEffect.gameObject.layer = LayerMask.NameToLayer(this._layerName);
		}
		foreach (GameObject gameObject in this._addedChildren)
		{
			gameObject.layer = LayerMask.NameToLayer(this._layerName);
		}
	}

	public virtual void ChangeMotion(ActionDetail detail)
	{
		if (this._altMotion.ContainsKey(detail))
		{
			detail = this._altMotion[detail];
		}
		if (!this._characterMotionDic.ContainsKey(detail))
		{
			switch (detail)
			{
			case ActionDetail.Slash2:
				detail = ActionDetail.Slash;
				break;
			case ActionDetail.Penetrate2:
				detail = ActionDetail.Penetrate;
				break;
			case ActionDetail.Hit2:
				detail = ActionDetail.Hit;
				break;
			}
			if (!this._characterMotionDic.ContainsKey(detail))
			{
				detail = ActionDetail.Default;
			}
		}
		if (this._characterMotionDic.Count > 0)
		{
			if (!this._characterMotionDic.ContainsKey(detail))
			{
				this._currentMotion = this._characterMotionDic.First<KeyValuePair<ActionDetail, CharacterMotion>>().Value;
			}
			if (this._currentMotion == null)
			{
				this._currentMotion = this._characterMotionDic[detail];
				GameObject gameObject = this._currentMotion.gameObject;
				if (gameObject != null)
				{
					gameObject.SetActive(true);
				}
			}
			if (this._currentMotion.actionDetail != detail)
			{
				GameObject gameObject2 = this._currentMotion.gameObject;
				if (gameObject2 != null)
				{
					gameObject2.SetActive(false);
				}
				if (this._characterMotionDic.ContainsKey(detail))
				{
					this._currentMotion = this._characterMotionDic[detail];
				}
				GameObject gameObject3 = this._currentMotion.gameObject;
				if (gameObject3 != null)
				{
					gameObject3.SetActive(true);
				}
				try
				{
					CharacterAppearance.OnCharMotionChanged onCharMotionChanged = this._onCharMotionChanged;
					if (onCharMotionChanged != null)
					{
						onCharMotionChanged();
					}
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
			if (this._customAppearance != null)
			{
				foreach (KeyValuePair<GiftPosition, GiftAppearance> keyValuePair in this._giftAppearanceDic)
				{
					keyValuePair.Value.RefreshAppearance(this._customAppearance, this._currentMotion);
				}
			}
			if (this._customAppearance != null)
			{
				this._customAppearance.RefreshAppearanceByMotion(this._currentMotion);
			}
		}
	}

	public void SetAltMotion(ActionDetail motion, ActionDetail altMotion)
	{
		this._altMotion[motion] = altMotion;
		if (this.GetCurrentMotionDetail() == motion)
		{
			this.ChangeMotion(altMotion);
		}
	}

	public void RemoveAltMotion(ActionDetail motion, bool changeMotion = true)
	{
		ActionDetail actionDetail;
		if (this._altMotion.TryGetValue(motion, out actionDetail))
		{
			this._altMotion.Remove(motion);
			if (changeMotion && this.GetCurrentMotionDetail() == actionDetail)
			{
				this.ChangeMotion(motion);
			}
		}
	}

	public Coroutine ChangeColor(Color c, float speed = 1f, Action callback = null)
	{
		if (base.gameObject.activeInHierarchy)
		{
			if (this._imgColorRoutine != null)
			{
				base.StopCoroutine(this._imgColorRoutine);
			}
			this._imgColorRoutine = base.StartCoroutine(this.ChangeColorRoutine(this._curSpriteColor, c, speed, callback));
			return this._imgColorRoutine;
		}
		return null;
	}

	public void RefreshAppearanceByGifts()
	{
		bool flag = false;
		bool flag2 = false;
		if (this._giftAppearanceDic.ContainsKey(GiftPosition.Helmet))
		{
			flag = this._giftAppearanceDic[GiftPosition.Helmet].IsShow;
		}
		if (this._giftAppearanceDic.ContainsKey(GiftPosition.Hood))
		{
			flag2 = this._giftAppearanceDic[GiftPosition.Hood].IsShow;
		}
		if (this._giftAppearanceDic.ContainsKey(GiftPosition.Mask))
		{
			bool isShow = this._giftAppearanceDic[GiftPosition.Mask].IsShow;
		}
		bool flag3 = flag;
		bool flag4 = flag;
		bool flag5 = flag || flag2;
		if (this._customAppearance != null)
		{
			this._customAppearance.SetSpriteByGift(CharacterAppearanceType.Head, !flag3);
			this._customAppearance.SetSpriteByGift(CharacterAppearanceType.FrontHair, !flag4);
			this._customAppearance.SetSpriteByGift(CharacterAppearanceType.RearHair, !flag5);
		}
	}

	protected IEnumerator ChangeColorRoutine(Color src, Color dst, float speed = 1f, Action callback = null)
	{
		float e = 0f;
		while (e < 1f)
		{
			e += Time.deltaTime * 4f * speed;
			foreach (KeyValuePair<ActionDetail, CharacterMotion> keyValuePair in this._characterMotionDic)
			{
				List<SpriteSet> motionSpriteSet = keyValuePair.Value.motionSpriteSet;
				for (int i = 0; i < motionSpriteSet.Count; i++)
				{
					if (motionSpriteSet[i].sprType == CharacterAppearanceType.Skin)
					{
						motionSpriteSet[i].sprRenderer.color = Color.Lerp(src, (dst == Color.grey) ? (Color.grey * this._curSkinColor) : this._curSkinColor, e);
					}
					else
					{
						motionSpriteSet[i].sprRenderer.color = Color.Lerp(src, dst, e);
					}
				}
			}
			yield return YieldCache.waitFrame;
		}
		this._curSpriteColor = dst;
		if (callback != null)
		{
			callback();
		}
		yield break;
	}

	protected virtual void Awake()
	{
	}

	public virtual void Initialize(string resourceName)
	{
		if (this._initialized)
		{
			return;
		}
		this._initialized = true;
		this._resourceName = resourceName;
		this._soundInfo = base.GetComponent<CharacterSound>();
		if (this._motionList.Count > 0)
		{
			foreach (CharacterMotion characterMotion in this._motionList)
			{
				if (!this._characterMotionDic.ContainsKey(characterMotion.actionDetail))
				{
					this._characterMotionDic.Add(characterMotion.actionDetail, characterMotion);
				}
				characterMotion.gameObject.SetActive(false);
			}
		}
	}

	public void AddOnCharMotionChanged(CharacterAppearance.OnCharMotionChanged method)
	{
		try
		{
			this._onCharMotionChanged = (CharacterAppearance.OnCharMotionChanged)Delegate.Combine(this._onCharMotionChanged, method);
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void RemoveOnCharMotionChanged(CharacterAppearance.OnCharMotionChanged method)
	{
		try
		{
			this._onCharMotionChanged = (CharacterAppearance.OnCharMotionChanged)Delegate.Remove(this._onCharMotionChanged, method);
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	[Serializable]
	public class MotionPivot
	{
		public ActionDetail motion;

		public Transform pivot;
	}

	public delegate void OnCharMotionChanged();
}
