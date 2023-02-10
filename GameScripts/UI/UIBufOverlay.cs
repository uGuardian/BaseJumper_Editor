using System;
using System.Runtime.CompilerServices;
using LOR_XML;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent(typeof(Image))]
	public class UIBufOverlay : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IDragHandler
	{
		private Image _image;

		private const string _emptyText = "";

		private string _name;

		private string _description;

		private Sprite _icon;

		private BattleEffectText _battleEffectText;

		private AbnormalityCard _cardText;

		private Camera _camera;

		[Header("check Information Direction In Inspector ")]
		[SerializeField]
		private bool isInformationRight;

		private Image Image
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDescription()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetSprite()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCamera(Camera camera)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetName(string name)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDescription(string description)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIcon(Sprite icon)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDescription(AbnormalityCard abnormalityCard)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData pData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData pData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPdSelect(BaseEventData pData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPdDeselect(BaseEventData pData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrag(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBufOverlay()
		{
			throw null;
		}
	}
}
