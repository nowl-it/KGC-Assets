using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AccessorySetStateRequestModel
	{
		public List<int> targetIds;

		public int state;
	}
}
