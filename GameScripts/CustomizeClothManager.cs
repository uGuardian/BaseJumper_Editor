using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MoveTool;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeClothManager : MonoBehaviour
{
	public const float SIZE = 512f;

	private static CustomizeClothManager _instance;

	private CustomActionDetail _currentMovtion;

	private Sprite _currentSprite;

	private Sprite _currentFrontSprite;

	[Header("Sprite")]
	public Image CurSpriteRender;

	public Image CurFrontSpriteRender;

	[Header("Phase")]
	private ClothCustomizePhase _phase;

	public Button loadButton;

	public Button pivotPosButton;

	public Button neckPosButton;

	public Button saveButton;

	public Button loadFrontButton;

	public Button clearFrontButton;

	public Toggle headSettingToggle;

	[Header("MoveTool")]
	public MoveTool.MoveTool moveTool;

	[Header("Progress")]
	public ProgressUnit[] progressUnits;

	public Color normalColor;

	public Color progressedColor;

	[Header("Info")]
	public Text PivotText;

	public Text NeckText;

	public Text CustomState;

	public HeadDirection currentDirection;

	public Toggle HeadActiveButton;

	public bool HeadActive;

	public Dropdown directionDropdown;

	public InputField headRotationText;

	public Slider headRotationSlider;

	private Dictionary<CustomActionDetail, SpriteCustomizeData> _dic;

	private string _dataName;

	public static CustomizeClothManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CustomActionDetail CurrentMotionType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public ClothCustomizePhase Phase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFrontSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHeadRotation(string value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadSpriteFile(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFrontSpriteFile(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearFrontSpriteFile()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLoadFrontSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLoadSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMotionType(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSetPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPivotPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNeckPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNeckRotation(float rotation)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSaveFile()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 GetToolPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFilledMotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFilledName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDataName(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDirection(int dir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHeadActive(bool state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveHeadState(bool state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizeClothManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomizeClothManager()
	{
		throw null;
	}
}
