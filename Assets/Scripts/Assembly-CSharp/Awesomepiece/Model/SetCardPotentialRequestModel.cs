using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SetCardPotentialRequestModel : ResponseModel
	{
		public int presetIdx;

		public int idx;

		public int unitId;

		public int potential;
	}
}
