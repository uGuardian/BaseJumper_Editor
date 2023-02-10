﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CustomizedAppearance : MonoBehaviour
{
	public List<SpriteRenderer> allSpriteList;

	[SerializeField]
	protected SpriteRenderer[] face;

	[SerializeField]
	protected SpriteRenderer[] brow;

	[SerializeField]
	protected SpriteRenderer[] mouth;

	[SerializeField]
	protected SpriteRenderer[] head;

	[SerializeField]
	protected SpriteRenderer[] frontHair;

	[SerializeField]
	protected SpriteRenderer[] backHair;

	[SerializeField]
	protected CustomizedAppearance.GiftPivot pivots;

	private UnitCustomizingData _customData;

	private FaceResourceSet _eyeRousources;

	private FaceResourceSet _browRousources;

	private FaceResourceSet _mouthRousources;

	protected float _scaleFactor;

	protected CharacterAppearance _appearance;

	protected CustomizedAppearance.OnRefreshAppearance _onRefreshAppearance;

	public CharacterAppearance appearance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRefreshEvent(CustomizedAppearance.OnRefreshAppearance e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearRefreshEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangeLayer(string layerName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetOriginalColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetColor(Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCustomData(UnitCustomizingData data, CharacterAppearance appearance)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetScaleFactor(float scale)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RefreshAppearanceByMotion(CharacterMotion motion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSpriteByGift(CharacterAppearanceType appearanceType, bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetRendererOrder(CharacterAppearanceType type, ActionDetail motion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizedAppearance()
	{
		throw null;
	}

	[Serializable]
	public class GiftPivot
	{
		public GiftPosition giftPos;

		public Transform pivot;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GiftPivot()
		{
			throw null;
		}
	}

	public delegate void OnRefreshAppearance(CustomizedAppearance appearance);
}
