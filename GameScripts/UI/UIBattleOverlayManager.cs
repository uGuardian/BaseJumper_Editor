﻿using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleOverlayManager : SingletonBehavior<UIBattleOverlayManager>
	{
		private GameObject overdata;

		public GameObject BufActiveRoot;

		public Canvas BufCanvas;

		public RectTransform BufPositionPivot;

		public RectTransform BufSizePivot;

		public TextMeshProUGUI BufName;

		public TextMeshProUGUI BufDesc;

		public Image BufIcon;

		private Vector2 _curSize;

		private Vector2 _rightDownPivot;

		public EventSystem eventsystem;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected UIBattleOverlayManager()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableBufOverlay(string name, string desc, Sprite bufIcon, Camera camera, RectTransform rectTransform, GameObject ob)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableBufOverlay(string name, string desc, Sprite bufIcon, GameObject data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBufOverlayBoxPosition(Camera cam, RectTransform targeTranseForm)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBufOverlayBoxPosition()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBufOverlayBoxSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableOverlay()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			throw null;
		}
	}
}
