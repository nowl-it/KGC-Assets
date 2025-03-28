using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ArtifactOptions
	{
		[Serializable]
		public struct Targets
		{
			public List<int> idx;
		}

		public List<Targets> targets;

		public List<string> types;

		public List<int> lvs;
	}
}
