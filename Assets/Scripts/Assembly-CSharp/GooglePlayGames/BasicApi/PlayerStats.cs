namespace GooglePlayGames.BasicApi
{
	public class PlayerStats
	{
		private static float UNSET_VALUE;

		private bool mValid;

		private int mNumberOfPurchases;

		private float mAvgSessionLength;

		private int mDaysSinceLastPlayed;

		private int mNumberOfSessions;

		private float mSessPercentile;

		private float mSpendPercentile;

		private float mSpendProbability;

		private float mChurnProbability;

		private float mHighSpenderProbability;

		private float mTotalSpendNext28Days;

		public bool Valid => false;

		public int NumberOfPurchases => 0;

		public float AvgSessionLength => 0f;

		public int DaysSinceLastPlayed => 0;

		public int NumberOfSessions => 0;

		public float SessPercentile => 0f;

		public float SpendPercentile => 0f;

		public float SpendProbability => 0f;

		public float ChurnProbability => 0f;

		public float HighSpenderProbability => 0f;

		public float TotalSpendNext28Days => 0f;

		public PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days)
		{
		}

		public PlayerStats()
		{
		}

		public bool HasNumberOfPurchases()
		{
			return false;
		}

		public bool HasAvgSessionLength()
		{
			return false;
		}

		public bool HasDaysSinceLastPlayed()
		{
			return false;
		}

		public bool HasNumberOfSessions()
		{
			return false;
		}

		public bool HasSessPercentile()
		{
			return false;
		}

		public bool HasSpendPercentile()
		{
			return false;
		}

		public bool HasChurnProbability()
		{
			return false;
		}

		public bool HasHighSpenderProbability()
		{
			return false;
		}

		public bool HasTotalSpendNext28Days()
		{
			return false;
		}
	}
}
