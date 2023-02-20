using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace HyperCard
{
	[Serializable]
	public class CustomTextComponent : CardComponent
	{
		[SerializeField]
		public TMP_FontAsset FontAsset;

		[SerializeField]
		public Material FontMaterial;

		[SerializeField]
		public bool IsActive;

		[SerializeField]
		public string Key;

		[SerializeField]
		public TextMeshPro TmpObject;

		[SerializeField]
		private string _value;

		[SerializeField]
		public TextMeshProParamDisplayMode DisplayMode;

		[SerializeField]
		public TextSide TextSide;

		public string Value
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
		public virtual void Compute()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IEnumerator UpdateMaterial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomTextComponent()
		{
			throw null;
		}
	}
}
