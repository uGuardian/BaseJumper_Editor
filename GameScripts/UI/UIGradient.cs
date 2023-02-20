﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[AddComponentMenu("UI/Effects/Gradient")]
	public class UIGradient : BaseMeshEffect
	{
		public Color m_color1;

		public Color m_color2;

		[Range(-180f, 180f)]
		public float m_angle;

		public bool m_ignoreRatio;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ModifyMesh(VertexHelper vh)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGradient()
		{
			throw null;
		}
	}
}
