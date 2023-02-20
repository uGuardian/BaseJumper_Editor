using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TheClawTeleportAtk : MonoBehaviour
{
	[SerializeField]
	private GameObject _teleportEffectRes;

	[SerializeField]
	private AudioClip _teleportSound;

	[SerializeField]
	private AnimationCurve _teleportCurve;

	[SerializeField]
	private float _teleportTime;

	[SerializeField]
	private float _teleportSpeed;

	[SerializeField]
	private AnimationCurve _atkCurve;

	[SerializeField]
	private float _atkTime;

	[SerializeField]
	private float _atkSpeed;

	private float _elapsedTeleportBack;

	private float _elapsedAtk;

	private BattleUnitView _selfView;

	private BattleUnitView _targetView;

	public TheClawTeleportAtk.Phase phase
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitView self, BattleUnitView target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator TeleportRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTeleport()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TheClawTeleportAtk()
	{
		throw null;
	}

	public enum Phase
	{
		TeleportBack,
		Attack,
		None
	}
}
