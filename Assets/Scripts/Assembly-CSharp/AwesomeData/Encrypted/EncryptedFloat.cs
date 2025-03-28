using System;
using CodeStage.AntiCheat.ObscuredTypes;

namespace AwesomeData.Encrypted
{
	public class EncryptedFloat : IFormattable, IEquatable<EncryptedFloat>, IComparable<EncryptedFloat>, IComparable<float>, IComparable
	{
		private byte[] _value;

		private int _key;

		public EncryptedFloat()
		{
		}

		public EncryptedFloat(float value)
		{
		}

		public float GetDecrypted()
		{
			return 0f;
		}

		public static implicit operator float(EncryptedFloat ef)
		{
			return 0f;
		}

		public static implicit operator EncryptedFloat(float i)
		{
			return null;
		}

		public static implicit operator ObscuredFloat(EncryptedFloat ef)
		{
			return default(ObscuredFloat);
		}

		public static implicit operator EncryptedFloat(ObscuredFloat of)
		{
			return null;
		}

		public int CompareTo(EncryptedFloat other)
		{
			return 0;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public bool Equals(EncryptedFloat other)
		{
			return false;
		}

		public int CompareTo(float other)
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
