using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UITextDataLoader : MonoBehaviour
	{
		[SerializeField]
		private FontType fontType;

		private Text ugui_text;

		private TextMeshProUGUI ugui_tmpro;

		[Header("key")]
		public string key;

		private TMP_FontAsset _defaultFont;

		private TextMeshProMaterialSetter _matSetter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetText()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITextDataLoader()
		{
			throw null;
		}
	}
}
