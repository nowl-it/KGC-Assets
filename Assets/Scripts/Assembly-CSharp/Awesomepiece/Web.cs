using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.Networking;

namespace Awesomepiece
{
	public class Web
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDelete_003Ed__14<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public string json;

			public string accessToken;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDelete_003Ed__15<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public string json;

			public string endPoint;

			public string accessToken;

			private bool _003Cretry_003E5__2;

			private string _003Curl_003E5__3;

			private UnityWebRequest _003Cwww_003E5__4;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__3;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGet_003Ed__7<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public string accessToken;

			public bool useSystemSerializeFunc;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGet_003Ed__8<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public bool useSystemSerializeFunc;

			public string endPoint;

			public string accessToken;

			private bool _003Cretry_003E5__2;

			private string _003Curl_003E5__3;

			private UnityWebRequest _003Cwww_003E5__4;

			private T _003Cresponse_003E5__5;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__3;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGet_003Ed__9<T> : IAsyncStateMachine where T : new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string endPoint;

			public string uri;

			public List<(string name, string value)> customHeaders;

			public bool useSystemSerializeFunc;

			private string _003Curl_003E5__2;

			private UnityWebRequest _003Cwww_003E5__3;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPost_003Ed__10<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public string json;

			public string accessToken;

			public bool useSystemSerializeFunc;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPost_003Ed__11<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public string json;

			public bool useSystemSerializeFunc;

			public string endPoint;

			public string accessToken;

			private bool _003Cretry_003E5__2;

			private string _003Curl_003E5__3;

			private UnityWebRequest _003Cwww_003E5__4;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__3;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPut_003Ed__12<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public string json;

			public string accessToken;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPut_003Ed__13<T> : IAsyncStateMachine where T : ResponseModel, new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string uri;

			public string json;

			public string endPoint;

			public string accessToken;

			private bool _003Cretry_003E5__2;

			private string _003Curl_003E5__3;

			private UnityWebRequest _003Cwww_003E5__4;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__3;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static string _endPoint;

		public static string rankingServerEndPoint;

		public static string infraRankingServerEndPoint;

		private static int _delayMillisecond;

		public static void SetEndPoint(string host, bool ssl = false)
		{
		}

		public static string GetRankingServerEndPoint()
		{
			return null;
		}

		private static bool HandleErrorCode(string uri, ResponseModel response)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CGet_003Ed__7<>))]
		public static UniTask<T> Get<T>(string uri, string accessToken, bool useSystemSerializeFunc = false) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CGet_003Ed__8<>))]
		public static UniTask<T> Get<T>(string endPoint, string uri, string accessToken, bool useSystemSerializeFunc = false) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CGet_003Ed__9<>))]
		public static UniTask<T> Get<T>(string endPoint, string uri, List<(string name, string value)> customHeaders, bool useSystemSerializeFunc = false) where T : new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CPost_003Ed__10<>))]
		public static UniTask<T> Post<T>(string uri, string json, string accessToken, bool useSystemSerializeFunc = false) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CPost_003Ed__11<>))]
		public static UniTask<T> Post<T>(string endPoint, string uri, string json, string accessToken, bool useSystemSerializeFunc = false) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CPut_003Ed__12<>))]
		public static UniTask<T> Put<T>(string uri, string json, string accessToken) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CPut_003Ed__13<>))]
		public static UniTask<T> Put<T>(string endPoint, string uri, string json, string accessToken) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CDelete_003Ed__14<>))]
		public static UniTask<T> Delete<T>(string uri, string json, string accessToken) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CDelete_003Ed__15<>))]
		public static UniTask<T> Delete<T>(string endPoint, string uri, string json, string accessToken) where T : ResponseModel, new()
		{
			return default(UniTask<T>);
		}
	}
}
