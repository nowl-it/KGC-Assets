using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crystal;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using LeTai.Asset.TranslucentImage;
using UnityEngine;
using UnityEngine.UI;

public class Scene_Base : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public Scene_Base _003C_003E4__this;

		public Action onFetchCompleted;

		internal void _003CFetchNextDay_003Eb__1()
		{
		}

		internal void _003CFetchNextDay_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchNextDay_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Base _003C_003E4__this;

		public Action onFetchCompleted;

		public string xigncodeSeed;

		private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

		private UniTask<Awesomepiece.Model.AuthResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<string>.Awaiter _003C_003Eu__2;

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
	private struct _003CGetCookie_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

		public Scene_Base _003C_003E4__this;

		private UniTask<Awesomepiece.Model.AuthResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CHandleBuyFailMessage_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public string msg;

		public Scene_Base _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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

	[SerializeField]
	private Camera _camera;

	public Canvas baseCanvas;

	public Canvas popupCanvas;

	public Canvas overlayCanvas;

	[NonSerialized]
	public TranslucentImageSource translucentImageSource;

	[ComponentConnect]
	public CanvasGroup loadingPopup;

	public Text loadingPopupText;

	[SerializeField]
	private GameObject _touchBlocker;

	public CenterText centerText;

	[ComponentConnect]
	public Popup popup;

	public Popup popup2;

	public CanvasScaler baseCanvasScaler;

	public CanvasScaler popupCanvasScaler;

	public CanvasScaler overlayCanvasScaler;

	protected float _lastResolution;

	protected bool _fetchTomorrow;

	protected bool _fetchNextSeason;

	public Transform popupCanvasTransform => null;

	public Transform overlayCanvasTransform => null;

	public Camera camera => null;

	protected virtual void Awake()
	{
	}

	protected void Update()
	{
	}

	private void FixResolution()
	{
	}

	protected virtual void OnResolutionChanged(float resolution)
	{
	}

	public void ShowLoading(bool v, string text = "LoadingPopupText")
	{
	}

	public void BlockTouch(bool block)
	{
	}

	protected virtual void SetResolutionImpl(RectTransform canvas, SafeArea safeArea, bool setOnlyTop = false, Image topGradation = null)
	{
	}

	public virtual void OnAdditiveSceneChanged(bool isActiveScene)
	{
	}

	[AsyncStateMachine(typeof(_003CGetCookie_003Ed__31))]
	protected UniTask<string> GetCookie()
	{
		return default(UniTask<string>);
	}

	[AsyncStateMachine(typeof(_003CFetchNextDay_003Ed__32))]
	protected void FetchNextDay(string xigncodeSeed, Action onFetchCompleted)
	{
	}

	public void ToastLevelReqMessage(string contentType)
	{
	}

	[AsyncStateMachine(typeof(_003CHandleBuyFailMessage_003Ed__34))]
	public UniTaskVoid HandleBuyFailMessage(string msg)
	{
		return default(UniTaskVoid);
	}

	public Camera GetTargetRenderCamera(MonoBehaviour obj)
	{
		return null;
	}

	public Camera GetCanvasRenderCamera(Canvas canvas)
	{
		return null;
	}

	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}
}
