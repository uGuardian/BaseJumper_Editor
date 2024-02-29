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

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetRunningState(bool b)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeMap()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMap()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActiveMap(bool b)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayMapChangedSound()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnableMap(bool b)
	{

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

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartUnitMoving()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundStart()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterCheckMap()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEnd()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LateUpdate()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FixedUpdate()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReviseFilterTransform(SpriteRenderer r)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReviseTransform(Transform t, float stdScaleFactor = 1f)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWaveStart()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEndTheLast()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DestroyObject(GameObject go)
	{

	}
}
