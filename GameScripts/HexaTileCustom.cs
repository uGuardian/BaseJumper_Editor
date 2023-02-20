using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "New BattleMap Tile", menuName = "Tiles/BattleMap Tile")]
[Serializable]
public class HexaTileCustom : TileBase
{
	public BattleUnitModel unitModel;

	public Sprite defaultSprite;

	public Color defaultColor;

	public Tile.ColliderType defaultColliderType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshTile(Vector3Int position, ITilemap tilemap)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HexaTileCustom()
	{
		throw null;
	}
}
