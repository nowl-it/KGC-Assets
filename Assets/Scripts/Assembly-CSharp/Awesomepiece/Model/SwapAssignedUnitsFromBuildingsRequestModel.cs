using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SwapAssignedUnitsFromBuildingsRequestModel
	{
		public List<int> toAssignedUnits;

		public int fromPosIndex;

		public int toPosIndex;

		public int fromUnitId;

		public int toUnitId;
	}
}
