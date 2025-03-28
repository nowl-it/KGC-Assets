using UnityEngine;

namespace AwesomeData.Encrypted
{
	public class EncryptedVector3
	{
		private byte[] _valueX;

		private byte[] _valueY;

		private byte[] _valueZ;

		private int _keyX;

		private int _keyY;

		private int _keyZ;

		public float x => 0f;

		public float y => 0f;

		public float z => 0f;

		public EncryptedVector3(Vector3 value)
		{
		}

		public Vector3 GetDecrypted()
		{
			return default(Vector3);
		}

		public static implicit operator Vector3(EncryptedVector3 ev)
		{
			return default(Vector3);
		}

		public static implicit operator EncryptedVector3(Vector3 v)
		{
			return null;
		}
	}
}
