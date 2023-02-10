using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UITooltipDataLoader : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[SerializeField]
		private UIToolTipType type;

		[SerializeField]
		private string id;

		[SerializeField]
		private string param;

		[HideInInspector]
		public bool ison;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExitFunc()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITooltipDataLoader()
		{
			throw null;
		}
	}
}
