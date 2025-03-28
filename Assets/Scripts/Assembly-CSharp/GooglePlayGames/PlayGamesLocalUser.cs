using System;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
	{
		internal PlayGamesPlatform mPlatform;

		private string emailAddress;

		private PlayerStats mStats;

		public IUserProfile[] friends => null;

		public bool authenticated => false;

		public bool underage => false;

		public new string userName => null;

		public new string id => null;

		public new bool isFriend => false;

		public new UserState state => default(UserState);

		public new string AvatarURL => null;

		public string Email => null;

		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
			: base(null, null, null)
		{
		}

		public void Authenticate(Action<bool> callback)
		{
		}

		public void Authenticate(Action<bool, string> callback)
		{
		}

		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		public void LoadFriends(Action<bool> callback)
		{
		}

		public string GetIdToken()
		{
			return null;
		}

		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}
	}
}
