using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIGiftDataSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private TextMeshProUGUI txt_giftName;

		[Header("Reference")]
		[SerializeField]
		private TextMeshProUGUI txt_giftNameDetail;

		[Header("Reference")]
		[SerializeField]
		private TextMeshProUGUI txt_giftPartName;

		[SerializeField]
		private Image img_giftImage;

		[SerializeField]
		private Image img_giftMask;

		[SerializeField]
		private Image img_xmark;

		[SerializeField]
		private Image[] img_Frames;

		private bool isEmpty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActivated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(GiftModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGiftDataSlot()
		{
			throw null;
		}
	}
}
