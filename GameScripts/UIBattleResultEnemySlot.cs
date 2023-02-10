using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIBattleResultEnemySlot : MonoBehaviour
{
	public GameObject root;

	public Image EnermyPortrait;

	public GameObject KilledMark;

	public RectTransform rect_killedMark;

	[Header("Anim")]
	[SerializeField]
	private Animator anim;

	[SerializeField]
	private CanvasGroup cg;

	public Vector2 originPos;

	private float vibescale;

	private float vibeperiod;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnemy(UnitBattleDataModel data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartReveal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHideDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRevealDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartVibe()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibeProcess()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIBattleResultEnemySlot()
	{
		throw null;
	}
}
