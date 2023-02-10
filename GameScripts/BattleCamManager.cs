using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PostProcessing;

public class BattleCamManager : SingletonBehavior<BattleCamManager>
{
	[Header("------------- References -------------")]
	[SerializeField]
	private CamRootRotator _camRotator;

	[SerializeField]
	private Vector3[] _stdCamPositions;

	[SerializeField]
	private float _maxOrthoSize;

	[SerializeField]
	private float _minOrthoSize;

	private const float _ORTHO_SIZE_MIN = 13f;

	[SerializeField]
	private float _minFov;

	[SerializeField]
	private float _maxFov;

	[SerializeField]
	private float _focusCamMoveSmoothTime;

	[SerializeField]
	private Transform _bgCamTransform;

	[SerializeField]
	private Transform _fgCamTransform;

	[SerializeField]
	private Camera _uiCam;

	[SerializeField]
	private Camera _effectCam;

	[SerializeField]
	private Camera _characterCam;

	[SerializeField]
	private Camera _characterUiCam;

	[SerializeField]
	private Camera _mainCam;

	[Space]
	[Header("------------- Runtime -------------")]
	[SerializeField]
	private BattleCamManager.CamControlMode _camMode;

	[SerializeField]
	private Vector3 _curStdPos;

	[SerializeField]
	private float _curStdOrtho;

	[SerializeField]
	private float _smoothTime;

	[SerializeField]
	private float _maxSpeed;

	[SerializeField]
	private float _manualCamMoveSpeed;

	[SerializeField]
	private float _manualCamZoomSpeed;

	[SerializeField]
	private List<BattleUnitView> _focusTargetList;

	[SerializeField]
	private List<MonoBehaviour> _defaultCamFilters;

	[SerializeField]
	private float[] _focusOffsetY;

	public float[] targetFov;

	private bool _bCamIsReturning;

	private Coroutine _shakeRoutine;

	private Coroutine _returnRoutine;

	private Coroutine _firstRencounterRoutine;

	private Coroutine _vignetteRoutine;

	private Coroutine _dofRoutine;

	private bool _bReadyRencounter;

	private bool _firstRencounter;

	private List<MonoBehaviour> _filterList;

	private Coroutine _changeProjectionRoutine;

	private bool _bChangingProjection;

	[HideInInspector]
	public bool scrollable;

	private readonly float FIXED_TUTORIAL_ORTHOSIZE;

	private Coroutine focusRoutine;

	private bool _bZoomAction;

	private Coroutine _zoomRoutine;

	public bool isTiltingDone;

	[SerializeField]
	private AnimationCurve _tiltCurve;

	private bool resetCommand;

	private bool _bFocusKnockback;

	private float _eee;

	public bool stopFocusByRencounter;

	public Vector3 focusOneUnitPosition;

	public BattleUnitView focusOneUnitTarget;

	private float _focusZoomFactor;

	private Vector3 focusPos;

	[SerializeField]
	private AnimationCurve _returnPosCurve;

	[SerializeField]
	private AnimationCurve _returnOrthoCurve;

	[SerializeField]
	[Range(0.5f, 5f)]
	private float _returnSpeed;

	private bool _isShaking;

	public static int testAllyEmotionLv;

	public static int testEnemyEmotionLv;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BattleCamManager()
	{
		throw null;
	}

	public bool IsCamIsReturning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float RotationX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Camera mainCam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CamRootRotator camRotator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Camera bgCam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Camera EffectCam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Camera CharacterUiCam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsReadyRencounter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsChanginProjection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Camera> GetAllCamera()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCamSetting()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T AddCameraFilter<T>(bool duplicate = false) where T : MonoBehaviour
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveCameraFilter<T>() where T : MonoBehaviour
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveCameraFilterAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCamMode(BattleCamManager.CamControlMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMoveUnits()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCamProjection(bool isPerspective)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ChangeCamProjectionRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FollowUnits(bool isAction, List<BattleUnitModel> modelList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FollowOneUnit(BattleUnitModel model, bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShakeCam(float speed = 50f, float xAmount = 0.015f, float yAmount = 0.015f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BloodFilter(int sign, float ratioLeft = 0.6f, float ratioRight = 0.6f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnBloodFilter(int sign, float ratioLeft, float ratioRight)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BlurBackgroundCam(bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BlurCharacterCam(bool active, float speed = 2.5f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlurRoutine(PostProcessingBehaviour pp, bool active, float speed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVignetteColorBgCam(Color c, bool active = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCreatureFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilter(string str, params object[] p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BloodOnScreen(int lv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void VignetteCharacterCam(bool active)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VignetteRoutine(PostProcessingBehaviour pp, bool active)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCharacterCamRGB(bool active)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ZoomAction(bool zoomIn, bool directly, float ratio = 0.75f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ZoomActionRoutine(float ratio)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TiltCam(int sign, bool exitForcely = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator TiltRoutine(int sign)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator ReturnCam()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickCharacter(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnReleaseCharacter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickCardInHand()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnReleaseCardInHand(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateOtherCameras()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateManual()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateFocusPosition(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateFocus(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFocusZoomFaction(float t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCamFarFromFocusUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFov(Vector3 stdPos, float aspect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 CheckBoundary(Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ReturnCam(Vector3 dstPos, float dstOrtho, float speed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibeCam(CameraFilterPack_FX_EarthQuake filter, float speed, Vector2 xy)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DEBUG_RoundEnd(int i)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BattleCamManager()
	{
		throw null;
	}

	public enum CamControlMode
	{
		MANUAL,
		FOCUS
	}

	public enum ViewMode
	{
		NORMAL,
		RENCOUNTER
	}
}
