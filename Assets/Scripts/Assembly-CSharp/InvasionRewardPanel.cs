using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class InvasionRewardPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandleBuyPass_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ResourceShopItem passShopItem;

		public InvasionRewardPanel _003C_003E4__this;

		private int _003CpassIndex_003E5__2;

		private UniTask<Awesomepiece.Model.InvasionRewardDatasResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTutorialReceiveReward_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public InvasionRewardPanel _003C_003E4__this;

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

	[SerializeField]
	private FlexibleUIElements _passTabElements;

	[SerializeField]
	private GameObject _passMissionTab;

	[SerializeField]
	private LayoutDistributor _missionTabsLayoutDistributor;

	[SerializeField]
	private UITableView _missionItemView;

	[SerializeField]
	private LayoutDistributor _bottomLayoutDistributor;

	[SerializeField]
	private GameObject _passPreviewObject;

	[SerializeField]
	private Text _passTitleText;

	[SerializeField]
	private FlexibleUIElements _passRewardPreviewElements;

	[SerializeField]
	private Button _buyPassButton;

	[SerializeField]
	private Text _passPriceText;

	[SerializeField]
	private Sprite[] _invasionModeIcons;

	private BuyInvasionPassPanel _buyPassPanel;

	public const int ThemePerPass = 5;

	public const int HardModeDivider = 2;

	private int _currentPassIndex;

	private bool _passAvailable;

	private InvasionRewardPanelPassTab _currentPassTab;

	public BuyInvasionPassPanel buyPassPanel => null;

	public void Show(int fromTheme)
	{
	}

	public void OnClickTab(int passIndex, InvasionRewardPanelPassTab tab)
	{
	}

	public static int GetPassCount(bool unlockedHardMode)
	{
		return 0;
	}

	public static int GetReceivableRewardCount()
	{
		return 0;
	}

	public static int GetReceivableRewardCount(int passIndex)
	{
		return 0;
	}

	private void SetMissionItem(int index, GameObject go)
	{
	}

	private (int, int) GetThemeDifficultyByMissionItemIndex(int index)
	{
		return default((int, int));
	}

	public void ReloadMissionItems()
	{
	}

	public void ReloadCurrentPassTabBadge()
	{
	}

	public void ReloadPassPreview(ResourceShopItem resShopItem, int passIndex)
	{
	}

	public bool TryGetPassShopItem(int index, out ResourceShopItem resShopItem)
	{
		resShopItem = null;
		return false;
	}

	public void OnClickBuyPassButton()
	{
	}

	public void ShowBuyPassPanel(int pass)
	{
	}

	[AsyncStateMachine(typeof(_003CHandleBuyPass_003Ed__32))]
	public void HandleBuyPass(ResourceShopItem passShopItem)
	{
	}

	public RectTransform GetTutorialRewardFocusRectTransform()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COnClickTutorialReceiveReward_003Ed__34))]
	public UniTask OnClickTutorialReceiveReward()
	{
		return default(UniTask);
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public static (int, int) GetStartEndThemesByPassIndex(int index)
	{
		return default((int, int));
	}

	public static int ThemeIdToPassIndex(int themeId)
	{
		return 0;
	}
}
