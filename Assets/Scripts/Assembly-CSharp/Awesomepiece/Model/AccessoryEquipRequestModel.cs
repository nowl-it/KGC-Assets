using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AccessoryEquipRequestModel
	{
		public List<int> targetIds;

		public int unitId;
	}
}
