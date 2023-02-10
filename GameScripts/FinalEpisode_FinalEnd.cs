using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FinalEpisode_FinalEnd : MonoBehaviour
{
	[SerializeField]
	private AudioClip _dustEndSound;

	[SerializeField]
	private AudioClip _arbitorLeaveSound;

	[SerializeField]
	private AudioClip _clawLeaveSound;

	private float _elapsedTime;

	private const float teleportStartTime = 1f;

	private const float offStartTime = 2f;

	private const float destoryTime = 3.5f;

	private Action _callback;

	private EnemyTeamStageManager_FinalFinal _stageManager;

	private string _arbitorEffect;

	private string _clawEffect;

	private string _dustEffect;

	private bool _teleported;

	private bool _off;

	private GameObject _dust;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Action completeCallback, EnemyTeamStageManager_FinalFinal stageManager)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Teleport()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Off()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_FinalEnd()
	{
		throw null;
	}
}
