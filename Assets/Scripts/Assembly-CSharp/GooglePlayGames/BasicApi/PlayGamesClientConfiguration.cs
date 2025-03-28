using System.Collections.Generic;

namespace GooglePlayGames.BasicApi
{
	public struct PlayGamesClientConfiguration
	{
		public class Builder
		{
			private bool mEnableSaveGames;

			private List<string> mScopes;

			private bool mHidePopups;

			private bool mRequestAuthCode;

			private bool mForceRefresh;

			private bool mRequestEmail;

			private bool mRequestIdToken;

			private string mAccountName;

			public Builder EnableSavedGames()
			{
				return null;
			}

			public Builder EnableHidePopups()
			{
				return null;
			}

			public Builder RequestServerAuthCode(bool forceRefresh)
			{
				return null;
			}

			public Builder RequestEmail()
			{
				return null;
			}

			public Builder RequestIdToken()
			{
				return null;
			}

			public Builder SetAccountName(string accountName)
			{
				return null;
			}

			public Builder AddOauthScope(string scope)
			{
				return null;
			}

			public PlayGamesClientConfiguration Build()
			{
				return default(PlayGamesClientConfiguration);
			}

			internal bool HasEnableSaveGames()
			{
				return false;
			}

			internal bool IsRequestingAuthCode()
			{
				return false;
			}

			internal bool IsHidingPopups()
			{
				return false;
			}

			internal bool IsForcingRefresh()
			{
				return false;
			}

			internal bool IsRequestingEmail()
			{
				return false;
			}

			internal bool IsRequestingIdToken()
			{
				return false;
			}

			internal string GetAccountName()
			{
				return null;
			}

			internal string[] getScopes()
			{
				return null;
			}
		}

		public static readonly PlayGamesClientConfiguration DefaultConfiguration;

		private readonly bool mEnableSavedGames;

		private readonly string[] mScopes;

		private readonly bool mRequestAuthCode;

		private readonly bool mForceRefresh;

		private readonly bool mHidePopups;

		private readonly bool mRequestEmail;

		private readonly bool mRequestIdToken;

		private readonly string mAccountName;

		public bool EnableSavedGames => false;

		public bool IsHidingPopups => false;

		public bool IsRequestingAuthCode => false;

		public bool IsForcingRefresh => false;

		public bool IsRequestingEmail => false;

		public bool IsRequestingIdToken => false;

		public string AccountName => null;

		public string[] Scopes => null;

		private PlayGamesClientConfiguration(Builder builder)
		{
			mEnableSavedGames = false;
			mScopes = null;
			mRequestAuthCode = false;
			mForceRefresh = false;
			mHidePopups = false;
			mRequestEmail = false;
			mRequestIdToken = false;
			mAccountName = null;
		}

		public static bool operator ==(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return false;
		}

		public static bool operator !=(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
