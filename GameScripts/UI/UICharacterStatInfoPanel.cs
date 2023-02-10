using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICharacterStatInfoPanel : MonoBehaviour
	{
		[Header("Normal Text")]
		public TextMeshProUGUI hpText;

		public TextMeshProUGUI breakText;

		public TextMeshProUGUI emotionText;

		public TextMeshProUGUI speedDiceText;

		public TextMeshProUGUI speedDiceNumText;

		public TextMeshProUGUI playpointText;

		public TextMeshProUGUI resistSlash;

		public TextMeshProUGUI resistPentrate;

		public TextMeshProUGUI resistHit;

		public TextMeshProUGUI resistBreakSlash;

		public TextMeshProUGUI resistBreakPentrate;

		public TextMeshProUGUI resistBreakHit;

		[Header("Preview")]
		public TextMeshProUGUI hptext_preview;

		public TextMeshProUGUI breakText_preview;

		public TextMeshProUGUI emotionText_preview;

		public TextMeshProUGUI speedDiceText_preview;

		public TextMeshProUGUI speedDiceNumText_preview;

		public TextMeshProUGUI playpointText_preview;

		[SerializeField]
		private List<Graphic> targets;

		[SerializeField]
		private TextMeshProUGUI txt_abilitytitle;

		public float processSpeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataCalculated(UnitDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetEmpty()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnknown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPreviewData(BookModel originlevelbook, BookModel nextlevelbook)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPreviewDataAfterFeedBook(BookModel originlevelbook, BookModel nextlevelbook)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStopCoroutineDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ChangeAbilityProcess(BookModel originlevelbook, BookModel nextlevelbook)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffPreview()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFramesColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterStatInfoPanel()
		{
			throw null;
		}
	}
}
