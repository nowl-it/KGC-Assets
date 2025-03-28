using UnityEngine;

namespace AwesomeData.Encrypted
{
	public class EncryptedVector2
	{
		private byte[] _valueX;

		private byte[] _valueY;

		private int _keyX;

		private int _keyY;

		public float x => 0f;

		public float y => 0f;

		public EncryptedVector2()
		{
		}

		public EncryptedVector2(Vector2 value)
		{
		}

		public EncryptedVector2(float x, float y)
		{
		}

		public Vector2 GetDecrypted()
		{
			return default(Vector2);
		}

		public static implicit operator Vector2(EncryptedVector2 ev)
		{
			return default(Vector2);
		}

		public static implicit operator EncryptedVector2(Vector2 v)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
