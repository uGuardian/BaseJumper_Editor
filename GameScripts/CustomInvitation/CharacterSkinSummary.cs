﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CharacterSkinSummary : MonoBehaviour
	{
		[SerializeField]
		private Toggle _artworkToggle;

		[SerializeField]
		private Text _artworkNameText;

		private string _fullPath;

		private Texture2D _texture;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(string fullpath, ToggleGroup toggleGroup, Action<string> toggleCallback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSkinSummary()
		{
			throw null;
		}
	}
}
