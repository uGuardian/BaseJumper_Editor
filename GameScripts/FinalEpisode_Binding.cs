using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FinalEpisode_Binding : MonoBehaviour
{
	[SerializeField]
	private float _teleportDelay;

	[SerializeField]
	private float _penetrateDelay;

	[SerializeField]
	private float _grabDelay;

	[SerializeField]
	private GameObject _lockEffectRes;

	[SerializeField]
	private AudioClip _lockSound;

	[SerializeField]
	private GameObject _teleportEffectRes;

	[SerializeField]
	private AudioClip _teleportSound;

	[SerializeField]
	private float _destroyTime;

	private float _elapsedTime;

	private Action _callback;

	public static GameObject lockEffect;

	private BattleUnitModel _roland;

	private BattleUnitModel _gebura;

	private BattleUnitModel _theClaw;

	private BattleUnitModel _theHead;

	private FinalEpisode_Binding.ClawPhase _clawPhase;

	private float _elapsedClawPhase;

	private bool _bEndAction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Action completeCallback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateLockEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateClaw()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClawTeleport()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClawPenetrate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClawGrab()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_Binding()
	{
		throw null;
	}

	public enum ClawPhase
	{
		Teleport,
		Atk,
		Grab,
		None
	}
}
