using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GiftAppearance : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	protected SpriteRenderer _frontSpriteRenderer;

	[SerializeField]
	protected SpriteRenderer _frontBackSpriteRenderer;

	[SerializeField]
	protected SpriteRenderer _sideSpriteRenderer;

	[SerializeField]
	protected SpriteRenderer _sideBackSpriteRenderer;

	[SerializeField]
	protected Animator _animator;

	[Space]
	[Header("Runtime")]
	[SerializeField]
	protected GiftPosition _giftType;

	protected GiftModel _giftModel;

	[NonSerialized]
	private string _resName;

	public int GiftID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string GiftName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsShow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string ResourceName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResourceName(string resName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColor(Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RefreshAppearance(CustomizedAppearance customized, CharacterMotion motion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSortingOrder(int order)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GiftModel gift, string layer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetLayer(string layerName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<SpriteRenderer> GetSpriteRenderers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftPosition GetGiftType()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetGiftPreview()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftAppearance()
	{
		throw null;
	}
}
