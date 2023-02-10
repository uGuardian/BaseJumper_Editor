using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIBattleOverlayManager_Card : SingletonBehavior<UIBattleOverlayManager_Card>
	{
		private GameObject overdata;

		public GameObject BufActiveRoot;

		public Canvas BufCanvas;

		public RectTransform BufPositionPivot;

		public RectTransform BufSizePivot;

		public TextMeshProUGUI BufDesc;

		private Vector2 _curSize;

		private Vector2 _rightDownPivot;

		public EventSystem eventsystem;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected UIBattleOverlayManager_Card()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableCardBufOverlay(string desc, GameObject data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetCardBufOverlayBoxPosition()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetCardBufOverlayBoxSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableOverlay()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}
	}
}
