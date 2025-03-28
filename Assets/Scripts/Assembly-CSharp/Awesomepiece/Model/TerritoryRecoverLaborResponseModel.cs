using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryRecoverLaborResponseModel : ResponseModel
	{
		public int storedLabor;

		public string lastLaborAt;

		public DateTime lastLaborAt_ => default(DateTime);
	}
}
