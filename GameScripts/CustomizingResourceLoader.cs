using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using Workshop;

public class CustomizingResourceLoader : Singleton<CustomizingResourceLoader>
{
	private Vector2Int _resSize;

	private CustomizedAppearance customAppearancePrefab;

	private List<FaceResourceSet> _eyeResources;

	private List<FaceResourceSet> _browResources;

	private List<FaceResourceSet> _mouthResources;

	private List<HairResourceSet> _frontHairResources;

	private List<HairResourceSet> _rearHairResources;

	private Sprite[] headResources;

	private Dictionary<int, SpecialCustomizedAppearance> _specialCustomPrefabDic;

	private Dictionary<string, WorkshopSkinData> _skinData;

	private bool loaded;

	private string InternalCustomDir
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string ExternalFaceNormalFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string ExternalFaceAttackFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string ExternalFaceHitFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string ExternalFaceSideAttackFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalCustomDir
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalEyeDir
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalBrowDir
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalMouthDir
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalFrontHairDir
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalHairDefaultFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalFrontHairSideFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalRearHairDir
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalRearHairSideFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private string ExternalRearHairSideBackFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WorkshopSkinData GetWorkshopSkinData(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsExistWorkshopSkinData(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WorkshopSkinData GetWorkshopSkinData(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<WorkshopSkinData> GetWorkshopSkinDataAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadWorkshopCustomSkinData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Sprite> LoadAllResourceSprite(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadExternalData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<FaceResourceSet> GetExternalFaceSetList(string dirPath)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<HairResourceSet> GetExternalHairSetList(string dirPath, bool rear)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dictionary<string, Sprite> GetExternalSpriteSet(DirectoryInfo dir, string[] targetName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Sprite> LoadAllSpriteFromExternalFile(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sprite LoadSpriteFromExternalFile(string fullPath, Vector2Int size)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<FaceResourceSet> CreateFaceResourceSet(Sprite[] normal, Sprite[] atk, Sprite[] hit, Sprite[] atk_side)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<HairResourceSet> CreateHairResourceSet(Sprite[] def, Sprite[] side_front, Sprite[] side_back)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sprite GetSprite(Sprite[] srcAry, int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizedAppearance CreateCustomizedAppearance(UnitCustomizingData customData, Transform parent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FaceResourceSet GetEyeResourceSet(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FaceResourceSet GetBrowResourceSet(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FaceResourceSet GetMouthResourceSet(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetFrontHairSprite(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetFrontHairSideSprite(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetRearHairSprite(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetRearHairSideSprite(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetRearHairSideFrontLayerSprite(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetHeadSprite(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int NumberOfCustomizingResources(CustomizingLookType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int NumberOfEye()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int NumberOfBrow()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int NumberOfMouth()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight, bool mipmap = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizingResourceLoader()
	{
		throw null;
	}
}
