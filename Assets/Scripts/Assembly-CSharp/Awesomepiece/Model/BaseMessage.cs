using System;

namespace Awesomepiece.Model
{
	public class BaseMessage : IBinarySerializer
	{
		public static int UniqueIdCounter;

		public int id;

		public int clientId;

		public string name;

		public string msg;

		public static BaseMessage SuccessfullyReceived(int id)
		{
			return null;
		}

		public static BaseMessage EnterGame()
		{
			return null;
		}

		public static BaseMessage Ping()
		{
			return null;
		}

		public static BaseMessage Pong()
		{
			return null;
		}

		public static BaseMessage ReadyToReenter()
		{
			return null;
		}

		public virtual int GetByteSize()
		{
			return 0;
		}

		public virtual void BinarySerialize(byte[] buffer, ref int offset)
		{
		}

		public virtual void BinaryDeserialize(Span<byte> buffer, ref int offset)
		{
		}

		public bool IsUserInputMessage()
		{
			return false;
		}
	}
}
