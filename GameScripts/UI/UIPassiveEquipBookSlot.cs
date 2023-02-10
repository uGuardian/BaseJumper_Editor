using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveEquipBookSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private CanvasGroup cg_DataRoot;

		[SerializeField]
		private TextMeshProUGUI txt_BookName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_txtbookname;

		[SerializeField]
		private GameObject ob_Icon;

		[SerializeField]
		private Image img_Icon;

		[SerializeField]
		private Image img_IconGlow;

		private BookModel bookmodel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRarityColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveEquipBookSlot()
		{
			throw null;
		}
	}
}
