using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ActionText : MonoBehaviour
{
	public float typoFadeoutSpeed;

	public float typoRotationAngle;

	private TextMeshProUGUI _tm;

	private Material _mat;

	private BattleUnitView _view;

	[SerializeField]
	private AnimationCurve _alphaCurve;

	[SerializeField]
	[Range(1f, 5f)]
	private float _typoFadeoutSpeedRange;

	[SerializeField]
	private float _typoRotationAngleRange;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(string text, BattleUnitView view, ActionTextMode mode = ActionTextMode.None)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator Appear()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOut(bool moveY = true, float fadeSpeed = 1f)
	{
		throw null;
	}
}
