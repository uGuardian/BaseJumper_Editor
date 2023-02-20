using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DebugConsoleScript : MonoBehaviour
{
	private const float _defaultHeight = 800f;

	public GameObject ActiveRoot;

	public Text prevText;

	public InputField inputField;

	public Text placeholderTxt;

	public Text currentText;

	public string currentString;

	public Dictionary<string, DebugConsoleScript.DebugCmdParam> dic;

	private List<string> inputLog;

	private string usage;

	private bool _setPos;

	private float _DefaultTimeScale;

	private bool _active;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AppendLine(string text)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetActive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetActive(bool state)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTextRectPos()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChanged(string text)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTextEditEnd(string text)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractComand(string text)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteCommand(string cmd, DebugConsoleScript.DebugCmdParam cmdParam)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInvincible(DebugConsoleScript.DebugCmdParam cmdParam)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvalidParameter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestLog(string log)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddUnitBuf(int id, string keyword, int stack)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddUnitBufAll(string keyword, int stack)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTimeScale(float scale)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHp99()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSuddenDeath()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddEmotionCoin(int positive)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddCardTarget(SephirahType sephirah, int cardId, int targetId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddEmotionCoin(EmotionCoinType type, int count, int targetId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnterCreatureBattle(FloorLevelXmlInfo info, int lv)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveCard(LorId cardId, int targetId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetAllItem()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DebugConsoleScript()
	{
		throw null;
	}

	public static class SephiraParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SephirahType Parse(string sephirah)
		{
			throw null;
		}
	}

	public static class KeywordBufParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static KeywordBuf Parse(string keyword)
		{
			throw null;
		}
	}

	public static class EmotionCoinTypeParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EmotionCoinType Parse(string keyword)
		{
			throw null;
		}
	}

	public enum ParamType
	{
		STRING,
		INT,
		FLOAT,
		BOOL
	}

	public static class ParamParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetString(string p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetInteger(string p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float GetFloat(string p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetBool(string p)
		{
			throw null;
		}
	}

	public class DebugCmdParam
	{
		public List<DebugConsoleScript.ParamType> parameters;

		public List<string> paramValue;

		public bool onlyBattle;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugCmdParam(DebugConsoleScript.ParamType[] param)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugConsoleScript.DebugCmdParam OnlyBattle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckParameterValidate(string[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			
		}
	}

	public class DebugPassive_Invincible : PassiveAbilityBase
	{
		public override string debugDesc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool isInvincible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugPassive_Invincible()
		{
			throw null;
		}
	}
}
