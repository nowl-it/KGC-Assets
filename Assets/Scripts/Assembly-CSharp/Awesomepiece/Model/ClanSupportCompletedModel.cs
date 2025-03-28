using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanSupportCompletedModel
	{
		public bool supportCompleted;

		public int supportedUnit;

		public int count;

		public int maxCount;

		public List<ClanSupporterModel> supporters;
	}
}
