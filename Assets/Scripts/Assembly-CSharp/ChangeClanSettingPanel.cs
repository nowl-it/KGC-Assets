using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ChangeClanSettingPanel : PopupPanel, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public int role;

		internal bool _003CChangeRoleNameImpl_003Eb__0(ClanModel.RoleName x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CChangeRoleNameImpl_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int role;

		public ChangeClanSettingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		public string name;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickSave_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ChangeClanSettingPanel _003C_003E4__this;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__2;

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

	public GameObject closeIcon;

	[ComponentConnect]
	public Button saveButton;

	[ComponentConnect]
	public ClanMark clanMark;

	[ComponentConnect]
	public InputField noticeField;

	[ComponentConnect]
	public InputPopup _changeClanRoleNamePopup;

	public ClanRoleNameSettingItem[] _clanRoleNameSettingItems;

	private ClanModel _clan;

	private int _markId;

	private int _language;

	private List<int> _keywords;

	private readonly List<ClanModel.RoleName> _changedRoleNames;

	public Dropdown languageDropdown;

	public ConditionalText languageDropdownOpenCond;

	private bool _languageDropdownInited;

	public MultiSelectDropdown keywordDropdown;

	private bool _keywordDropdownInited;

	private string _currentLocale;

	public void ShowWithoutCloseIcon()
	{
	}

	public override void Show()
	{
	}

	private void InitLanguageDropdown()
	{
	}

	private void InitKeywordDropdown()
	{
	}

	public void OnOpenLanguageDropdown()
	{
	}

	public void OnCloseLanguageDropdown()
	{
	}

	private void ReloadRoleNames()
	{
	}

	[OnClick("ChangeMarkButton", true)]
	public void OnClickChangeMark()
	{
	}

	public void ShowChangeRoleNamePopup(int role)
	{
	}

	[AsyncStateMachine(typeof(_003CChangeRoleNameImpl_003Ed__26))]
	private void ChangeRoleNameImpl(int role, string name)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickSave_003Ed__27))]
	[OnClick("SaveButton", true)]
	public void OnClickSave()
	{
	}

	public override bool Close()
	{
		return false;
	}
}
