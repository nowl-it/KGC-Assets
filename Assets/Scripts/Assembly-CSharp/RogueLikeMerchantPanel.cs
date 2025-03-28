using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeMerchantPanel : MonoBehaviour, IClosable
{
	[Serializable]
	public struct ItemData
	{
		public Scene_Game.SaveItemData saveItemData;

		[NonSerialized]
		public Item item;

		public int unitId;

		public int unitLevel;

		public short buyCountLeft;

		public short price;

		public bool isSoldOut => false;

		public ItemData(Item item, int buyCountLeft, int price)
		{
			saveItemData = null;
			this.item = null;
			unitId = 0;
			unitLevel = 0;
			this.buyCountLeft = 0;
			this.price = 0;
		}

		public ItemData(int unitId, int unitLevel, int price)
		{
			saveItemData = null;
			item = null;
			this.unitId = 0;
			this.unitLevel = 0;
			buyCountLeft = 0;
			this.price = 0;
		}

		private bool Equals(ItemData other)
		{
			return false;
		}
	}

	public struct OwnItemData
	{
		public ItemData itemData;

		public ItemUnit itemUnit;

		public GameUnit equippedBy;

		public OwnItemData(ItemData itemData, ItemUnit itemUnit, GameUnit equippedBy)
		{
			this.itemData = default(ItemData);
			this.itemUnit = null;
			this.equippedBy = null;
		}
	}

	[Serializable]
	public struct MerchantData
	{
		public Constants.RogueLikeItemType type;

		public List<ItemData> items;

		public short rerollCount;

		public short rerollPrice;

		public bool isBuilding5Merchant;

		public MerchantData(Constants.RogueLikeItemType type, List<ItemData> items, short rerollPrice, bool isBuilding5Merchant)
		{
			this.type = default(Constants.RogueLikeItemType);
			this.items = null;
			rerollCount = 0;
			this.rerollPrice = 0;
			this.isBuilding5Merchant = false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckSellTogether_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public ResourceItem resItem;

		private int _003CsellTogether_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickBuy_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RogueLikeMerchantItem item;

		public RogueLikeMerchantPanel _003C_003E4__this;

		public int index;

		private OwnItemData _003CitemData_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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

	private static RogueLikeMerchantPanel _instance;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Image _merchantImage;

	[SerializeField]
	private Text _merchantDialog;

	[SerializeField]
	private Text _goldText;

	[SerializeField]
	private GameObject _itemPrefab;

	[SerializeField]
	private Transform _itemsRoot;

	[SerializeField]
	private Button _rerollButton;

	[SerializeField]
	private Text _rerollPriceText;

	[SerializeField]
	private Text _rerollFreeText;

	private List<ItemData> _itemDatas;

	private List<OwnItemData> _ownItemDatas;

	private MerchantData _merchantData;

	private static List<MerchantData> _savedMerchantsDatas;

	private List<RogueLikeMerchantItem> _items;

	[SerializeField]
	private List<Text> _buyTexts;

	[SerializeField]
	private List<Text> _sellTexts;

	[SerializeField]
	private GameObject _noItemsToSell;

	[ComponentConnect]
	public Text goldEffect;

	private bool _isSellMode;

	private int _goldEffectCount;

	private bool _setBG;

	private int _tempMaxOwnGold;

	private int _tempTotalUsedGold;

	private float _lastCallTime;

	public static RogueLikeMerchantPanel Instance => null;

	private void SetBG()
	{
	}

	public void Show(string title, string desc, Constants.RogueLikeItemType type, bool isBuilding5Merchant)
	{
	}

	private void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__33))]
	public void OnClickBuy(RogueLikeMerchantItem item, int index)
	{
	}

	private void GetItemListIntoItemDatas(Constants.RogueLikeItemType type)
	{
	}

	public static void ClearItemLists()
	{
	}

	private int GetPrice(Item item, bool sell = false)
	{
		return 0;
	}

	private int GetPrice(ResourceItem resItem)
	{
		return 0;
	}

	private int GetHeroPrice(int cardLevel)
	{
		return 0;
	}

	public void OnClickReroll()
	{
	}

	private void ReloadPrices()
	{
	}

	public void OnClickTab(int index)
	{
	}

	private int GetMaxRerollCount()
	{
		return 0;
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	[AsyncStateMachine(typeof(_003CCheckSellTogether_003Ed__45))]
	public UniTask<bool> CheckSellTogether(ResourceItem resItem)
	{
		return default(UniTask<bool>);
	}

	public static List<MerchantData> GetSavedMerchantDatas()
	{
		return null;
	}

	public static void LoadSavedMerchantDatas(List<MerchantData> datas)
	{
	}

	public void ShowAddGold(int gold)
	{
	}

	private void ShowAddGoldInner(int gold, Text goldEffectText = null)
	{
	}
}
