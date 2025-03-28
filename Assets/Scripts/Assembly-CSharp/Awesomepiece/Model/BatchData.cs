using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class BatchData
	{
		public int x;

		public int y;

		public int unitId;

		public int level;

		public BatchData()
		{
		}

		public BatchData(int x, int y, int unitId, int level = 1)
		{
		}
	}
}
