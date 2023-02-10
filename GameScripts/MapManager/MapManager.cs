using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MapManager : MonoBehaviour
{
	public bool isActivated;

	public bool isEnabled;

	public MapSize mapSize;

	public bool isCreature;

	public bool isBossPhase;

	[NonSerialized]
	public bool isEgo;

	public AudioClip[] mapBgm;

	[Tooltip("Sephirah type of floor.")]
	public SephirahType sephirahType;

	[Tooltip("Map border sprites root object.")]
	public GameObject borderFrame;

	[Tooltip("Backgrounds' root object.")]
	public GameObject backgroundRoot;

	[Tooltip("Background Cam Vignette Color")]
	public Color sephirahColor;

	protected bool _bRunningEffect;

	[SerializeField]
	[Tooltip("종류별 오브젝트의 루트. 맵을 끄거나 켤 때 사용")]
	private GameObject[] _roots;

	[SerializeField]
	[Tooltip("맵에 배치된 충돌가능한 오브젝트들의 루트")]
	private Transform _obstacleRoot;

	public GameObject[] scratchPrefabs;

	public GameObject[] wallCratersPrefabs;

	protected BattleMapObstacleCollider[] _obstacles;

	protected bool _bMapInitialized;

	protected List<GameObject> _scratchList;

	private float _elapsedStopRunningEffect;

	private float _stopRunningEffectDelay;

	private bool _bStopRunningEffectForcely;

	public bool IsRunningEffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsMapInitialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GameObject[] GetRoots()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndRunningStateForcely(float delay)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetRunningState(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActiveMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayMapChangedSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnableMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject GetScratch(int lv, Transform parent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject GetWallCrater()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartRollSpeedDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartUnitMoving()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterCheckMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReviseFilterTransform(SpriteRenderer r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReviseTransform(Transform t, float stdScaleFactor = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DestroyObject(GameObject go)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapManager()
	{
		throw null;
	}
}
