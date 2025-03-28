using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PostReceiveRequestModel
	{
		public int postId;

		public bool receiveAll;

		public int targetUnit;
	}
}
