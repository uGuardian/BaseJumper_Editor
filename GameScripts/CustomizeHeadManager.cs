using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeHeadManager : MonoBehaviour
{
	private static CustomizeHeadManager _instance;

	private CustomizeHeadManager.FaceDirection _curDirection;

	public Button FrontButton;

	public Button SideButton;

	[Header("Frontal")]
	public GameObject FrontPivot;

	public GameObject FrontHeadPivot;

	public Image Front_Brow_Normal;

	public Image Front_Brow_Attack;

	public Image Front_Brow_Hit;

	public Image Front_Eye;

	public Image Front_Mouth_Normal;

	public Image Front_Mouth_Attack;

	public Image Front_Mouth_Hit;

	public Image Front_FrontHair;

	public Image Front_RearHair;

	public Image Front_Head;

	public Dropdown Front_EmotionDropdown;

	private CustomizeHeadManager.FrontEmotionType _currentBrowType;

	[Header("Side")]
	public GameObject SidePivot;

	public GameObject SideHeadPivot;

	public Image Side_Brow;

	public Image Side_Eye;

	public Image Side_Mouth;

	public Image Side_FrontHair;

	public Image Side_RearHair_Front;

	public Image Side_RearHair_Rear;

	public Image Side_Head;

	private Dictionary<FaceCustomType, Sprite> _defaultSprite;

	public static CustomizeHeadManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CustomizeHeadManager.FaceDirection CurDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CustomizeHeadManager.FrontEmotionType CurrentBrowType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDirection(int direction)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFrontEmotionType(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoadSprite(FaceCustomType type, Sprite sprite)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Image GetPositionImage(FaceCustomType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizeHeadManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomizeHeadManager()
	{
		throw null;
	}

	public enum FaceDirection
	{
		Front,
		Side
	}

	public enum FrontEmotionType
	{
		Normal,
		Attack,
		Hit
	}
}
