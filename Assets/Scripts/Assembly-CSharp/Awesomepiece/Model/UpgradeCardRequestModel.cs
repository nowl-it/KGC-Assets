using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class UpgradeCardRequestModel
	{
		public int cardId;

		public List<int> candies;
	}
}
