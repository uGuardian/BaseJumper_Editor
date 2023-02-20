using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageCharacterSkinPopupSetter : MonoBehaviour
	{
		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Toggle _toggleViewLorSkin;

		[SerializeField]
		private Toggle _toggleViewCustomSkin;

		[SerializeField]
		private LorCharacterListViewer _lorCharacterViewer;

		[SerializeField]
		private CustomCharacterListViewer _customCharacterViewer;

		[SerializeField]
		private RawImage _previewTexture;

		[SerializeField]
		private Image _previewBg;

		[SerializeField]
		private Texture2D _defaultPreviewTex;

		[SerializeField]
		private Slider _slider;

		private Action<Texture, string, string> _callback;

		private string _skinType;

		private string _skinName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenSkinSetterWindow(Action<Texture, string, string> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewCustomTab(bool isOn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewLorTab(bool isOn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectLorCharacterSkin(object data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectCustomCharacterSkin(object data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangePreviewBgColor(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneSkinSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelSkinSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSkinInfo(string skinName, string skinType)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageCharacterSkinPopupSetter()
		{
			throw null;
		}
	}
}
