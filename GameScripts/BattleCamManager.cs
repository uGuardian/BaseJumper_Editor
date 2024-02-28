using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using UnityEngine.PostProcessing;

public class BattleCamManager : SingletonBehavior<BattleCamManager>
{
	[Header("------------- BaseJumper -------------")]
	[SerializeField]
	private bool testingOverride;

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
	private List<BattleUnitView> _focusTargetList = new List<BattleUnitView>();

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

	private List<MonoBehaviour> _filterList = new List<MonoBehaviour>();

	private Coroutine _changeProjectionRoutine;

	private bool _bChangingProjection;

	[HideInInspector]
	public bool scrollable = true;

	private readonly float FIXED_TUTORIAL_ORTHOSIZE = 39.2f;

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

	public Vector3 focusOneUnitPosition = Vector3.zero;

	public BattleUnitView focusOneUnitTarget;

	private float _focusZoomFactor = 1f;

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

	protected BattleCamManager()
	{
	}

	public bool IsCamIsReturning
	{
		get
		{
			return this._bCamIsReturning;
		}
	}

	public float RotationX
	{
		get
		{
			return this._camRotator.transform.rotation.eulerAngles.x;
		}
	}

	public Camera mainCam
	{
		get
		{
			return this._mainCam;
		}
	}

	public CamRootRotator camRotator
	{
		get
		{
			return this._camRotator;
		}
	}

	public Camera bgCam
	{
		get
		{
			return this._bgCamTransform.GetComponent<Camera>();
		}
	}

	public Camera EffectCam
	{
		get
		{
			return this._effectCam;
		}
	}

	public Camera CharacterUiCam
	{
		get
		{
			return this._characterUiCam;
		}
	}

	public bool IsReadyRencounter
	{
		get
		{
			return this._bReadyRencounter;
		}
	}

	public bool IsChanginProjection
	{
		get
		{
			return this._bChangingProjection;
		}
	}

	public List<Camera> GetAllCamera()
	{
		List<Camera> list = new List<Camera>();
		if (this._bgCamTransform.GetComponent<Camera>() != null)
		{
			list.Add(this._bgCamTransform.GetComponent<Camera>());
		}
		list.Add(this._mainCam);
		list.Add(this._characterUiCam);
		list.Add(this._characterCam);
		list.Add(this._uiCam);
		list.Add(this._effectCam);
		return list;
	}

	public void ResetCamSetting()
	{
		if (testingOverride) {return;}
		this.ChangeCamProjection(false);
		float currentBorderPos = SingletonBehavior<HexagonalMapManager>.Instance.GetCurrentBorderPos(HexagonalMapManager.WallDirection.RIGHT);
		float currentBorderPos2 = SingletonBehavior<HexagonalMapManager>.Instance.GetCurrentBorderPos(HexagonalMapManager.WallDirection.LEFT);
		this._curStdOrtho = (currentBorderPos - currentBorderPos2) * 0.35f;
		this._curStdPos = this._stdCamPositions[3];
		this.resetCommand = false;
		this._camRotator.UpdateBorder(this._curStdOrtho * 0.804f, 30f);
		base.transform.localPosition = this._curStdPos;
		this._mainCam.orthographicSize = this._curStdOrtho;
		this._bCamIsReturning = false;
		this._focusTargetList.Clear();
		this._camRotator.lookAt.transform.position = Vector3.zero;
		float num = this._camRotator.mapBorder.size.x * 0.5f;
		float d = this._curStdOrtho * 2f / num * 0.804f;
		this._camRotator.mapBorder.transform.localScale = Vector3.one * d;
		this.BlurCharacterCam(false, 2.5f);
		this.VignetteCharacterCam(false);
		this.UpdateOtherCameras();
		this.RemoveCameraFilterAll();
		this.FollowOneUnit(null, false);
		this.ChangeCamMode(BattleCamManager.CamControlMode.MANUAL);
	}

	public T AddCameraFilter<T>(bool duplicate = false) where T : MonoBehaviour
	{
		if (!duplicate)
		{
			foreach (MonoBehaviour monoBehaviour in this._filterList)
			{
				if (monoBehaviour is T)
				{
					return monoBehaviour as T;
				}
			}
		}
		T t = this._effectCam.gameObject.AddComponent<T>();
		this._filterList.Add(t);
		return t;
	}

	public void RemoveCameraFilter<T>() where T : MonoBehaviour
	{
		T component = this._effectCam.gameObject.GetComponent<T>();
		if (component != null)
		{
			this._filterList.Remove(component);
			UnityEngine.Object.DestroyImmediate(component);
		}
	}

	public void RemoveCameraFilterAll()
	{
		foreach (MonoBehaviour obj in this._filterList)
		{
			UnityEngine.Object.Destroy(obj);
		}
		this._filterList.Clear();
		foreach (MonoBehaviour monoBehaviour in this._defaultCamFilters)
		{
			monoBehaviour.enabled = false;
		}
	}

	public void ChangeCamMode(BattleCamManager.CamControlMode mode)
	{
		this._camMode = mode;
	}

	public void StartMoveUnits()
	{
		if (!this._firstRencounter)
		{
			this._firstRencounter = true;
			this._camRotator.UpdateBorder(10f, 10f);
			this._focusTargetList.Clear();
			BattleObjectManager.instance.GetAliveList(false).ForEach(delegate(BattleUnitModel x)
			{
				this._focusTargetList.Add(x.view);
			});
			this._bReadyRencounter = true;
			this.ChangeCamMode(BattleCamManager.CamControlMode.FOCUS);
			this.VignetteCharacterCam(true);
		}
	}

	public void ChangeCamProjection(bool isPerspective)
	{
		this._mainCam.orthographic = !isPerspective;
		this._characterCam.orthographic = !isPerspective;
		this._characterUiCam.orthographic = !isPerspective;
		this._uiCam.orthographic = !isPerspective;
		this._effectCam.orthographic = !isPerspective;
	}

	private IEnumerator ChangeCamProjectionRoutine()
	{
		float aspect = (float)Screen.width / (float)Screen.height;
		float fov = this.targetFov[2];
		switch (SingletonBehavior<BattleSceneRoot>.Instance?.currentMapObject.mapSize)
		{
		case MapSize.S:
			fov = this.targetFov[0];
			break;
		case MapSize.M:
			fov = this.targetFov[1];
			break;
		case MapSize.L:
			fov = this.targetFov[2];
			break;
		}
		Matrix4x4 p = Matrix4x4.Perspective(fov, aspect, 0.3f, 1000f);
		Matrix4x4 projectionMatrix = this._mainCam.projectionMatrix;
		this._bChangingProjection = true;
		float elapsed = 0f;
		while (elapsed < 1f)
		{
			elapsed += Time.deltaTime;
			projectionMatrix = this._mainCam.projectionMatrix;
			Matrix4x4 projectionMatrix2 = default(Matrix4x4);
			for (int i = 0; i < 16; i++)
			{
				projectionMatrix2[i] = Mathf.Lerp(projectionMatrix[i], p[i], elapsed);
			}
			this._mainCam.projectionMatrix = projectionMatrix2;
			this._characterCam.projectionMatrix = projectionMatrix2;
			this._characterUiCam.projectionMatrix = projectionMatrix2;
			this._uiCam.projectionMatrix = projectionMatrix2;
			this._effectCam.projectionMatrix = projectionMatrix2;
			yield return YieldCache.waitFrame;
		}
		float fieldOfView = Mathf.Atan(1f / this._mainCam.projectionMatrix[1, 1]) * 2f * 57.29578f;
		this._mainCam.orthographic = false;
		this._characterCam.orthographic = false;
		this._characterUiCam.orthographic = false;
		this._uiCam.orthographic = false;
		this._effectCam.orthographic = false;
		this._mainCam.fieldOfView = fieldOfView;
		this._characterCam.fieldOfView = fieldOfView;
		this._characterUiCam.fieldOfView = fieldOfView;
		this._uiCam.fieldOfView = fieldOfView;
		this._effectCam.fieldOfView = fieldOfView;
		this._mainCam.ResetProjectionMatrix();
		this._characterCam.ResetProjectionMatrix();
		this._characterUiCam.ResetProjectionMatrix();
		this._uiCam.ResetProjectionMatrix();
		this._effectCam.ResetProjectionMatrix();
		this._bChangingProjection = false;
		yield break;
	}

	public void FollowUnits(bool isAction, List<BattleUnitModel> modelList)
	{
		this.ChangeCamMode(BattleCamManager.CamControlMode.FOCUS);
		this._focusTargetList.Clear();
		modelList.ForEach(delegate(BattleUnitModel x)
		{
			this._focusTargetList.Add(x.view);
		});
		if (isAction)
		{
			this.ChangeCamProjection(true);
			if (this.focusRoutine != null)
			{
				base.StopCoroutine(this.focusRoutine);
				this.focusRoutine = null;
				return;
			}
		}
		else
		{
			this.ChangeCamProjection(false);
		}
	}

	public void FollowOneUnit(BattleUnitModel model, bool b)
	{
		if (b)
		{
			this.stopFocusByRencounter = true;
			this.focusOneUnitPosition = model.view.WorldPosition;
			this.focusOneUnitTarget = model.view;
			return;
		}
		this.stopFocusByRencounter = false;
		this.focusOneUnitPosition = Vector3.zero;
		this.focusOneUnitTarget = null;
	}

	public void ShakeCam(float speed = 50f, float xAmount = 0.015f, float yAmount = 0.015f)
	{
		CameraFilterPack_FX_EarthQuake component = this._characterCam.GetComponent<CameraFilterPack_FX_EarthQuake>();
		if (component == null)
		{
			return;
		}
		if (xAmount + yAmount >= component.X + component.Y)
		{
			if (this._isShaking && this._shakeRoutine != null)
			{
				base.StopCoroutine(this._shakeRoutine);
			}
			this._shakeRoutine = base.StartCoroutine(this.VibeCam(component, speed, new Vector2(xAmount, yAmount)));
		}
	}

	public void BloodFilter(int sign, float ratioLeft = 0.6f, float ratioRight = 0.6f)
	{
		if (ratioLeft < 0.15f)
		{
			ratioLeft = 0.333f;
		}
		else if (ratioLeft < 0.5f)
		{
			ratioLeft = 0.666f;
		}
		else if (ratioLeft < 0.8f)
		{
			ratioLeft = 1f;
		}
		else
		{
			ratioLeft = 1.333f;
		}
		if (ratioRight < 0.15f)
		{
			ratioRight = 0.333f;
		}
		else if (ratioRight < 0.5f)
		{
			ratioRight = 0.666f;
		}
		else if (ratioRight < 0.8f)
		{
			ratioRight = 1f;
		}
		else
		{
			ratioRight = 1.333f;
		}
		base.StartCoroutine(this.OnBloodFilter(sign, ratioLeft, ratioRight));
	}

	private IEnumerator OnBloodFilter(int sign, float ratioLeft, float ratioRight)
	{
		CameraFilterPack_AAA_Blood_Hit bloodFilter = this._characterCam.GetComponent<CameraFilterPack_AAA_Blood_Hit>();
		if (!this._defaultCamFilters.Exists((MonoBehaviour x) => x == bloodFilter))
		{
			this._defaultCamFilters.Add(bloodFilter);
		}
		bloodFilter.enabled = true;
		bloodFilter.Hit_Left = 0f;
		bloodFilter.Hit_Down = 0f;
		bloodFilter.Blood_Hit_Left = 0f;
		bloodFilter.Blood_Hit_Down = 0f;
		bloodFilter.Blood_Hit_Full_3 = 0f;
		bloodFilter.Hit_Right = 0f;
		bloodFilter.Hit_Up = 0f;
		bloodFilter.Blood_Hit_Right = 0f;
		bloodFilter.Blood_Hit_Up = 0f;
		bloodFilter.Blood_Hit_Full_3 = 0f;
		float v = 0.846f;
		float v2 = 0.445f;
		float v3 = 0.108f;
		if (sign < 0)
		{
			float elapsed = 0f;
			v *= ratioLeft;
			v2 *= ratioLeft;
			v3 *= ratioLeft;
			while (elapsed < 1f)
			{
				elapsed += Time.deltaTime;
				bloodFilter.Hit_Left = Mathf.Lerp(v, 0f, elapsed);
				bloodFilter.Blood_Hit_Left = Mathf.Lerp(v2, 0f, elapsed);
				bloodFilter.Blood_Hit_Full_3 = Mathf.Lerp(v3, 0f, elapsed);
				yield return YieldCache.waitFrame;
			}
			bloodFilter.Hit_Left = v;
			bloodFilter.Blood_Hit_Left = v2;
			bloodFilter.Blood_Hit_Full_3 = v3;
		}
		else if (sign > 0)
		{
			float elapsed = 0f;
			v *= ratioRight;
			v2 *= ratioRight;
			v3 *= ratioRight;
			while (elapsed < 1f)
			{
				elapsed += Time.deltaTime;
				bloodFilter.Hit_Right = Mathf.Lerp(v, 0f, elapsed);
				bloodFilter.Blood_Hit_Right = Mathf.Lerp(v2, 0f, elapsed);
				bloodFilter.Blood_Hit_Full_3 = Mathf.Lerp(v3, 0f, elapsed);
				yield return YieldCache.waitFrame;
			}
			bloodFilter.Hit_Right = v;
			bloodFilter.Blood_Hit_Right = v2;
			bloodFilter.Blood_Hit_Full_3 = v3;
		}
		else
		{
			float elapsed = 0f;
			float v1_right = v * ratioRight;
			float v3_right = v2 * ratioRight;
			float v5_right = v3 * ratioRight;
			v *= ratioLeft;
			v2 *= ratioLeft;
			v3 *= ratioLeft;
			while (elapsed < 1f)
			{
				elapsed += Time.deltaTime;
				bloodFilter.Hit_Left = Mathf.Lerp(v, 0f, elapsed);
				bloodFilter.Blood_Hit_Left = Mathf.Lerp(v2, 0f, elapsed);
				if (v3 > v5_right)
				{
					bloodFilter.Blood_Hit_Full_3 = Mathf.Lerp(v3, 0f, elapsed);
				}
				bloodFilter.Hit_Right = Mathf.Lerp(v1_right, 0f, elapsed);
				bloodFilter.Blood_Hit_Right = Mathf.Lerp(v3_right, 0f, elapsed);
				if (v3 < v5_right)
				{
					bloodFilter.Blood_Hit_Full_3 = Mathf.Lerp(v5_right, 0f, elapsed);
				}
				yield return YieldCache.waitFrame;
			}
			bloodFilter.Hit_Left = v;
			bloodFilter.Blood_Hit_Left = v2;
			bloodFilter.Blood_Hit_Full_3 = v3;
			bloodFilter.Hit_Right = v1_right;
			bloodFilter.Blood_Hit_Right = v3_right;
			bloodFilter.Blood_Hit_Full_3 = v5_right;
		}
		bloodFilter.enabled = false;
		yield break;
	}

	public void BlurBackgroundCam(bool enable)
	{
		PostProcessingBehaviour component = this._bgCamTransform.GetComponent<PostProcessingBehaviour>();
		if (component != null)
		{
			component.enabled = enable;
		}
	}

	public void BlurCharacterCam(bool active, float speed = 2.5f)
	{
		PostProcessingBehaviour component = this._characterCam.GetComponent<PostProcessingBehaviour>();
		if (this._dofRoutine != null)
		{
			base.StopCoroutine(this._dofRoutine);
			this._dofRoutine = null;
		}
		this._dofRoutine = base.StartCoroutine(this.BlurRoutine(component, active, speed));
	}

	private IEnumerator BlurRoutine(PostProcessingBehaviour pp, bool active, float speed)
	{
		float elapsed = 0f;
		DepthOfFieldModel dof = pp.profile.depthOfField;
		DepthOfFieldModel.Settings dofSetting = dof.settings;
		float src = dofSetting.focalLength;
		int dst = active ? 188 : 1;
		while (elapsed < 1f)
		{
			elapsed += Time.deltaTime * speed;
			dofSetting.focalLength = Mathf.Lerp(src, (float)dst, elapsed);
			dof.settings = dofSetting;
			yield return YieldCache.waitFrame;
		}
		dofSetting.focalLength = (float)dst;
		dof.settings = dofSetting;
		yield break;
	}

	public void SetVignetteColorBgCam(Color c, bool active = true)
	{
		CameraFilterPack_TV_Vignetting component = this._bgCamTransform.GetComponent<CameraFilterPack_TV_Vignetting>();
		component.VignettingColor = c;
		component.enabled = active;
		SingletonBehavior<BattleManagerUI>.Instance?.ui_emotionInfoBar.SetSephirahFrameImgColor(c);
	}

	public void SetCreatureFilter()
	{
		if (this._effectCam.GetComponent<CameraFilterPack_Drawing_Paper3>() != null)
		{
			this._effectCam.GetComponent<CameraFilterPack_Drawing_Paper3>().enabled = (SingletonBehavior<BattleSceneRoot>.Instance != null && SingletonBehavior<BattleSceneRoot>.Instance.currentMapObject.isCreature && !SingletonBehavior<BattleSceneRoot>.Instance.currentMapObject.isBossPhase && !SingletonBehavior<BattleSceneRoot>.Instance.currentMapObject.isEgo);
		}
	}

	public void SetFilter(string str, params object[] p)
	{
		if (str == "BloodBath")
		{
			base.StartCoroutine(this.BloodOnScreen((int)p[0]));
		}
	}

	private IEnumerator BloodOnScreen(int lv)
	{
		float blood_On_Screen = 1f;
		switch (lv)
		{
		case 1:
			blood_On_Screen = 1f;
			break;
		case 2:
			blood_On_Screen = 1.2f;
			break;
		case 3:
			blood_On_Screen = 1.6f;
			break;
		}
		CameraFilterPack_AAA_BloodOnScreen f = this._effectCam.GetComponent<CameraFilterPack_AAA_BloodOnScreen>();
		if (f == null)
		{
			f = this._effectCam.gameObject.AddComponent<CameraFilterPack_AAA_BloodOnScreen>();
		}
		this._filterList.Add(f);
		f.Blood_Distortion_Speed = 0f;
		f.Blood_On_Screen = blood_On_Screen;
		f.Blood_Color = new Color(0.5f, 0f, 0f, 1f);
		float e = 0f;
		while (e < 1f)
		{
			e += Time.deltaTime * 2f;
			f.Blood_Fade = (1f - e) * 0.5f;
			yield return null;
		}
		f.enabled = false;
		UnityEngine.Object.Destroy(f);
		this._filterList.Remove(f);
		yield break;
	}

	public void VignetteCharacterCam(bool active)
	{
		PostProcessingBehaviour component = this._characterCam.GetComponent<PostProcessingBehaviour>();
		if (this._vignetteRoutine != null)
		{
			base.StopCoroutine(this._vignetteRoutine);
			this._vignetteRoutine = null;
		}
		this._vignetteRoutine = base.StartCoroutine(this.VignetteRoutine(component, active));
		this._characterCam.GetComponent<CameraFilterPack_AAA_Blood_Hit>().enabled = false;
	}

	private IEnumerator VignetteRoutine(PostProcessingBehaviour pp, bool active)
	{
		float e = 0f;
		float defaultVignetteIntensity = 0.725f;
		VignetteModel vignette = pp.profile.vignette;
		VignetteModel.Settings vignetteSetting = vignette.settings;
		float vignetteValue = vignetteSetting.intensity;
		while (e < 1f)
		{
			e += Time.deltaTime * 2.5f;
			if (active)
			{
				vignetteSetting.intensity = Mathf.Lerp(vignetteValue, defaultVignetteIntensity, e);
			}
			else
			{
				vignetteSetting.intensity = Mathf.Lerp(vignetteValue, 0f, e);
			}
			vignette.settings = vignetteSetting;
			yield return YieldCache.waitFrame;
		}
		yield break;
	}

	public void ChangeCharacterCamRGB(bool active)
	{
		this._characterCam.GetComponent<CameraFilterPack_Color_RGB>().enabled = active;
	}

	public void ZoomAction(bool zoomIn, bool directly, float ratio = 0.75f)
	{
		if (!directly)
		{
			if (zoomIn)
			{
				if (!this._bZoomAction)
				{
					this._zoomRoutine = base.StartCoroutine(this.ZoomActionRoutine(ratio));
					return;
				}
			}
			else
			{
				this._bZoomAction = zoomIn;
			}
			return;
		}
		if (this._zoomRoutine != null)
		{
			base.StopCoroutine(this._zoomRoutine);
			this._zoomRoutine = null;
		}
		this._bZoomAction = zoomIn;
		if (this._bZoomAction)
		{
			this._minOrthoSize = 13f * ratio;
			return;
		}
		this._minOrthoSize = 13f;
	}

	private IEnumerator ZoomActionRoutine(float ratio)
	{
		this._bZoomAction = true;
		float defaultOrtho = this._minOrthoSize;
		float value = defaultOrtho * ratio;
		float elapsed = 0f;
		this._minOrthoSize = value;
		yield return new WaitUntil(() => !this._bZoomAction);
		elapsed = 0f;
		while (elapsed < 1f)
		{
			elapsed += Time.deltaTime * 5f;
			this._minOrthoSize = Mathf.Lerp(value, defaultOrtho, elapsed);
			yield return YieldCache.waitFrame;
		}
		this._minOrthoSize = defaultOrtho;
		yield break;
	}

	public void TiltCam(int sign, bool exitForcely = false)
	{
		if (exitForcely)
		{
			this._mainCam.transform.localRotation = Quaternion.identity;
			this.isTiltingDone = true;
			return;
		}
		this.isTiltingDone = false;
		base.StartCoroutine(this.TiltRoutine(sign));
	}

	private IEnumerator TiltRoutine(int sign)
	{
		float dstAngle = (float)sign * 2f;
		float elapsed = 0f;
		float speed = 6f;
		while (elapsed <= 1.1f)
		{
			elapsed += Time.deltaTime * speed;
			float t = this._tiltCurve.Evaluate(elapsed) * 0.5f;
			float z = Mathf.LerpAngle(0f, dstAngle, t);
			this._mainCam.transform.localRotation = Quaternion.Euler(0f, 0f, z);
			yield return YieldCache.waitFrame;
		}
		elapsed = 1f;
		while (elapsed > -0.1f)
		{
			elapsed -= Time.deltaTime * speed;
			float num = this._tiltCurve.Evaluate(elapsed) * 0.5f;
			if (num < 0f)
			{
				num = 0f;
			}
			float z2 = Mathf.LerpAngle(0f, dstAngle, num);
			this._mainCam.transform.localRotation = Quaternion.Euler(0f, 0f, z2);
			yield return YieldCache.waitFrame;
		}
		this.isTiltingDone = true;
		yield break;
	}

	public void OnRoundEnd()
	{
		this.VignetteCharacterCam(false);
		this.BlurCharacterCam(false, 2.5f);
		this._bReadyRencounter = false;
		this._firstRencounter = false;
		float currentBorderPos = SingletonBehavior<HexagonalMapManager>.Instance.GetCurrentBorderPos(HexagonalMapManager.WallDirection.RIGHT);
		float currentBorderPos2 = SingletonBehavior<HexagonalMapManager>.Instance.GetCurrentBorderPos(HexagonalMapManager.WallDirection.LEFT);
		this._curStdOrtho = (currentBorderPos - currentBorderPos2) * 0.35f;
		this._curStdPos = this._stdCamPositions[3];
		this.resetCommand = false;
		this._camRotator.UpdateBorder(this._curStdOrtho * 0.804f, 30f);
		this.FollowOneUnit(null, false);
		if (this.focusRoutine != null)
		{
			base.StopCoroutine(this.focusRoutine);
			this.focusRoutine = null;
		}
		this._returnRoutine = base.StartCoroutine(this.ReturnCam(this._curStdPos, this._curStdOrtho, 1f));
		this._focusTargetList.Clear();
	}

	public IEnumerator ReturnCam()
	{
		this._bCamIsReturning = true;
		this.ChangeCamProjection(false);
		float elapsed = 0f;
		Vector3 srcPos = base.transform.localPosition;
		float srcOrtho = this._mainCam.orthographicSize;
		while (elapsed < 1f)
		{
			elapsed += Time.deltaTime * 1f;
			base.transform.localPosition = Vector3.Lerp(srcPos, this._curStdPos, this._returnPosCurve.Evaluate(elapsed));
			this._mainCam.orthographicSize = Mathf.Lerp(srcOrtho, this._curStdOrtho, this._returnOrthoCurve.Evaluate(elapsed));
			yield return YieldCache.waitFrame;
		}
		base.transform.localPosition = this._curStdPos;
		this._mainCam.orthographicSize = this._curStdOrtho;
		this._bCamIsReturning = false;
		this.ChangeCamMode(BattleCamManager.CamControlMode.MANUAL);
		yield break;
	}

	public void OnClickCharacter(BattleUnitModel unit)
	{
	}

	public void OnReleaseCharacter()
	{
	}

	public void OnClickCardInHand()
	{
	}

	public void OnReleaseCardInHand(BattleUnitModel unit)
	{
	}

	private void Awake()
	{
		if (!testingOverride) {
			if (SingletonBehavior<HexagonalMapManager>.Instance == null) {
				testingOverride = true;
			}
		}
		this.ResetCamSetting();
	}

	private void OnEnable()
	{
		this._minOrthoSize = 13f;
	}

	private void OnDisable()
	{
		this._minOrthoSize = 13f;
	}

	private void FixedUpdate()
	{
		if (testingOverride) {return;}
		if (this._bCamIsReturning)
		{
			return;
		}
		if (Input.GetMouseButton(2) && this._camMode == BattleCamManager.CamControlMode.FOCUS && ((!SingletonBehavior<RencounterManager>.Instance?.IsRunning) ?? true))
		{
			this._camMode = BattleCamManager.CamControlMode.MANUAL;
		}
		switch (this._camMode) {
			case BattleCamManager.CamControlMode.MANUAL:
				this.UpdateManual();
				break;
			case BattleCamManager.CamControlMode.FOCUS:
				this.UpdateFocus(Time.fixedDeltaTime);
				break;
		}
	}

	private void LateUpdate()
	{
		this.UpdateOtherCameras();
	}

	private void UpdateOtherCameras()
	{
		this._characterCam.orthographicSize = this._mainCam.orthographicSize;
		this._characterUiCam.orthographicSize = this._mainCam.orthographicSize;
		this._uiCam.orthographicSize = this._mainCam.orthographicSize;
		this._effectCam.orthographicSize = this._mainCam.orthographicSize;
		float minOrthoSize = this._minOrthoSize;
		float num = (this._mainCam.orthographicSize - minOrthoSize) / (this._maxOrthoSize - minOrthoSize);
		float num2 = (this._maxFov - this._minFov) * num + this._minFov;
		Camera component = this._bgCamTransform.GetComponent<Camera>();
		if (this._bReadyRencounter)
		{
			component.fieldOfView = Mathf.Lerp(component.fieldOfView, 17f, Time.deltaTime * 2.5f);
		}
		else
		{
			component.fieldOfView = Mathf.Lerp(component.fieldOfView, num2, Time.deltaTime * 2.5f);
		}
		this._fgCamTransform.GetComponent<Camera>().fieldOfView = num2;
		Vector3 localPosition = this._mainCam.transform.localPosition;
		this._bgCamTransform.localPosition = localPosition;
		this._fgCamTransform.localPosition = localPosition;
	}

	private void UpdateManual()
	{
		if (this._bCamIsReturning)
		{
			return;
		}
		if (SingletonBehavior<BattleManagerUI>.Instance?.ui_battleStory.isRunning ?? false)
		{
			return;
		}
		var tutManagerUI = SingletonBehavior<BattleTutorialManagerUI>.Instance;
		if (tutManagerUI != null && (tutManagerUI.IsRunningCreatureTutorial || tutManagerUI.IsRunningTutorial))
		{
			this._mainCam.orthographicSize = this.FIXED_TUTORIAL_ORTHOSIZE;
			return;
		}
		if (this.resetCommand)
		{
			this._mainCam.orthographicSize = Mathf.Lerp(this._mainCam.orthographicSize, this._curStdOrtho, Time.deltaTime * 10f);
			if (Mathf.Abs(this.mainCam.orthographicSize - this._curStdOrtho) < 1f)
			{
				this.resetCommand = false;
			}
		}
		float num;
		if (UIControlManager.isControllerInput)
		{
			num = -1f * Input.GetAxis("AxisVertical_RightStick") * 0.2f;
			if (Input.GetButtonDown("Button_RightStick"))
			{
				this.resetCommand = true;
				return;
			}
		}
		else
		{
			num = Input.GetAxis("Mouse ScrollWheel");
		}
		float num2 = this._mainCam.orthographicSize - num * this._manualCamZoomSpeed * (float)(this.scrollable ? 1 : 0);
		float num3 = 0f;
		if (UIControlManager.isControllerInput)
		{
			num3 = 20f;
		}
		num2 = Mathf.Clamp(num2, this._minOrthoSize, this._curStdOrtho + num3);
		this._mainCam.orthographicSize = Mathf.Lerp(this._mainCam.orthographicSize, num2, Time.deltaTime * 10f);
		Vector3 b = base.transform.localPosition;
		if (Input.GetMouseButton(2))
		{
			CursorManager instance = CursorManager.Instance;
			if (instance != null)
			{
				instance.OnCameraScroll();
			}
			float x = -Input.GetAxis("Mouse X");
			float y = -Input.GetAxis("Mouse Y");
			Vector3 b2 = new Vector3(x, y, 0f) * Time.deltaTime * this._manualCamMoveSpeed;
			b = this.CheckBoundary(base.transform.localPosition + b2);
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, b, Time.deltaTime * 10f);
	}

	private void UpdateFocusPosition(float deltaTime)
	{
		if (this.focusOneUnitTarget == null || !this.stopFocusByRencounter)
		{
			return;
		}
		Vector3 vector = this.focusOneUnitPosition - base.transform.position;
		float d = Vector3.Dot(this._mainCam.transform.forward, vector.normalized);
		Vector3 b = base.transform.forward * vector.magnitude * d;
		Vector3 a = this.focusOneUnitPosition;
		Vector3 b2 = base.transform.position + b;
		Vector3 b3 = a - b2;
		Vector3 vector2 = base.transform.position + b3;
		float d2 = this._focusOffsetY[0];
		MapSize size = SingletonBehavior<BattleSceneRoot>.Instance?.currentMapObject?.mapSize ?? MapSize.L;
		switch (size)
		{
		case MapSize.S:
			d2 = this._focusOffsetY[0];
			break;
		case MapSize.M:
			d2 = this._focusOffsetY[1];
			break;
		case MapSize.L:
			d2 = this._focusOffsetY[2];
			break;
		}
		float num = this.focusOneUnitTarget.camRotationFollower.localScale.x;
		if (num < 1f)
		{
			num = 1f;
		}
		vector2 += base.transform.up * d2 * num;
		Vector3 zero = Vector3.zero;
		base.transform.position = Vector3.SmoothDamp(base.transform.position, vector2, ref zero, this._smoothTime * this._focusCamMoveSmoothTime * 0.5f, this._maxSpeed);
		this.focusPos = vector2;
		float num2 = 1f;
		switch (size)
		{
		case MapSize.S:
			num2 = 1.5f;
			break;
		case MapSize.M:
			num2 = 1.27f;
			break;
		case MapSize.L:
			num2 = 1f;
			break;
		}
		float num3 = this._minOrthoSize * num2 * num;
		if (num3 > this._curStdOrtho)
		{
			num3 = this._curStdOrtho;
		}
		float target = Mathf.Clamp(num3, num3, this._curStdOrtho);
		float num4 = 0f;
		this._mainCam.orthographicSize = Mathf.SmoothDamp(this._mainCam.orthographicSize, target, ref num4, this._smoothTime, this._maxSpeed);
		if (SingletonBehavior<RencounterManager>.Instance?.IsRunning ?? false)
		{
			this.SetFov(this.focusOneUnitPosition, this._mainCam.aspect);
		}
		base.transform.localPosition = this.CheckBoundary(base.transform.localPosition);
	}

	private void UpdateFocus(float deltaTime)
	{
		if (this.stopFocusByRencounter)
		{
			this.UpdateFocusPosition(deltaTime);
			return;
		}
		if (this._focusTargetList.Count == 0)
		{
			return;
		}
		float num = this._focusTargetList[0].transform.position.x;
		float num2 = this._focusTargetList[0].transform.position.x;
		float num3 = 1f;
		Vector3 vector = Vector3.zero;
		float num4 = 1f;
		if (this._focusTargetList.Count == 1)
		{
			vector = this._focusTargetList[0].transform.position;
		}
		else if (this._focusTargetList.Count == 2)
		{
			BattleUnitModel model = this._focusTargetList[0].model;
			BattleUnitModel model2 = this._focusTargetList[1].model;
			foreach (BattleUnitView battleUnitView in this._focusTargetList)
			{
				Vector3 position = battleUnitView.transform.position;
				if (position.x > num)
				{
					num = position.x;
				}
				if (position.x < num2)
				{
					num2 = position.x;
				}
			}
			if (model.moveDetail.isKnockback ^ model2.moveDetail.isKnockback)
			{
				num4 = 0.5f;
				if (model.moveDetail.isKnockback && !model.moveDetail.IsCollideWithWall)
				{
					vector = model.view.WorldPosition + (model.view.WorldPosition - model2.view.WorldPosition).normalized * 4f;
					this._bFocusKnockback = true;
					this._eee = 0f;
				}
				else if (model2.moveDetail.isKnockback && !model2.moveDetail.IsCollideWithWall)
				{
					vector = model2.view.WorldPosition + (model2.view.WorldPosition - model.view.WorldPosition).normalized * 4f;
					this._bFocusKnockback = true;
					this._eee = 0f;
				}
				else
				{
					vector = (model.view.WorldPosition + model2.view.WorldPosition) * 0.5f;
					this._bFocusKnockback = false;
					if (!this._bFocusKnockback)
					{
						this._eee = 2f - Mathf.Clamp(this._eee + deltaTime, 0f, 1f);
						num4 = this._eee;
					}
				}
			}
			else
			{
				this._bFocusKnockback = false;
				if (!this._bFocusKnockback)
				{
					this._eee = 2f - Mathf.Clamp(this._eee + deltaTime, 0f, 1f);
					num4 = this._eee;
				}
				vector = (model.view.WorldPosition + model2.view.WorldPosition) * 0.5f;
			}
			vector = (model.view.WorldPosition + model2.view.WorldPosition) * 0.5f;
			num3 = Mathf.Max(model.view.camRotationFollower.localScale.x, model2.view.camRotationFollower.localScale.x);
			if (num3 < 1f)
			{
				num3 = 1f;
			}
		}
		else if (this._focusTargetList.Count > 2)
		{
			Vector3 a = Vector3.zero;
			foreach (BattleUnitView battleUnitView2 in this._focusTargetList)
			{
				Vector3 position2 = battleUnitView2.transform.position;
				a += position2;
				if (position2.x > num)
				{
					num = position2.x;
				}
				if (position2.x < num2)
				{
					num2 = position2.x;
				}
			}
			vector = a / (float)this._focusTargetList.Count;
			num += 3f;
			num2 -= 3f;
		}
		Vector3 vector2 = vector - base.transform.position;
		float d = Vector3.Dot(this._mainCam.transform.forward, vector2.normalized);
		Vector3 b = base.transform.forward * vector2.magnitude * d;
		Vector3 a2 = vector;
		Vector3 b2 = base.transform.position + b;
		Vector3 b3 = a2 - b2;
		Vector3 vector3 = base.transform.position + b3;
		float d2 = this._focusOffsetY[0];
		MapSize size = SingletonBehavior<BattleSceneRoot>.Instance?.currentMapObject?.mapSize ?? MapSize.L;
		switch (size)
		{
		case MapSize.S:
			d2 = this._focusOffsetY[0];
			break;
		case MapSize.M:
			d2 = this._focusOffsetY[1];
			break;
		case MapSize.L:
			d2 = this._focusOffsetY[2];
			break;
		}
		vector3 += base.transform.up * d2 * num3;
		Vector3 zero = Vector3.zero;
		base.transform.position = Vector3.SmoothDamp(base.transform.position, vector3, ref zero, this._smoothTime * num4 * this._focusCamMoveSmoothTime, this._maxSpeed);
		this.focusPos = vector3;
		float num5 = (num - num2) * 0.5625f;
		float num6 = 1f;
		switch (size)
		{
		case MapSize.S:
			num6 = 1.5f;
			break;
		case MapSize.M:
			num6 = 1.27f;
			break;
		case MapSize.L:
			num6 = 1f;
			break;
		}
		float num7 = this._minOrthoSize * num6 * num3 * this._focusZoomFactor;
		if (num7 > this._curStdOrtho)
		{
			num7 = this._curStdOrtho;
		}
		num5 = Mathf.Clamp(num5, num7, this._curStdOrtho);
		float num8 = 0f;
		this._mainCam.orthographicSize = Mathf.SmoothDamp(this._mainCam.orthographicSize, num5, ref num8, this._smoothTime * num4, this._maxSpeed);
		if (SingletonBehavior<RencounterManager>.Instance?.IsRunning ?? false)
		{
			this.SetFov(vector, this._mainCam.aspect);
		}
		base.transform.localPosition = this.CheckBoundary(base.transform.localPosition);
	}

	public void SetFocusZoomFaction(float t)
	{
		this._focusZoomFactor = t;
	}

	public bool IsCamFarFromFocusUnit()
	{
		return Vector3.Distance(base.transform.position, this.focusPos) > 5f;
	}

	private void SetFov(Vector3 stdPos, float aspect)
	{
		float num = Vector3.Distance(stdPos, this._mainCam.transform.position);
		float fieldOfView = Mathf.Atan(this._mainCam.orthographicSize / num) * 2f / 0.0174532924f;
		this._mainCam.fieldOfView = fieldOfView;
		this._characterCam.fieldOfView = fieldOfView;
		this._characterUiCam.fieldOfView = fieldOfView;
		this._uiCam.fieldOfView = fieldOfView;
		this._effectCam.fieldOfView = fieldOfView;
	}

	private Vector3 CheckBoundary(Vector3 pos)
	{
		var hexMapManager = SingletonBehavior<HexagonalMapManager>.Instance;
		if (hexMapManager == null) {return pos;}
		float x = hexMapManager.CenterPos.x;
		float max = this._curStdPos.x + this._curStdOrtho * 1.78f + 5f + x;
		float min = this._curStdPos.x - this._curStdOrtho * 1.78f - 5f + x;
		float max2 = this._curStdPos.y + this._curStdOrtho + 3f;
		float min2 = this._curStdPos.y - this._curStdOrtho - 3f;
		Vector3 vector = pos;
		vector.x = Mathf.Clamp(vector.x, min, max);
		vector.y = Mathf.Clamp(vector.y, min2, max2);
		return vector;
	}

	private IEnumerator ReturnCam(Vector3 dstPos, float dstOrtho, float speed)
	{
		this._bCamIsReturning = true;
		this.ChangeCamProjection(false);
		float elapsed = 0f;
		Vector3 srcPos = base.transform.localPosition;
		float srcOrtho = this._mainCam.orthographicSize;
		while (elapsed < 1f)
		{
			elapsed += Time.deltaTime * speed;
			base.transform.localPosition = Vector3.Lerp(srcPos, dstPos, this._returnPosCurve.Evaluate(elapsed));
			this._mainCam.orthographicSize = Mathf.Lerp(srcOrtho, dstOrtho, this._returnOrthoCurve.Evaluate(elapsed));
			yield return YieldCache.waitFrame;
		}
		base.transform.localPosition = dstPos;
		this._mainCam.orthographicSize = dstOrtho;
		this._bCamIsReturning = false;
		this.ChangeCamMode(BattleCamManager.CamControlMode.MANUAL);
		yield break;
	}

	private IEnumerator VibeCam(CameraFilterPack_FX_EarthQuake filter, float speed, Vector2 xy)
	{
		this._isShaking = true;
		if (!this._defaultCamFilters.Exists((MonoBehaviour x) => x == filter))
		{
			this._defaultCamFilters.Add(filter);
		}
		if (filter != null)
		{
			float s = filter.Speed;
			float x2 = filter.X;
			float y = filter.Y;
			filter.Speed = speed;
			filter.X = xy.x;
			filter.Y = xy.y;
			filter.enabled = true;
			yield return YieldCache.WaitForSeconds(0.25f);
			filter.enabled = false;
			filter.Speed = s;
			filter.X = x2;
			filter.Y = y;
			this._isShaking = false;
		}
		else
		{
			yield return null;
		}
		yield break;
	}

	private void DEBUG_RoundEnd(int i)
	{
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
