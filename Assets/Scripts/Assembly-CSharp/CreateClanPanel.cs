using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;

public class CreateClanPanel : PopupPanel, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickCreate_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CreateClanPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<Awesomepiece.Model.CreateClanResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003COnClickNameCheck_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CreateClanPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.ClanResponseModel>.Awaiter _003C_003Eu__1;

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

	[ComponentConnect]
	public InputField nameField;

	[ComponentConnect]
	public ClanMark clanMark;

	[ComponentConnect]
	public Text priceText;

	[ComponentConnect]
	public Button createButton;

	public Toggle[] joinTypeToggles;

	public Dropdown languageDropdown;

	public ConditionalText languageDropdownOpenCond;

	private bool _languageDropdownInited;

	public MultiSelectDropdown keywordDropdown;

	private bool _keywordDropdownInited;

	private string _currentLocale;

	private int _currentMark;

	private int _joinType;

	public override void Show()
	{
	}

	private void InitLanguageDropdown()
	{
	}

	private void InitKeywordDropdown()
	{
	}

	[OnClick("ChangeMarkButton", true)]
	public void OnClickChangeMark()
	{
	}

	[OnClick("NameCheckButton", true)]
	[AsyncStateMachine(typeof(_003COnClickNameCheck_003Ed__17))]
	public void OnClickNameCheck()
	{
	}

	public void OnOpenLanguageDropdown()
	{
	}

	public void OnCloseLanguageDropdown()
	{
	}

	public void OnJoinTypeToggle()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickCreate_003Ed__21))]
	[OnClick("CreateButton", true)]
	public void OnClickCreate()
	{
	}
}
