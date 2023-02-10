using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIIconManager : MonoBehaviour
	{
		[SerializeField]
		private UIIconManager.IconSet[] _iconSet;

		private Dictionary<UIIconManager.IconType, UIIconManager.IconSet> _dic;

		public static UIIconManager Manager
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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIIconManager.IconSet GetIcon(UIIconManager.IconType iconType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIIconManager()
		{
			throw null;
		}

		public enum IconType
		{
			Weapon_melee,
			Weapon_range,
			Armor,
			Slash,
			Penetrate,
			Hit,
			Guard,
			Evasion,
			Counter,
			HP,
			SpeedDice,
			Break,
			SoulCard,
			Speed,
			SlashResist,
			PenetrateResist,
			HitResist,
			KnockbackResist,
			Enhance
		}

		public enum HsvType
		{
			Slash,
			Penetrate,
			Hit,
			Guard,
			Evasion,
			Counter
		}

		[Serializable]
		public class IconSet
		{
			public string type;

			public Sprite icon;

			public Color color;

			public Sprite iconGlow;

			public Color colorGlow;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public IconSet()
			{
				throw null;
			}
		}
	}
}
