using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Coffee.UIEffects;
using Cysharp.Threading.Tasks;
using LeTai.Asset.TranslucentImage;
using UnityEngine;
using UnityEngine.SignInWithApple;
using UnityEngine.UI;

public class Scene_Login : Scene_Base
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public UniTask<ResponseModel> emptyUniTask;

		public bool loginFailed;

		public List<(ResponseModel response, Action<ResponseModel> handleFunc, int handlingPriority)> responseHandleFuncPair;

		public Scene_Login _003C_003E4__this;

		public int loginProgression;

		public Vector2 gaugeOriginalSize;

		public int loginProgressGoal;

		public List<UniTask> tasks;

		internal UniTask<ResponseModel> _003CFetchInfo_003Eb__5()
		{
			return default(UniTask<ResponseModel>);
		}

		internal UniTask<ResponseModel> _003CFetchInfo_003Eb__8()
		{
			return default(UniTask<ResponseModel>);
		}

		internal bool _003CFetchInfo_003Eb__11()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public UIShiny shiny;

		public Scene_Login _003C_003E4__this;

		public string token;

		public bool processed;

		public bool networkIssue;

		internal float _003CLogin_003Eb__0()
		{
			return 0f;
		}

		internal void _003CLogin_003Eb__1(float x)
		{
		}

		internal void _003CLogin_003Eb__2(bool yes, string pw)
		{
		}

		internal void _003CLogin_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public bool processed;

		public bool networkIssue;

		public Scene_Login _003C_003E4__this;

		public string id;

		internal void _003CAuth_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAccountTransferConfirm_003Ed__122 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		public int accountType;

		public string code;

		private string _003Cuid_003E5__2;

		private bool _003CuseUserIdInAccountTransfer_003E5__3;

		private UniTask<TransferResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CApplyLoginSceneIllustData_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

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
	private struct _003CAuth_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		public string id;

		private _003C_003Ec__DisplayClass88_0 _003C_003E8__1;

		private UniTask<string>.Awaiter _003C_003Eu__1;

		private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003CAwake_003Ed__70 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		private UniTask<(bool hasResultLeft, ServerListResponse result)>.Awaiter _003C_003Eu__1;

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
	private struct _003CCheckUseAssetBundle_003Ed__74 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<PatchFolderResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003CFetchInfo_003Ed__103 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		private _003C_003Ec__DisplayClass103_0 _003C_003E8__1;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchInfoLegacy_003Ed__104 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		private Queue<Func<UniTask<bool>>> _003CfetchQueue_003E5__2;

		private int _003CloginProgression_003E5__3;

		private int _003CloginProgressGoal_003E5__4;

		private Vector2 _003CgaugeOriginalSize_003E5__5;

		private UniTask.Awaiter _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

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

	[CompilerGenerated]
	private sealed class _003CLoadAfterAssetBundleImpl_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Scene_Login _003C_003E4__this;

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
		public _003CLoadAfterAssetBundleImpl_003Ed__76(int _003C_003E1__state)
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLogin_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		public string token;

		private _003C_003Ec__DisplayClass86_0 _003C_003E8__1;

		private UniTask<string>.Awaiter _003C_003Eu__1;

		private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003CReAuth_003Ed__111 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CRegister_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Login _003C_003E4__this;

		public string id;

		private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

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

	public static Scene_Login Instance;

	[ComponentConnect]
	public GameObject audioController;

	[ComponentConnect]
	public Text statusText;

	[ComponentConnect]
	public CanvasGroup loginButtonGroup;

	[ComponentConnect]
	public Button testLoginButton;

	[ComponentConnect]
	public Button googleLoginButton;

	[ComponentConnect]
	public SignInWithApple appleLoginButton;

	[ComponentConnect]
	public Button gameCenterLoginButton;

	[ComponentConnect]
	public InputField testLoginIdInput;

	[ComponentConnect]
	public Button guestLoginButton;

	[ComponentConnect]
	public Button appleGuestLoginButton;

	[ComponentConnect]
	public InputField userNameInput;

	[ComponentConnect]
	public Dropdown userNameDropDown;

	[ComponentConnect("UserNameInput", false)]
	public ConditionalRoot userNameInputCondition;

	[ComponentConnect]
	public InputField castleNameInput;

	[ComponentConnect]
	public Dropdown castleNameDropDown;

	[ComponentConnect("CastleNameInput", false)]
	public ConditionalRoot castleNameInputCondition;

	[ComponentConnect]
	public Text userNamePreview;

	[ComponentConnect]
	public Text castleNamePreview;

	[ComponentConnect]
	public GameObject nameConfirmPanel;

	public Text userNamePreviewConfirm;

	public Text castleNamePreviewConfirm;

	[ComponentConnect]
	public GameObject loginPanel;

	[ComponentConnect]
	public GameObject registerPanel;

	[ComponentConnect]
	public Button serverButton;

	[ComponentConnect]
	public GameObject selectServerPanel;

	[ComponentConnect]
	public Button serverButtonPrefab;

	[ComponentConnect]
	public Text serverNameText;

	[ComponentConnect]
	public Text firebaseToken;

	[ComponentConnect]
	public GameObject termsPanel;

	public Toggle[] termAgreements;

	public GameObject nightPushAggrement;

	public Toggle nightPushAggrementToggle;

	[ComponentConnect]
	public Button termAgreeButton;

	[ComponentConnect]
	public LocalePanel localePanel;

	[ComponentConnect]
	public Text localeText;

	[ComponentConnect]
	public ConditionalGroup localeConditional;

	[ComponentConnect]
	public InputPopup inputPopup;

	[SerializeField]
	private GameObject _castleBG;

	[SerializeField]
	private TranslucentImage _bgBlur;

	[ComponentConnect]
	public Image logo;

	[ComponentConnect]
	public Text version;

	[SerializeField]
	private Image _illustImage;

	[SerializeField]
	private Image[] _effectImages;

	[SerializeField]
	private GameObject _effectParticle;

	[SerializeField]
	private Image _bottomColoredImage;

	[SerializeField]
	private UIGradient _bottomColoredGradationImage;

	[SerializeField]
	private ParticleSystem _screenParticle;

	[SerializeField]
	private GameObject _loginProgressBar;

	[SerializeField]
	private Image _loginProgressBarGauge;

	[SerializeField]
	private Text _loginProgressText;

	[SerializeField]
	private Sprite[] _loginIllusts;

	private Localizer.Locale _locale;

	private int _accountType;

	private string _appleId;

	private static bool _socialInited;

	private const int MAX_NAME_LENGTH = 10;

	private bool _stopLogin;

	private bool _reAuthNow;

	private bool _devBuildConfirmed;

	private bool _authing;

	private bool _waitSocialLogin;

	private bool _fetchInfoCompleted;

	public static LoginSceneIllustDataResponseModel loginSceneIllustData;

	private readonly List<(string host, string name, bool ssl)> _hosts;

	private readonly List<ServerData> _infraServerDatas;

	private ServerData _defaultInfraRankingServerData;

	private bool _openingShown;

	private float _authTime;

	private bool _serverSelectInitialized;

	private bool _set;

	private int _hitCount;

	private bool _heroPrefabCached;

	public bool waitSocialLogin
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[AsyncStateMachine(typeof(_003CAwake_003Ed__70))]
	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Opening(Action action = null)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckUseAssetBundle_003Ed__74))]
	private void CheckUseAssetBundle()
	{
	}

	private void LoadAfterAssetBundle(bool success)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAfterAssetBundleImpl_003Ed__76))]
	private IEnumerator LoadAfterAssetBundleImpl()
	{
		return null;
	}

	private void OnResourceLoadCompleted()
	{
	}

	private void Start()
	{
	}

	[AsyncStateMachine(typeof(_003CApplyLoginSceneIllustData_003Ed__79))]
	private void ApplyLoginSceneIllustData()
	{
	}

	private void SocialInit()
	{
	}

	private void GoogleInit()
	{
	}

	private void GameCenterInit()
	{
	}

	private void ShowStatusText(string text)
	{
	}

	private void AutoLogin()
	{
	}

	private void ReadyToAuth(bool showComment = true)
	{
	}

	[AsyncStateMachine(typeof(_003CLogin_003Ed__86))]
	private void Login(string token)
	{
	}

	[AsyncStateMachine(typeof(_003CAuth_003Ed__88))]
	private void Auth(string id)
	{
	}

	private void HandleAuthResponse(AuthResponseModel ret)
	{
	}

	private bool CheckName()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CRegister_003Ed__91))]
	private void Register(string id)
	{
	}

	public void OnClickTestLogin()
	{
	}

	public void OnClickGoogleLogin()
	{
	}

	public void OnClickAppleLogin()
	{
	}

	public void OnClickGameCenterLogin()
	{
	}

	public void OnClickGuestLogin()
	{
	}

	public void OnNameChange()
	{
	}

	public void OnNameChangeEnd()
	{
	}

	public void OnClickRegister()
	{
	}

	public void OnClickNameConfirm()
	{
	}

	private string GetGoogleUserId()
	{
		return null;
	}

	public void OnClickNameCancel()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchInfo_003Ed__103))]
	private void FetchInfo()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchInfoLegacy_003Ed__104))]
	private void FetchInfoLegacy()
	{
	}

	public void OnClickOfflineLobby()
	{
	}

	public void OnClickOfflineTest()
	{
	}

	public void OnClickServerButton()
	{
	}

	public void OnSelectServer(int idx)
	{
	}

	[AsyncStateMachine(typeof(_003CReAuth_003Ed__111))]
	private void ReAuth()
	{
	}

	private bool CheckError(AuthResponseModel ret)
	{
		return false;
	}

	private void NetworkIssue()
	{
	}

	public void OnClickTestHit()
	{
	}

	public void OnClickCloseRegister()
	{
	}

	public void OnClickTerms(int idx)
	{
	}

	public void OnAgreeTerm()
	{
	}

	public void OnClickAgreeTerms()
	{
	}

	public void OnClickLocaleButton()
	{
	}

	public void OnSelectLocale(Localizer.Locale locale)
	{
	}

	[AsyncStateMachine(typeof(_003CAccountTransferConfirm_003Ed__122))]
	public void AccountTransferConfirm(string code, int accountType)
	{
	}

	public void OpenTermsPanel()
	{
	}

	private void ReloadTermsPanel()
	{
	}

	public new void Update()
	{
	}

	public void ShowLogin(bool v)
	{
	}

	private void AutoRegister()
	{
	}

	private void ShowRegister()
	{
	}

	private void ShowServerError()
	{
	}

	private void ReloadLoginPanel(bool show)
	{
	}

	private void CacheHeroPrefab()
	{
	}

	public void SetFirebaseToken()
	{
	}

	public void OnClickFirebaseToken()
	{
	}
}
