using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIInvitationRightBlueEffectScript : MonoBehaviour
	{
		[SerializeField]
		private RectTransform rect;

		[SerializeField]
		private CanvasGroup cg;

		[Range(0.1f, 20f)]
		public float vibespeed;

		private int framecount;

		[Range(1f, 360f)]
		public int frame;

		public float alphaMin;

		public float alphaMax;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationRightBlueEffectScript()
		{
			throw null;
		}
	}
}
