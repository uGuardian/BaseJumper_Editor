using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class AbnormalityDlgEffect : MonoBehaviour
{
	public float AngleMultiplier;

	public float SpeedMultiplier;

	public float CurveScale;

	private TMP_Text m_TextComponent;

	private bool hasTextChanged;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ON_TEXT_CHANGED(UnityEngine.Object obj)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator AnimateVertex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEffect()
	{

	}

	private struct VertexAnim
	{
		public float angleRange;

		public float angle;

		public float speed;
	}
}
