using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class RewardBoxInventoryPanel : PopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickOpen_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RewardBoxInventoryPanel _003C_003E4__this;

		private UniTask<UseRewardBoxInventoryItemResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _titleText;

	[SerializeField]
	private ClickableShopItemIcon _rewardBoxItem;

	[SerializeField]
	private Text _rewardBoxDescText;

	[SerializeField]
	private Text _rewardsCategoryText;

	[SerializeField]
	[Space(20f)]
	private RectTransform _rewardItemsRoot;

	[SerializeField]
	private ClickableShopItemIcon _rewardItemPrefab;

	private List<ClickableShopItemIcon> _rewardItems;

	[SerializeField]
	private ConditionalGroup _buttonCond;

	[SerializeField]
	[Space(20f)]
	private List<UIFitter> _uiFitters;

	[SerializeField]
	[Space(20f)]
	private GachaResultTable _gachaResultTable;

	[SerializeField]
	private GameObject _probablityInfoButton;

	private ResourceInventoryItem _rewardBoxInventory;

	private ResourceRewardBoxInventoryData _resRewardBoxData;

	private int _selectCount;

	private int _remainCount;

	private bool[] _selectIdx;

	private int _lastSelectedIdx;

	private bool _requestProcessing;

	public void Show(ResourceInventoryItem rewardBoxInventory)
	{
	}

	private void Reload()
	{
	}

	private void ReloadBoxItem()
	{
	}

	private void ReloadElements()
	{
	}

	private void SelectRewardItem(ClickableShopItemIcon icon, int index)
	{
	}

	private void ReloadCategoryText()
	{
	}

	private void ReloadButtonState()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickOpen_003Ed__25))]
	public void OnClickOpen()
	{
	}

	private void ShowResultPanel(RewardListResponseData rewardListResponse)
	{
	}

	public void CloseResultPanel()
	{
	}

	public void ShowPercentageTable()
	{
	}

	public override bool Close()
	{
		return false;
	}
}
