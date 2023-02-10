using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FlexibleColorPicker : MonoBehaviour
{
	public Image[] pickerImages;

	public InputField hexInput;

	public Dropdown modeDropdown;

	public UnityEvent OnColorUpdated;

	private Canvas canvas;

	public FlexibleColorPicker.MainPickingMode mode;

	private FlexibleColorPicker.BufferedColor bufferedColor;

	private Image focusedPicker;

	private FlexibleColorPicker.PickerType focusedPickerType;

	private FlexibleColorPicker.MainPickingMode lastUpdatedMode;

	private bool typeUpdate;

	private bool pickerTexturesStandardized;

	private bool materialsSeperated;

	public Color startingColor;

	private const float HUE_LOOP = 5.9999f;

	public bool staticMode;

	public bool multiInstance;

	public Color color
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
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPointerFocus(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PointerUpdate(BaseEventData e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TypeHex(string input)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FinishTypeHex(string input)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMode(int newMode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMode(FlexibleColorPicker.MainPickingMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SeperateMaterials()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor PickColor(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type, Vector2 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor PickColorMain(FlexibleColorPicker.BufferedColor color, Vector2 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor PickColor1D(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type, Vector2 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor PickColorMain(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.MainPickingMode mode, Vector2 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor PickColor2D(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type1, float value1, FlexibleColorPicker.PickerType type2, float value2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor PickColor1D(FlexibleColorPicker.BufferedColor color, FlexibleColorPicker.PickerType type, float value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor GetDefaultColor(FlexibleColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FlexibleColorPicker.BufferedColor GetDefaultColor(FlexibleColorPicker.MainPickingMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMarkers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMarker(Image picker, FlexibleColorPicker.PickerType type, Vector2 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMarker(Image picker, Vector2 v, bool setX, bool setY)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RectTransform GetMarker(Image picker, string search)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 GetValue(FlexibleColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetValue1D(FlexibleColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 GetValue(FlexibleColorPicker.MainPickingMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateTextures(bool forceUpdate = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateTexture(FlexibleColorPicker.PickerType type, bool standardized)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetGradientMode(FlexibleColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Image GetImage(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateHex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TypeHex(string input, bool finish)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeModeOptions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMode(FlexibleColorPicker.MainPickingMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsPreviewType(FlexibleColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsAlphaType(FlexibleColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsHorizontal(Image image)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSanitizedHex(string input, bool full)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 GetNormalizedPointerPosition(Canvas canvas, RectTransform rect, BaseEventData e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 GetNormScreenSpace(RectTransform rect, BaseEventData e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 GetNormWorldSpace(Canvas canvas, RectTransform rect, BaseEventData e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color HSVToRGB(Vector3 hsv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color HSVToRGB(float h, float s, float v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 RGBToHSV(Color color)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 RGBToHSV(float r, float g, float b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlexibleColorPicker()
	{
		throw null;
	}

	private enum PickerType
	{
		Main,
		R,
		G,
		B,
		H,
		S,
		V,
		A,
		Preview,
		PreviewAlpha
	}

	public enum MainPickingMode
	{
		HS,
		HV,
		SH,
		SV,
		VH,
		VS
	}

	[Serializable]
	private class BufferedColor
	{
		public Color color;

		private float bufferedHue;

		private float bufferedSaturation;

		public float r
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float g
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float b
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float a
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float h
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float s
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float v
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferedColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferedColor(Color color)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferedColor(Color color, float hue, float sat)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferedColor(Color color, FlexibleColorPicker.BufferedColor source)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(Color color)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(Color color, float bufferedHue, float bufferedSaturation)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlexibleColorPicker.BufferedColor PickR(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlexibleColorPicker.BufferedColor PickG(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlexibleColorPicker.BufferedColor PickB(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlexibleColorPicker.BufferedColor PickA(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlexibleColorPicker.BufferedColor PickH(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlexibleColorPicker.BufferedColor PickS(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlexibleColorPicker.BufferedColor PickV(float value)
		{
			throw null;
		}
	}
}
