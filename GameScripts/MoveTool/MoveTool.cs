using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MoveTool
{
	public class MoveTool : MonoBehaviour
	{
		public RectTransform pivot;

		public MoveToolDirection currentDirection;

		public MoveToolObject Both;

		public MoveToolObject Vertical;

		public MoveToolObject Horizontal;

		public float SpeedFactor;

		public Text positionPrinter;

		public GameObject HeadViewPivot;

		public GameObject FrontView;

		public GameObject SideView;

		public float clampValue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPosition(Vector2 pos)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDirection(int dir)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(int dir)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(int dir)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(int dir)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrag(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MoveTool()
		{
			throw null;
		}
	}
}
