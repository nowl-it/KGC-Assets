using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Protocol;

namespace Awesomepiece
{
	public class WebClient
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_0
		{
			[StructLayout(3)]
			private struct _003C_003CReceive_003Eb__0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder _003C_003Et__builder;

				public _003C_003Ec__DisplayClass39_0 _003C_003E4__this;

				private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

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

			public WebClient _003C_003E4__this;

			public byte[] buffer;

			[AsyncStateMachine(typeof(_003C_003CReceive_003Eb__0_003Ed))]
			internal Task _003CReceive_003Eb__0()
			{
				return null;
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CClose_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public WebClient _003C_003E4__this;

			public WebSocketCloseStatus closeStatus;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CConnect_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public WebClient _003C_003E4__this;

			public WebSocketEventDispatcher webSocketEventDispatcher;

			public WebSocketBinaryEventDispatcher webSocketBinaryEventDispatcher;

			public CancellationToken cancellationToken;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CReceive_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public WebClient _003C_003E4__this;

			private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CSend_003Ed__34<T> : IAsyncStateMachine where T : BaseMessage
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public T messageModel;

			public WebClient _003C_003E4__this;

			public bool log;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CSendImpl_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public WebClient _003C_003E4__this;

			private bool _003Clog_003E5__2;

			private ValueTaskAwaiter _003C_003Eu__1;

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
		private struct _003CSendProto_003Ed__36<T> : IAsyncStateMachine where T : IBufferMessage
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Packet.Types.Type type;

			public WebClient _003C_003E4__this;

			public T messageModel;

			public bool log;

			private TaskAwaiter _003C_003Eu__1;

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

		private const int BUFFER_BYTES = 32768;

		private string _serverUri;

		private ClientWebSocket _clientWebSocket;

		private static WebClient _singleton;

		private bool _isValidUri;

		public Action onConnected;

		public Action<WebSocketCloseStatus?> onClosed;

		public Action<BaseMessage, string> onSend;

		public Action<Packet> onSendBinary;

		private readonly Queue<(WebSocketMessageType type, object message)> _receiveQueue;

		private IDisposable _updateHandlerDisposable;

		private IDisposable _closeDisposable;

		private readonly Dictionary<string, Type> _typeDict;

		private readonly MemoryStream _byteStream;

		private WebSocketEventDispatcher _webSocketEventDispatcher;

		private WebSocketBinaryEventDispatcher _webSocketBinaryEventDispatcher;

		private bool _invokeClose;

		private bool _isConnected;

		private int _devPingMs;

		private UniTask? _sendTask;

		private Queue<(WebSocketMessageType, object, bool)> _sendQueue;

		private bool _sendStarted;

		public string serverUri => null;

		public bool isConnected => false;

		public static WebClient Get()
		{
			return null;
		}

		private WebClient()
		{
		}

		public void SetEndPoint(string uri)
		{
		}

		public void AttachToGameEndPoint()
		{
		}

		public void SetDevPing(int ms)
		{
		}

		[AsyncStateMachine(typeof(_003CConnect_003Ed__30))]
		public UniTask<bool> Connect(WebSocketEventDispatcher webSocketEventDispatcher, WebSocketBinaryEventDispatcher webSocketBinaryEventDispatcher, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public void SetEventDispatcher(WebSocketEventDispatcher webSocketEventDispatcher)
		{
		}

		public void SetBinaryEventDispatcher(WebSocketBinaryEventDispatcher webSocketBinaryEventDispatcher)
		{
		}

		[AsyncStateMachine(typeof(_003CClose_003Ed__33))]
		public UniTask<bool> Close(WebSocketCloseStatus closeStatus = WebSocketCloseStatus.NormalClosure)
		{
			return default(UniTask<bool>);
		}

		[AsyncStateMachine(typeof(_003CSend_003Ed__34<>))]
		public UniTaskVoid Send<T>(T messageModel, bool log = false) where T : BaseMessage
		{
			return default(UniTaskVoid);
		}

		public void SendSilently(List<string> serializedMessage)
		{
		}

		[AsyncStateMachine(typeof(_003CSendProto_003Ed__36<>))]
		public UniTaskVoid SendProto<T>(Packet.Types.Type type, T messageModel, bool log = false) where T : IBufferMessage
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSendImpl_003Ed__38))]
		private UniTask SendImpl()
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CReceive_003Ed__39))]
		private UniTaskVoid Receive()
		{
			return default(UniTaskVoid);
		}
	}
}
