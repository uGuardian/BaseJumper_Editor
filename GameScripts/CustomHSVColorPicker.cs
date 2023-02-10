using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomHSVColorPicker : MonoBehaviour
{
	public Image[] pickerImages;

	[SerializeField]
	private TextMeshProUGUI[] colorGaugeTexts;

	public UnityEvent OnColorUpdated;

	private Canvas canvas;

	public Color startColor;

	private CustomHSVColorPicker.BufferedColor bufferedColor;

	private Image focusedPicker;

	private CustomHSVColorPicker.PickerType focusedPickerType;

	private bool typeUpdate;

	private bool pickerTexturesStandardized;

	private bool materialsSeperated;

	private const float HUE_LOOP = 5.9999f;

	public bool staticMode;

	public bool multiInstance;

	private int currentPicker;

	[Header("Events")]
	public UnityEvent XEvent;

	public UnityEvent YEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStartColor(Color color)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnXEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnYEvent()
	{
		throw null;
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
	public void SetControllerCurrentPicker(int i)
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
	private void VectorUpdate(Vector2 v)
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
	private void SeperateMaterials()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomHSVColorPicker.BufferedColor PickColor(CustomHSVColorPicker.BufferedColor color, CustomHSVColorPicker.PickerType type, Vector2 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomHSVColorPicker.BufferedColor PickColor1D(CustomHSVColorPicker.BufferedColor color, CustomHSVColorPicker.PickerType type, Vector2 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomHSVColorPicker.BufferedColor PickColor2D(CustomHSVColorPicker.BufferedColor color, CustomHSVColorPicker.PickerType type1, float value1, CustomHSVColorPicker.PickerType type2, float value2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomHSVColorPicker.BufferedColor PickColor1D(CustomHSVColorPicker.BufferedColor color, CustomHSVColorPicker.PickerType type, float value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomHSVColorPicker.BufferedColor GetDefaultColor(CustomHSVColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomHSVColorPicker.BufferedColor GetDefaultColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMarkers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMarker(Image picker, CustomHSVColorPicker.PickerType type, Vector2 v)
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
	private Vector2 GetValue(CustomHSVColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetValue1D(CustomHSVColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateTextures(bool forceUpdate = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateTexture(CustomHSVColorPicker.PickerType type, bool standardized)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetGradientMode(CustomHSVColorPicker.PickerType type)
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
	private static bool IsPreviewType(CustomHSVColorPicker.PickerType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsAlphaType(CustomHSVColorPicker.PickerType type)
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
	public CustomHSVColorPicker()
	{
		throw null;
	}

	private enum PickerType
	{
		H,
		S,
		V
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
		public BufferedColor(Color color, CustomHSVColorPicker.BufferedColor source)
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
		public CustomHSVColorPicker.BufferedColor PickH(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomHSVColorPicker.BufferedColor PickS(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomHSVColorPicker.BufferedColor PickV(float value)
		{
			throw null;
		}
	}
}
