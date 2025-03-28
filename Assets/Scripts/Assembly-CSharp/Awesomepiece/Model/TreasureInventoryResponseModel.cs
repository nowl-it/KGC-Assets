using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TreasureInventoryResponseModel : ResponseModel
	{
		public List<TreasureModel> treasures;
	}
}
