using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CombatPageArtworkResourceViewer : MonoBehaviour
	{
		[SerializeField]
		private CombatPageArtworkSummary _ref;

		[SerializeField]
		private Button _refreshButton;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private RawImage _previewImage;

		[SerializeField]
		private Texture2D _defaultTexture;

		[SerializeField]
		private ToggleGroup _toggleGroup;

		[Header("Runtime")]
		[SerializeField]
		private List<CombatPageArtworkSummary> _combatPageArtworkList;

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
		public void RefreshArtworks()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetArtworkPreview(Texture2D texture)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleArtworkSummary(string fullPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPageArtworkResourceViewer()
		{
			throw null;
		}
	}
}
