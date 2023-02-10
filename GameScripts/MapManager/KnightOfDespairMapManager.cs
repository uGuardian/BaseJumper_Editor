using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class KnightOfDespairMapManager : CreatureMapManager
{
	[SerializeField]
	private KnightOfDespairGroggyFilter _swordFilter;

	[SerializeField]
	private KnightOfDespairFinalGroggyFilter _finalSwordFilter;

	[SerializeField]
	private SpriteRenderer _blessFilter;

	[SerializeField]
	private AnimationCurve _blessFilterAlphaCurve;

	[SerializeField]
	private SpriteRenderer _fatalFilter;

	[Header("Runtime")]
	[SerializeField]
	private bool _bGroggy;

	[SerializeField]
	private CameraFilterPack_Broken_Screen _groggyFilter;

	private SoundEffectPlayer _fatalLoopSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBlessFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlessFilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFatalFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGroggyFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BrokenRoutine(CameraFilterPack_Broken_Screen r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStuckSwordFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStuckSworldFilterInFinal(bool b, int swordIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRunningEffect(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KnightOfDespairMapManager()
	{
		throw null;
	}
}
