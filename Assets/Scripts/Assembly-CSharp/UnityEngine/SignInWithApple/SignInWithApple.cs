using System;
using System.Collections.Concurrent;
using AOT;

namespace UnityEngine.SignInWithApple
{
	public class SignInWithApple : MonoBehaviour
	{
		public struct CallbackArgs
		{
			public UserCredentialState credentialState;

			public UserInfo userInfo;

			public string error;
		}

		public delegate void Callback(CallbackArgs args);

		private delegate void LoginCompleted(int result, UserInfo info);

		private delegate void GetCredentialStateCompleted(UserCredentialState state);

		private static Callback s_LoginCompletedCallback;

		private static Callback s_CredentialStateCallback;

		private static readonly ConcurrentQueue<Action> s_EventQueue;

		[Header("Event fired when login is complete.")]
		public SignInWithAppleEvent onLogin;

		[Header("Event fired when the users credential state has been retrieved.")]
		public SignInWithAppleEvent onCredentialState;

		[Header("Event fired when there is an error.")]
		public SignInWithAppleEvent onError;

		[MonoPInvokeCallback(typeof(LoginCompleted))]
		private static void LoginCompletedCallback(int result, UserInfo info)
		{
		}

		[MonoPInvokeCallback(typeof(GetCredentialStateCompleted))]
		private static void GetCredentialStateCallback(UserCredentialState state)
		{
		}

		public void GetCredentialState(string userID)
		{
		}

		public void GetCredentialState(string userID, Callback callback)
		{
		}

		private void GetCredentialStateInternal(string userID)
		{
		}

		public void Login()
		{
		}

		public void Login(Callback callback)
		{
		}

		private void LoginInternal()
		{
		}

		private void TriggerOnLoginEvent(CallbackArgs args)
		{
		}

		private void TriggerCredentialStateEvent(CallbackArgs args)
		{
		}

		private void TriggerOnErrorEvent(CallbackArgs args)
		{
		}

		public void Update()
		{
		}
	}
}
