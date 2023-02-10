using System;
using System.Runtime.CompilerServices;

namespace CustomInvitation
{
	public class CustomId : IEquatable<CustomId>, IComparable<CustomId>
	{
		public readonly int id;

		public readonly string packageId;

		public const string OriginId = "@origin";

		public static readonly CustomId None;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomId(string packageId, int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CustomId other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator ==(CustomId lhs, CustomId rhs)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator !=(CustomId lhs, CustomId rhs)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CompareTo(CustomId other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CustomId()
		{
			throw null;
		}
	}
}
