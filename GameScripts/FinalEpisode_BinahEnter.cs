using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FinalEpisode_BinahEnter : MonoBehaviour
{
	[SerializeField]
	private GameObject _teleportEffectRes;

	[SerializeField]
	private AudioClip _teleportSound;

	[SerializeField]
	private AudioClip _shockWaveSound;

	[SerializeField]
	private GameObject _shockWaveDamagedEffectRes;

	[SerializeField]
	private float _destoryTime;

	[SerializeField]
	private GameObject _destroyLockEffectRes;

	[SerializeField]
	private AudioClip _destroyLockSound;

	private float _elapsedDestroy;

	private Action _callback;

	private BattleUnitModel _binah;

	private BattleUnitModel _theClaw;

	private BattleUnitModel _theHead;

	private BattleUnitModel _roland;

	private BattleUnitModel _gebura;

	private float _elapsed;

	private FinalEpisode_BinahEnter.Phase _phase;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Action completeCallback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShockWave()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClawTeleport()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_BinahEnter()
	{
		throw null;
	}

	public enum Phase
	{
		Damage,
		ClawTeleport,
		None
	}
}
