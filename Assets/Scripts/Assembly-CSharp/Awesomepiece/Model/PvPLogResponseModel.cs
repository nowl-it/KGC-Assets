using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PvPLogResponseModel : ResponseModel
	{
		[Serializable]
		public class PvPLogData
		{
			public PvPDeckInfo myDeck;

			public PvPDeckInfo enemyDeck;

			public int myScoreDelta;

			public int enemyScoreDelta;

			public int[] roundResult;
		}

		public List<PvPLogData> logDatas;
	}
}
