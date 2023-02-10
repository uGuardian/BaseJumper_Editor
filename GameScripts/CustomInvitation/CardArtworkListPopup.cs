using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CardArtworkListPopup : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private CombatPageArtworkSummary _ref;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private RawImage _previewImage;

		[SerializeField]
		private Texture2D _defaultTexture;

		[SerializeField]
		private ToggleGroup _toggleGroup;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Button _refreshButton;

		[Header("Runtime")]
		[SerializeField]
		private List<CombatPageArtworkSummary> _combatPageArtworkList;

		private Action<string> _callback;

		private CombatPageArtworkSummary _selectedArtwork;

		private bool _init;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenPopup(Action<string> callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate(bool enable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitArtworks()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshArtworkResources()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneArtworkSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelArtworkSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleArtworkSummary(CombatPageArtworkSummary summary)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardArtworkListPopup()
		{
			throw null;
		}
	}
}
