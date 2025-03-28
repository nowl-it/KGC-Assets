using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SearchClanRequestModel
	{
		public string keyword;

		public List<int> tags;

		public int searchStartOffset;
	}
}
