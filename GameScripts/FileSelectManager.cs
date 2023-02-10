using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FileSelectManager : MonoBehaviour
{
	private static FileSelectManager _instance;

	public static Vector2Int defaultResSize;

	public static Vector2Int motionResSize;

	[Header("UI")]
	public Color Selected;

	public Color MouseOver;

	public Color FileNotFound;

	public Color FileFound;

	protected FileSelectButton _currentSelected;

	public static FileSelectManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickButton(FileSelectButton button)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSelected(FileSelectButton button)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LoadSprite(string path, out Sprite sprite)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LoadMotionSprite(string path, out Sprite sprite)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sprite LoadSpriteFromPath(string path, Vector2Int size)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight, bool mipmap = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FileSelectManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FileSelectManager()
	{
		throw null;
	}
}
