using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeBuildingPackagePanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuy_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RogueLikeBuildingPackagePanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private RectTransform[] _arrowButtons;

	[SerializeField]
	private RogueLikeBuildingItem _targetBuildingItem;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text[] _descTexts;

	[SerializeField]
	private List<ImageTextPair> _runePairs;

	[Header("Reward Cell")]
	[Space(20f)]
	[SerializeField]
	private Text _buyDescText;

	[SerializeField]
	private Text[] _buyDescTexts;

	[SerializeField]
	private GameObject _buyDescTextsRoot;

	[SerializeField]
	private GameObject _rewardsRoot;

	[SerializeField]
	private ClickableShopItemIcon[] _rewardItems;

	[SerializeField]
	private Button _buyButton;

	[SerializeField]
	private Text _discountText;

	[SerializeField]
	private Text _priceText;

	[SerializeField]
	private RuneInfoPanel _runeInfoPanel;

	private int dlc;

	private int _currentTier;

	private ResourceInventoryItem _resInventoryItem;

	private ResourceBuilding _resBuilding;

	private ResourceShopItem _targetShopItem;

	private List<ResourceItem> _runes;

	private void Awake()
	{
	}

	public void Show(int dlc)
	{
	}

	public void Reload()
	{
	}

	private void ReloadBuilding()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__24))]
	public void OnClickBuy()
	{
	}

	public void OnClickArrow(int idx)
	{
	}

	public void OnClickRuneInfo(int idx)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
