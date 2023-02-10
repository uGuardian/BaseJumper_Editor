using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleEmotionCoinUI : MonoBehaviour
{
	[Header("Tests")]
	public float inverseHeight;

	public RectTransform _testRect;

	public RectTransform _testTarget;

	public GameObject _testObj;

	[SerializeField]
	private GetEmotionTypo _acquisitionTextPrefab;

	[Header("Attributes")]
	public AnimationCurve SinCurve;

	public AnimationCurve EncounterCurve;

	public AnimationCurve CosCurve;

	[Range(0.01f, 10f)]
	public float transitionTime;

	public GameObject CoinSlotReference;

	public Transform CoinSlotParent;

	public BattleEmotionCoinUI.BattleEmotionCoinData[] librarian;

	public BattleEmotionCoinUI.BattleEmotionCoinData[] enermy;

	public float adjustHeight;

	public float adjustVertical;

	public Camera pivotCamera;

	public float CameraFactor;

	public float delayTime;

	private bool _init;

	private Dictionary<int, BattleEmotionCoinUI.BattleEmotionCoinData> _librarian_lib;

	private Dictionary<int, BattleEmotionCoinUI.BattleEmotionCoinData> _enemy_lib;

	private Dictionary<int, Queue<EmotionCoinType>> _lib_queue;

	private Dictionary<int, Queue<EmotionCoinType>> _ene_queue;

	private float elapsed;

	public Canvas pivotCanvas
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Acquisition(BattleUnitModel unit, Vector3 unitWorldPosition, bool positive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleEmotionCoinUI.BattleEmotionCoinData GetCoinData(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Test_Gen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TestShoot()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TestPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AppearTest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Test(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAcquireCoin(BattleUnitModel unit, EmotionCoinType coinType, int count)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator Moving(Vector2 startPos, Vector2 targetPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckGeneration()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionCoinUI()
	{
		throw null;
	}

	[Serializable]
	public class BattleEmotionCoinData
	{
		public float cosFactor;

		public float sinFactor;

		public RectTransform target;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleEmotionCoinData()
		{
			throw null;
		}
	}
}
