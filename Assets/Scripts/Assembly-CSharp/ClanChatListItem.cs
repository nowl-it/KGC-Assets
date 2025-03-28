using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanChatListItem : MonoBehaviour, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickDeleteChat_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanChatListItem _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003COnClickSupport_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanChatListItem _003C_003E4__this;

		public bool all;

		private UniTask<ClanSupportResponseModel>.Awaiter _003C_003Eu__1;

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

	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public ConditionalRootGroup condRootGroup;

	[ComponentConnect]
	public GameObject playerChat;

	[ComponentConnect]
	public GameObject systemChat;

	[ComponentConnect]
	public PlayerProfile playerProfile;

	[ComponentConnect]
	public Image masterIcon;

	[ComponentConnect]
	public Image subMasterIcon;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text chatText;

	[ComponentConnect]
	public Text timeText;

	[ComponentConnect]
	public Border chatBalloon;

	[ComponentConnect]
	public GameObject deleteButton;

	[ComponentConnect]
	public Text systemText;

	[ComponentConnect]
	public GameObject supportBalloon;

	[ComponentConnect]
	public Text unitNameText;

	[ComponentConnect]
	public Text supportChatText;

	[ComponentConnect]
	public Image unitImage;

	[ComponentConnect]
	public Text unitCountText;

	[ComponentConnect]
	public Gauge supportGauge;

	[ComponentConnect]
	public Button supportButton;

	[ComponentConnect]
	public Button supportAllButton;

	[ComponentConnect]
	public Text supportTimeText;

	[ComponentConnect]
	public GameObject bossBalloon;

	[ComponentConnect]
	public Text bossNameText;

	[ComponentConnect]
	public Text bossChatText;

	[ComponentConnect]
	public Image bossImage;

	[ComponentConnect]
	public ConditionalImage bossFrame;

	[ComponentConnect]
	public Text bossTierText;

	[ComponentConnect]
	public Text bossTimeText;

	private ClanChatModel _chatModel;

	private static Font _font;

	private bool _sending;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(ClanChatModel chatModel)
	{
	}

	private void ReloadCurExp()
	{
	}

	public static int GetRowHeight(ClanChatModel chatModel)
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003COnClickSupport_003Ed__37))]
	[OnClick("SupportButton", true)]
	public void OnClickSupport(bool all)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDeleteChat_003Ed__38))]
	[OnClick("DeleteButton", true)]
	public void OnClickDeleteChat()
	{
	}

	public void OnClickProfile()
	{
	}

	public void OnClickBoss()
	{
	}
}
