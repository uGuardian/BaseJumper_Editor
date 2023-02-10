using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterAppearance : MonoBehaviour
{
	private static GiftPosition[] AllGiftPosition;

	public float customHeadScaleFactor;

	[SerializeField]
	private bool _customizable;

	[HideInInspector]
	public bool isActionCharacter;

	[HideInInspector]
	public int bookID;

	[HideInInspector]
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

	[HideInInspector]
	[SerializeField]
	private CustomizedAppearance _customAppearance;

	private Dictionary<GiftPosition, GiftAppearance> _giftAppearanceDic;

	protected Dictionary<ActionDetail, CharacterMotion> _characterMotionDic;

	protected CharacterMotion _currentMotion;

	protected string _layerName;

	protected Coroutine _imgColorRoutine;

	protected Color _curSpriteColor;

	protected Color _curSkinColor;

	protected CharacterSound _soundInfo;

	protected bool _initialized;

	private string _resourceName;

	private CharacterAppearance.OnCharMotionChanged _onCharMotionChanged;

	private List<CharacterBloodSpriteEffect> _bloodSpriteList;

	public List<GameObject> _addedChildren;

	protected Dictionary<ActionDetail, ActionDetail> _altMotion;

	public Transform cameraPivot;

	public CharacterSound soundInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool isCustomizable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public IDictionary<ActionDetail, CharacterMotion> CharacterMotions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Color CurSpritesColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CustomizedAppearance CustomAppearance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Dictionary<GiftPosition, GiftAppearance> GiftAppearances
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string resourceName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform GetAtkEffectPivot(ActionDetail action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform GetSpecialMotionPivot(ActionDetail motion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetList(List<CharacterMotion> m)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChild(GameObject go)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterMotion GetCharacterMotion(ActionDetail action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCustomData(UnitCustomizingData customizeData, LorId defaultBookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGiftDataAll(List<GiftModel> equippedGiftList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GiftAppearance CreateGiftData(GiftModel gift, string resPath)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitGiftData(GiftModel gift, bool refreshAppearance = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftAppearance SetTemporaryGift(string resPath, GiftPosition position, bool refreshAppearance = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetDamagedSprite(int dmg, float curHp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ClearDamagedSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetLibrarianOnlySprites(Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ActionDetail GetCurrentMotionDetail()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterMotion GetCurrentMotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLayerName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeLayer(string layerName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangeMotion(ActionDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAltMotion(ActionDetail motion, ActionDetail altMotion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAltMotion(ActionDetail motion, bool changeMotion = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Coroutine ChangeColor(Color c, float speed = 1f, Action callback = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshAppearanceByGifts()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected IEnumerator ChangeColorRoutine(Color src, Color dst, float speed = 1f, Action callback = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize(string resourceName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOnCharMotionChanged(CharacterAppearance.OnCharMotionChanged method)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveOnCharMotionChanged(CharacterAppearance.OnCharMotionChanged method)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterAppearance()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CharacterAppearance()
	{
		throw null;
	}

	[Serializable]
	public class MotionPivot
	{
		public ActionDetail motion;

		public Transform pivot;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MotionPivot()
		{
			throw null;
		}
	}

	public delegate void OnCharMotionChanged();
}
