using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class FlagInventoryResponseModel : ResponseModel
	{
		public List<FlagResponseModel> flagsModel;

		public FlagResponseModel equipedFlag;
	}
}
