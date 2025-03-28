using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CreateClanRequestModel
	{
		public string name;

		public int markId;

		public int joinType;

		public int language;

		public List<int> keywords;
	}
}
