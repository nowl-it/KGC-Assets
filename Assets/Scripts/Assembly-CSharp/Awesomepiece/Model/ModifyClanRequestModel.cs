using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ModifyClanRequestModel
	{
		public int markId;

		public int joinType;

		public string name;

		public string notice;

		public string intro;

		public int language;

		public List<int> keywords;
	}
}
