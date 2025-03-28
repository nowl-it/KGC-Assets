using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SeasonPassEventBoosterResponseModel : ResponseModel
	{
		public int dailyMaxCount;

		public int currentCount;

		public string eventStartAtDate;

		public string eventEndAtDate;

		public DateTime eventStartAtDate_ => default(DateTime);

		public DateTime eventEndAtDate_ => default(DateTime);
	}
}
