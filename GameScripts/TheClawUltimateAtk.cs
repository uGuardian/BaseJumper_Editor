using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class TheClawUltimateAtk : MonoBehaviour
{
	[Header("텔레포트")]
	[SerializeField]
	private GameObject _teleportEffectRes;

	[SerializeField]
	private AudioClip _teleportSound;

	[Header("돌진 트레일")]
	[SerializeField]
	private GameObject _chargeEffect;

	[Header("뚫린 벽")]
	[SerializeField]
	private GameObject _wallLoopEffect;

	[SerializeField]
	private GameObject _wallStartEffect;

	[SerializeField]
	private GameObject _wallEndEffect;

	[SerializeField]
	private AnimationCurve _moveToWallCurve;

	[Header("배경")]
	[SerializeField]
	private Sprite[] _spriteResAry;

	[SerializeField]
	private SpriteRenderer _bgSpriteRoot;

	[SerializeField]
	private SpriteRenderer _bgRendererNext;

	[SerializeField]
	private SpriteRenderer _bgRendererCur;

	[SerializeField]
	private AnimationCurve _bgMovingCurve;

	[SerializeField]
	private float _bgSpriteScaleFactor;

	[SerializeField]
	private GameObject _chargeBgEffect;

	[Header("피격 이펙트")]
	[SerializeField]
	private GameObject _damagedEffect;

	[Header("컷씬 이펙트")]
	[SerializeField]
	private GameObject _cutSceneEffect;

	[SerializeField]
	private UIAnimationEventHandler _cutSceneHandler;

	[Header("딜레이")]
	[SerializeField]
	private float _changeBgDelay;

	[SerializeField]
	private float _grabDelay;

	[SerializeField]
	private float _moveToWallDelay;

	[SerializeField]
	private float _moveToWallSpeed;

	[SerializeField]
	private float _chargeDelay;

	[SerializeField]
	private float _penetrateDelay;

	[Header("사운드")]
	[SerializeField]
	private AudioClip _grabSound;

	[SerializeField]
	private AudioClip _createWallSound;

	[SerializeField]
	private AudioClip _cutSceneSound;

	[SerializeField]
	private AudioClip _damagedSound;

	private BattleUnitView _selfView;

	private BattleUnitView _targetView;

	private int _spriteIdx;

	private float _elapsedChangeBg;

	private float _elapsedGrabThroat;

	private float _elapsedCreateWall;

	private float _elapsedSpecialCharge;

	private float _elapsedPenetrate;

	private float _elapsedEnd;

	private bool _bInitBg;

	private bool _bChargeEnd;

	private CameraFilterPack_FX_EarthQuake _earthQuakeFilter;

	private Direction _chargeDirection;

	private Vector3 _moveToWallTargetSrc;

	private Vector3 _moveToWallTargetDst;

	private Vector3 _moveToWallSelfSrc;

	private Vector3 _moveToWallSelfDst;

	private Vector3 _selfChargeStartPos;

	private Vector3 _targetChargeStartPos;

	private Vector3 _chargeOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitView self, BattleUnitView target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual_GrabThroat(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual_CreateWall(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual_SpecialCharge(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual_Penetrate(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual_End(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitTeleportEffect()
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
	private void OnBgOff()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnChargeEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSpecialCharge()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateBg(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ZoomCamera(float t)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TeleportUntilBgChange(bool lastSprite)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TheClawUltimateAtk()
	{
		throw null;
	}
}
