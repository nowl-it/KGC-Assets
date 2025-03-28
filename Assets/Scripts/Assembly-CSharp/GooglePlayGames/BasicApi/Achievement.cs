using System;

namespace GooglePlayGames.BasicApi
{
	public class Achievement
	{
		private static readonly DateTime UnixEpoch;

		private string mId;

		private bool mIsIncremental;

		private bool mIsRevealed;

		private bool mIsUnlocked;

		private int mCurrentSteps;

		private int mTotalSteps;

		private string mDescription;

		private string mName;

		private long mLastModifiedTime;

		private ulong mPoints;

		private string mRevealedImageUrl;

		private string mUnlockedImageUrl;

		public bool IsIncremental
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int CurrentSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TotalSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsUnlocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsRevealed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime LastModifiedTime
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public ulong Points
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public string RevealedImageUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UnlockedImageUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}
	}
}
