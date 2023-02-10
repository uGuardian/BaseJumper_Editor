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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AppendLine(string text)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetActive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetActive(bool state)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTextRectPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChanged(string text)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTextEditEnd(string text)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractComand(string text)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteCommand(string cmd, DebugConsoleScript.DebugCmdParam cmdParam)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInvincible(DebugConsoleScript.DebugCmdParam cmdParam)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvalidParameter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestLog(string log)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddUnitBuf(int id, string keyword, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddUnitBufAll(string keyword, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTimeScale(float scale)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHp99()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSuddenDeath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddEmotionCoin(int positive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddCardTarget(SephirahType sephirah, int cardId, int targetId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddEmotionCoin(EmotionCoinType type, int count, int targetId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnterCreatureBattle(FloorLevelXmlInfo info, int lv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveCard(LorId cardId, int targetId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetAllItem()
	{
		throw null;
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
			throw null;
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
