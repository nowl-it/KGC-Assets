using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AccessoryUpgradePanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnUpgrade_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AccessoryUpgradePanel _003C_003E4__this;

		public List<InventoryItem> inventories;

		private float _003CprevMainStat_003E5__2;

		private List<AccessoryModel.SubStatKeyValues> _003CprevSubStats_003E5__3;

		private int _003CprevLevel_003E5__4;

		private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

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
	private AccessoryUIItem _accessoryItem;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _rarityText;

	[SerializeField]
	private Text _selectAccessoryButtonText;

	[SerializeField]
	private AccessoryStatUI _mainStatUI;

	[SerializeField]
	private AccessoryStatUI _subStatUIPrefab;

	[SerializeField]
	private RectTransform _subStatUIsRoot;

	private List<AccessoryStatUI> _subStatUIs;

	[SerializeField]
	private Text _mainStatUpgradePreviewArrow;

	[SerializeField]
	private Text _addSubStatCountText;

	[SerializeField]
	private GameObject _upgradedStatsPreviewBox;

	[SerializeField]
	private UpgradableUI _upgradableUI;

	[SerializeField]
	private Image _upgradeAccessoryItemFlash;

	public Button tutorialUpgradeButton;

	private AccessoryModel _accessory;

	private TreasureModel _equippedTreasure;

	private List<Tween> _upgradeEffectTweens;

	private Sequence _accessoryItemWhiteFlashSequence;

	private bool _requestProcessing;

	public Button subStatUIButton => null;

	public Button expGaugeButton => null;

	public Button materialItemsRootButton => null;

	public Button autoSelectButton => null;

	public void Show(AccessoryModel accessory)
	{
	}

	private void OnDisable()
	{
	}

	private void Reload(bool updateSubStats = true)
	{
	}

	[AsyncStateMachine(typeof(_003COnUpgrade_003Ed__30))]
	public void OnUpgrade(List<InventoryItem> inventories)
	{
	}

	private void ShowUpgradeEffects(int prevLevel, int curLevel)
	{
	}

	public void OnValueChanged()
	{
	}

	public void SelectUpgradeAccessory()
	{
	}

	private void ClearUpgradeEffectTweens()
	{
	}
}
