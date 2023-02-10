using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[ExecuteInEditMode]
[DisallowMultipleComponent]
public class SpriteOutline : MonoBehaviour
{
	public const string RESOURCE_DIR = "Assets/SpriteOutline/Resources/";

	public const string RESOURCE_EXT = ".outline";

	public const string IMAGE_EXT = ".outline.png";

	[FormerlySerializedAs("outlineSize")]
	[Tooltip("Adjusts the total thickness of the outline, in pixels.")]
	[Range(1f, 20f)]
	public int size;

	[FormerlySerializedAs("outlineBlur")]
	[Tooltip("Blurs the outline by gradually fading the number of outer edges equivalent to the specified value.")]
	[Range(0f, 19f)]
	public int blurSize;

	[FormerlySerializedAs("outlineColor")]
	[Tooltip("Defines the color (and overall opacity) of the outline.")]
	public Color color;

	[Tooltip("Adjusts the opacity of *only* the blurred edges.")]
	[Range(0f, 1f)]
	public float blurAlphaMultiplier;

	[Tooltip("Adjusts how quickly the blurred edges fade away.")]
	[Range(0f, 1f)]
	public float blurAlphaChoke;

	[Tooltip("Reverses the fade direction of the blurring (from the inside out to the outside in).")]
	public bool invertBlur;

	[Tooltip("Defines the minimum amount of opacity a sprite pixel must have for an outline to be placed around it.")]
	[Range(0.01f, 1f)]
	public float alphaThreshold;

	[Tooltip("Adds a buffer of transparent pixels between the sprite(s) and the outline.")]
	[Range(0f, 20f)]
	public int buffer;

	[Tooltip("Include child sprites in the outline.")]
	public bool includeChildren;

	[Tooltip("Filter child sprites on a per-layer basis (only those that belong to one of the checked layers will be included).")]
	public LayerMask childLayers;

	[Tooltip("Exclude child sprites by their game object name.")]
	public string[] ignoreChildNames;

	[Tooltip("Change how the outline is sorted (either the lowest sorting order - 1; or the highest z-axis value + 1).")]
	public SpriteOutline.SortMethod sortMethod;

	[Tooltip("Auto-regenerate the outline when the main sprite frame changes (does not track child sprites).")]
	public bool isAnimated;

	[Tooltip("Use the pre-rendered image of the outline instead of rendering in real time (you must \"Export\" the outline first).")]
	public bool useExportedFrame;

	[Tooltip("Override the file name of the exported outline (use to allow multiple game objects sharing the same name to export unique outlines).")]
	public string customFrameName;

	[Tooltip("Auto-regenerate the outline on game start.")]
	public bool generatesOnStart;

	private SpriteRenderer spriteRenderer;

	private Image image;

	private Sprite sprite;

	private GameObject outline;

	private SpriteRenderer outlineSpriteRenderer;

	private Image outlineImage;

	private Material material;

	private Texture2D texture;

	private float _boundsMinX;

	private float _boundsMinY;

	private float _boundsMaxX;

	private float _boundsMaxY;

	private Vector3 _pos;

	private Vector3 _scale;

	private Vector2 _anchor;

	private Rect _textureRect;

	private bool _cachedUseExportedFrame;

	private bool _shouldRegenerateMaterial;

	private SpriteRenderer _sortingSpriteRenderer;

	private Dictionary<int, Sprite> _cachedOutlineSprites;

	private Dictionary<int, Vector2> _cachedOutlineAnchors;

	private int _lastSpriteFrameId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryGetOutline()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryGetSprite()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Regenerate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupTexture()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearTexture()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTexture(GameObject instance, Sprite sprite)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetOffsetX(GameObject instance, Sprite sprite)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetOffsetY(GameObject instance, Sprite sprite)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTransformValues(Vector3 position, Quaternion rotation, Vector3 scale)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldIgnoreSprite(GameObject instance, Sprite sprite)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SortOutline(float zOffset = 1f, int? sortingOrder = null, int? sortingLayerId = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Show()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Hide()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Export()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetSanitizedName(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Log(string message, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogError(string error, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpriteOutline()
	{
		throw null;
	}

	public enum SortMethod
	{
		SORTING_ORDER,
		Z_AXIS
	}
}
