using System;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
		private readonly ReportProgress mProgressCallback;

		private string mId;

		private bool mIsIncremental;

		private int mCurrentSteps;

		private int mTotalSteps;

		private double mPercentComplete;

		private bool mCompleted;

		private bool mHidden;

		private DateTime mLastModifiedTime;

		private string mTitle;

		private string mRevealedImageUrl;

		private string mUnlockedImageUrl;

		private UnityWebRequest mImageFetcher;

		private Texture2D mImage;

		private string mDescription;

		private ulong mPoints;

		public string id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isIncremental => false;

		public int currentSteps => 0;

		public int totalSteps => 0;

		public double percentCompleted
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public bool completed => false;

		public bool hidden => false;

		public DateTime lastReportedDate => default(DateTime);

		public string title => null;

		public Texture2D image => null;

		public string achievedDescription => null;

		public string unachievedDescription => null;

		public int points => 0;

		internal PlayGamesAchievement()
		{
		}

		internal PlayGamesAchievement(ReportProgress progressCallback)
		{
		}

		internal PlayGamesAchievement(Achievement ach)
		{
		}

		public void ReportProgress(Action<bool> callback)
		{
		}

		private Texture2D LoadImage()
		{
			return null;
		}
	}
}
