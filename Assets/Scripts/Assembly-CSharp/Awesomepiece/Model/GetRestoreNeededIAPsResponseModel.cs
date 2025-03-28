using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class GetRestoreNeededIAPsResponseModel : ResponseModel
	{
		public List<int> shopItemIds;

		public List<int> unitIds;
	}
}
