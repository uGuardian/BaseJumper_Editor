using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageSummary : MonoBehaviour
	{
		[SerializeField]
		private Text _textKeyPageId;

		[SerializeField]
		private Text _textKeyPageName;

		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Image _chapterImg;

		[SerializeField]
		private Image _chapterBgImg;

		private int _keyPageID;

		public string keyPageName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int keyPageID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<KeyPageSummary> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetKeyPageInfo(BookXmlInfo xmlInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageSummary()
		{
			throw null;
		}
	}
}
