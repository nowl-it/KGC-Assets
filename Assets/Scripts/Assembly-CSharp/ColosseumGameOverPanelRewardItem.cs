using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumGameOverPanelRewardItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ColosseumGameOverPanelRewardItem _003C_003E4__this;

		private bool _003CfreeBuyEnabled_003E5__2;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _rewardRoundText;

	[SerializeField]
	private ConditionalImage _chestImage;

	[SerializeField]
	private ClickableShopItemIcon _rewardGoldText;

	[SerializeField]
	private ClickableShopItemIcon[] _rewardHardModeTokenText;

	[SerializeField]
	private ClickableShopItemIcon _rewardPassPointText;

	[SerializeField]
	private ClickableShopItemIcon _rewardExpText;

	[SerializeField]
	private ClickableShopItemIcon _rewardClanExpText;

	[SerializeField]
	private ClickableShopItemIcon _rewardEventTokenText;

	[SerializeField]
	private ConditionalGroup _getRewardButtonConditionals;

	[SerializeField]
	private Text _heartCostText;

	[SerializeField]
	private Image _heartIcon;

	[SerializeField]
	private Image _blockImage;

	[SerializeField]
	private Text _blockText;

	[SerializeField]
	private GameObject _rewardUpgradeBorder;

	[SerializeField]
	private Button _heartRewardButton;

	[SerializeField]
	private Button _freeRewardButton;

	private int _rewardIndex;

	private int _gameEndRewardIndex;

	private ResourceColosseumRankTier _resTier;

	private bool _isLocked;

	private bool _rewardUpgrade;

	private List<Reward> _rewards;

	private bool _buyed;

	public void Set(int rewardIndex, ResourceColosseumRankTier resTier, bool isLocked)
	{
	}

	private void Reload(int rewardIndex, ResourceColosseumRankTier resTier, bool isLocked)
	{
	}

	public void ReloadPrice()
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__26))]
	public void OnClick()
	{
	}

	private void ReloadButtonState()
	{
	}
}
