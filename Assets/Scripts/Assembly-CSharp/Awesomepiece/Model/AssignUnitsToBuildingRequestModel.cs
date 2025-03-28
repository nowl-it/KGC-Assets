using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AssignUnitsToBuildingRequestModel
	{
		public int posIndex;

		public List<int> units;
	}
}
