using System;
using CodeStage.AntiCheat.ObscuredTypes;

namespace AwesomeData.Encrypted
{
	public class EncryptedInt : IFormattable, IEquatable<EncryptedInt>, IComparable<EncryptedInt>, IComparable<int>, IComparable
	{
		private byte[] _value;

		private int _key;

		public EncryptedInt()
		{
		}

		public EncryptedInt(int value)
		{
		}

		public int GetDecrypted()
		{
			return 0;
		}

		public static implicit operator int(EncryptedInt ei)
		{
			return 0;
		}

		public static implicit operator EncryptedInt(int i)
		{
			return null;
		}

		public static implicit operator ObscuredInt(EncryptedInt ef)
		{
			return default(ObscuredInt);
		}

		public static implicit operator EncryptedInt(ObscuredInt of)
		{
			return null;
		}

		public int CompareTo(EncryptedInt other)
		{
			return 0;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public bool Equals(EncryptedInt other)
		{
			return false;
		}

		public int CompareTo(int other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
