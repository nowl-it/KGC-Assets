using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AccessoryInventoryResponseModel : ResponseModel
	{
		public List<AccessoryModel> accessories;
	}
}
