using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DropBookSummary : MonoBehaviour
	{
		[SerializeField]
		private Text _textDropBookID;

		[SerializeField]
		private Text _textDropBookName;

		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Image _chapterImg;

		[SerializeField]
		private Image _chapterBgImg;

		private int _dropBookID;

		public int dropBookID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<DropBookSummary> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDropBookInfo(DropBookXmlInfo data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookSummary()
		{
			throw null;
		}
	}
}
