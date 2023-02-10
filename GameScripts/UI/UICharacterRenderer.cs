using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICharacterRenderer : SingletonBehavior<UICharacterRenderer>
	{
		public List<Camera> cameraList;

		public List<UICharacter> characterList;

		public List<UnitDataModel> currentDataList;

		public Camera customizeCamera;

		public Camera informationCamera;

		public RenderTexture rt;

		public Transform characterRoot;

		public const int maxCharNum = 11;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCharacter(UnitDataModel unit, int index, bool forcelyReload = false, bool renderRealtime = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RenderCam(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReloadCharacter(UnitDataModel unit)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUpdateCharacterGift(UnitDataModel unit)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture GetRenderTextureByIndex(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture GetRenderTextureByIndexAndSize(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTextureSize(int idx, int size)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTextureSize(UnitDataModel unit, int size)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacter GetUICharacterByIndex(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Redraw(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyCharacters()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveCam(bool on, int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterRenderer()
		{
			throw null;
		}
	}
}
