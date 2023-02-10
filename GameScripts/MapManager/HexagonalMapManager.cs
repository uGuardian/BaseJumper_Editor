using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HexagonalMapManager : SingletonBehavior<HexagonalMapManager>
{
	[Header("Reference & Predefined")]
	[SerializeField]
	private Tilemap _map;

	[SerializeField]
	private Tilemap _mapView;

	public float tileSize;

	public const float zPosFactor = 1.732f;

	public const float xPosFactor = 2f;

	[SerializeField]
	private int _xMax;

	[SerializeField]
	private int _xMin;

	[SerializeField]
	private int _yMax;

	[SerializeField]
	private int _yMin;

	private readonly int[] _xMinBorders;

	private readonly int[] _xMaxBorders;

	[Header("Resources")]
	[SerializeField]
	private HexaTileCustom _customTile;

	private List<HexagonalMapManager.UnitTileList> _unitTileList;

	private List<Vector3Int> _previewCellPosList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected HexagonalMapManager()
	{
		throw null;
	}

	public Vector3Int CenterCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Vector3 CenterPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetMapSetting()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapSize()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetCurrentBorderPos(HexagonalMapManager.WallDirection direction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetUnitInCell(Vector3 worldPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HexagonalMapManager.WallDirection IsWall(Vector3Int cellPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HexagonalMapManager.WallDirection IsWall(Vector3 viewPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HexagonalMapManager.WallDirection IsBoundary(Vector3 viewPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InSameCell(Vector3 p1, Vector3 p2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InSameCell(Vector3Int cellPos1, Vector3Int cellPos2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 ViewToCellWorldPos(Vector3 viewPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CellToWorldPos(Vector3Int cellPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndPreviewTile(Vector3Int cp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalcKnockbackDst(BattleUnitModel self, BattleUnitModel attacker, float knockbackEnergy)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalcKnockbackDst(Vector3 src, Vector3 dst, float knockbackEnergy)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalcKnockbackDst(BattleUnitModel self, Vector3 direction, float knockbackEnergy)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalcMoveDst(BattleUnitModel self, BattleUnitModel mainTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndPreview()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PreviewTiles(BattleUnitModel self, BattleUnitModel target, BattleDiceCardModel card, bool drawTiles)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAngleByCardDirection(Direction unitDir, CardDirection cardDir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCellDistance(Vector3 p1, Vector3 p2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	public enum WallDirection
	{
		NONE,
		UP,
		DOWN,
		LEFT,
		RIGHT
	}

	private class UnitTileList
	{
		public BattleUnitModel model;

		public Vector3Int currTilePos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitTileList()
		{
			throw null;
		}
	}
}
