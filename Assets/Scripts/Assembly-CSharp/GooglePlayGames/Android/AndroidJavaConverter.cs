using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Android
{
	internal class AndroidJavaConverter
	{
		internal static DateTime ToDateTime(long milliseconds)
		{
			return default(DateTime);
		}

		internal static int ToLeaderboardVariantTimeSpan(LeaderboardTimeSpan span)
		{
			return 0;
		}

		internal static int ToLeaderboardVariantCollection(LeaderboardCollection collection)
		{
			return 0;
		}

		internal static int ToPageDirection(ScorePageDirection direction)
		{
			return 0;
		}

		internal static Player ToPlayer(AndroidJavaObject player)
		{
			return null;
		}

		internal static GooglePlayGames.BasicApi.PlayerProfile ToPlayerProfile(AndroidJavaObject player)
		{
			return null;
		}

		internal static List<string> ToStringList(AndroidJavaObject stringList)
		{
			return null;
		}

		internal static AndroidJavaObject ToJavaStringList(List<string> list)
		{
			return null;
		}

		internal static FriendsListVisibilityStatus ToFriendsListVisibilityStatus(int playerListVisibility)
		{
			return default(FriendsListVisibilityStatus);
		}

		internal static IUserProfile[] playersBufferToArray(AndroidJavaObject playersBuffer)
		{
			return null;
		}
	}
}
