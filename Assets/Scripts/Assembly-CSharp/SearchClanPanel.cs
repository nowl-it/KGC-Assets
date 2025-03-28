using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SearchClanPanel : MonoBehaviour, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchRecommend_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SearchClanPanel _003C_003E4__this;

		private UniTask<SearchClanResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickFind_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SearchClanPanel _003C_003E4__this;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<SearchClanResponseModel>.Awaiter _003C_003Eu__2;

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
	public Button searchButton;

	[ComponentConnect]
	public Button searchArea;

	[ComponentConnect]
	public LocalizedText searchButtonText;

	[ComponentConnect]
	public InputField nameInputField;

	[ComponentConnect]
	public UIGridView tableView;

	public Dropdown languageDropdown;

	public ConditionalText languageDropdownOpenCond;

	public ConditionalGroup languageDropdownSelectedCond;

	public Button searchTagsArea;

	private bool _languageDropdownInited;

	public MultiSelectDropdown keywordDropdown;

	private bool _keywordDropdownInited;

	public Button createClanButton;

	[FormerlySerializedAs("clanBattleOngoingText")]
	public Text clanRaidOngoingText;

	private List<ClanModel> _searchResult;

	private float _lastSearchTime;

	private string _lastSearchText;

	private List<int> _lastSearchTags;

	private int _nextSearchStartOffset;

	private bool _searching;

	private string _currentLocale;

	public void Show()
	{
	}

	private void InitLanguageDropdown()
	{
	}

	public void ResetLanguageDropdownOption()
	{
	}

	private void InitKeywordDropdown()
	{
	}

	public void OnOpenLanguageDropdown()
	{
	}

	public void OnSelectLanguageDropdown()
	{
	}

	public void OnLanguageDropdownValueChanged()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchRecommend_003Ed__28))]
	public void FetchRecommend()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickFind_003Ed__29))]
	[OnClick("SearchButton", true)]
	public void OnClickFind()
	{
	}

	[OnClick("CreateButton", true)]
	public void OnClickCreate()
	{
	}

	private void HandleSearchResult(SearchClanResponseModel ret)
	{
	}

	private void OnClickClan(int idx)
	{
	}

	public void OnNameInputFieldChanged()
	{
	}
}
