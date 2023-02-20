using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CreatureDlgEffectUI : MonoBehaviour
{
	public TextMeshProUGUI m_TextComponent;

	public float AngleMultiplier;

	public float CurveScale;

	public float Freq;

	private bool hasTextChanged;

	private Coroutine _routine;

	private string _str;

	private bool _displayDone;

	private CreatureDlgEffectUI.UpdateVertexInfoEvent _vertexUpdateEvent;

	private float _elapsedDestroy;

	public bool DisplayDone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(string str, CreatureDlgEffectUI.UpdateVertexInfoEvent e = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColor(Color color)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGradientColor(Color topLeft, Color topRight, Color bottomLeft, Color bottomRight)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOut()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutWithCurAlpha()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutRoutineWithCurAlpha()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ON_TEXT_CHANGED(UnityEngine.Object obj)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DisplayStr()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator AnimateVertexColors()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureDlgEffectUI()
	{
		throw null;
	}

	public delegate void UpdateVertexInfoEvent();

	private struct VertexAnim
	{
		public float angleRange;

		public float angle;

		public float speed;
	}
}
