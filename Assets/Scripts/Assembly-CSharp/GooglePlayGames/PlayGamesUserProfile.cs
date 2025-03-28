using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesUserProfile : IUserProfile
	{
		[CompilerGenerated]
		private sealed class _003CLoadImage_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayGamesUserProfile _003C_003E4__this;

			private UnityWebRequest _003Cwww_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadImage_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private string mDisplayName;

		private string mPlayerId;

		private string mAvatarUrl;

		private bool mIsFriend;

		private bool mImageLoading;

		private Texture2D mImage;

		public string userName => null;

		public string id => null;

		public string gameId => null;

		public bool isFriend => false;

		public UserState state => default(UserState);

		public Texture2D image => null;

		public string AvatarURL => null;

		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl, bool isFriend)
		{
		}

		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadImage_003Ed__23))]
		internal IEnumerator LoadImage()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		private void setAvatarUrl(string avatarUrl)
		{
		}
	}
}
