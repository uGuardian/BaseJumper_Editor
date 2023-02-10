using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HyperCard
{
	[Serializable]
	public class CardProperties
	{
		public Card Card;

		[SerializeField]
		public int Id;

		[SerializeField]
		public int Stencil;

		[SerializeField]
		public int RenderQueue;

		[SerializeField]
		public int Seed;

		[SerializeField]
		public float Opacity;

		[SerializeField]
		public Shader SideShader;

		[SerializeField]
		public GameObject SpritePrefab;

		[SerializeField]
		public List<CustomTextComponent> CustomTextList;

		[SerializeField]
		public List<CustomSpriteComponent> CustomSpriteList;

		[SerializeField]
		public CardSide FaceSide;

		[SerializeField]
		public CardSide BackSide;

		[SerializeField]
		public bool IsOutlineEnabled;

		[SerializeField]
		public float OutlineWidth;

		[SerializeField]
		public float OutlineHeight;

		[SerializeField]
		public float OutlineSmoothness;

		[SerializeField]
		public float OutlineSmoothSpeed;

		[SerializeField]
		public float OutlineTrimOffset;

		[SerializeField]
		public Vector2 OutlinePosOffset;

		[SerializeField]
		public Color OutlineStartColor;

		[SerializeField]
		public Color OutlineEndColor;

		[SerializeField]
		public float OutlineEndColorDistance;

		[SerializeField]
		public float OutlineColorExposure;

		[SerializeField]
		public float OutlineNoiseFrequency;

		[SerializeField]
		public float OutlineNoiseSpeed;

		[SerializeField]
		public float OutlineNoiseMult;

		[SerializeField]
		public float OutlineNoiseOffset;

		[SerializeField]
		public float OutlineNoiseThreshold;

		[SerializeField]
		public float OutlineNoiseDistance;

		[SerializeField]
		public float OutlineNoiseVerticalAjust;

		[SerializeField]
		public bool IsDissolveEnabled;

		[SerializeField]
		public float DissolveNoiseFrequency;

		[SerializeField]
		public float DissolveAmount;

		[SerializeField]
		public float DissolveRotateSpeed;

		[SerializeField]
		public float DissolveOutline;

		[SerializeField]
		public Color DissolveStartColor;

		[SerializeField]
		public Color DissolveEndColor;

		[SerializeField]
		public float DissolveColorExposure;

		[SerializeField]
		public float DissolveAlphaCut;

		[SerializeField]
		public bool BlackAndWhite;

		[SerializeField]
		public bool UseFullscreenCanvas;

		[SerializeField]
		public bool CCGKitMode;

		[SerializeField]
		public bool UseSortingGroups;

		[SerializeField]
		public bool UseCollection;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardProperties(Card card)
		{
			throw null;
		}
	}
}
