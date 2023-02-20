using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent(typeof(CanvasGroup))]
	public class UICustomGraphicObject : MonoBehaviour
	{
		private bool _interactable;

		public GraphicBundle graphics;

		public TextMeshProMaterialSetter MS_underlay;

		public bool istextunderlayalpha;

		public UICustomSelectable selectable;

		public List<GameObject> HighlightObjects;

		[Header("ExtraOption")]
		public bool useSpecialColor;

		public Color specialColor;

		public bool useHighlightedColor;

		public Color highlightedSpecialColor;

		[Header("AutoSizeOption")]
		public bool useAutoSize;

		public TextMeshProUGUI size_text;

		public List<Image> size_images;

		public float minimumWidth;

		[Header("Highlihgted ChangeImage")]
		public bool useChangeImage;

		public Image img_changetarget;

		public Sprite sp_normal;

		public Sprite sp_highlihgted;

		public bool interactable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDisabled()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomGraphicObject()
		{
			throw null;
		}
	}
}
