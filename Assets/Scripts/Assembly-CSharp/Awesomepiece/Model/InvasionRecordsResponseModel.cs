using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class InvasionRecordsResponseModel : ResponseModel
	{
		public InvasionDifficultyRecord[] difficultyRecords;
	}
}
