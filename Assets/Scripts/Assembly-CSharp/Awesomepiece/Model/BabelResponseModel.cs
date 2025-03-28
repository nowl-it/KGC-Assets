using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class BabelResponseModel : ResponseModel
	{
		[Serializable]
		public class BabelModel
		{
			public int id;

			public bool available;

			public int maxClearedFloor;

			public List<int> boughtPasses;

			public DateTime availableAt;
		}

		public List<BabelModel> babels;
	}
}
