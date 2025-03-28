using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class NameTagInventoryResponseModel : ResponseModel
	{
		public List<NameTagResponseModel> nameTagsModel;

		public NameTagResponseModel equippedNameTag;
	}
}
