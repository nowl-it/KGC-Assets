using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class GachaResult
	{
		public string type;

		public int unitId;

		public int count;

		public ResourceShopItem.Type type_ => default(ResourceShopItem.Type);
	}
}
