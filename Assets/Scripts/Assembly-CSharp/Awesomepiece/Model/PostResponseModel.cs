using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PostResponseModel : ResponseModel
	{
		[Serializable]
		public class PostData
		{
			public int id;

			public string type;

			public string title;

			public string text;

			public string rewardType;

			public int rewardId;

			public int rewardAmount;

			public string untilAt;

			public DateTime untilAt_ => default(DateTime);
		}

		public List<PostData> posts;
	}
}
