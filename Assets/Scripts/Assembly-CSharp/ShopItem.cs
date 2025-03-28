using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public ShopItem _003C_003E4__this;

		public BuyResponseModel ret;

		internal void _003CBuyProcess_003Eb__0()
		{
		}

		internal bool _003CBuyProcess_003Eb__3(ShopItemModel x)
		{
			return false;
		}

		internal bool _003CBuyProcess_003Eb__4(ShopItemModel x)
		{
			return false;
		}

		internal bool _003CBuyProcess_003Eb__5(ShopItemModel x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyIAP_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShopItem _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShopItem _003C_003E4__this;

		private _003C_003Ec__DisplayClass88_0 _003C_003E8__1;

		private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClick_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShopItem _003C_003E4__this;

		private PackageItem _003CpackageItem_003E5__2;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

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

	public Text upEfficiency;

	public Text nameText;

	public Image itemBox;

	public ClickableShopItemIcon itemIcon;

	public ConditionalImage bgCond;

	public GameObject expBox;

	public Text levelText;

	public Gauge expGauge;

	public ConditionalImage gaugeCond;

	public Text selectExpCountText;

	public GameObject valueBox;

	public Text expValue;

	public ConditionalImage buyButtonCondtionalImage;

	public Price price;

	public GameObject soldOut;

	public GameObject upObject;

	public GameObject showDetailText;

	public GameObject firstBonusObject;

	public Text firstBonusText;

	public Image newUnitTag;

	public GameObject freeIcon;

	public ResourceShopItem resShopItem;

	public ResourceUnit resUnit;

	public ResourceSkin resSkin;

	public ConditionalImage backGround;

	public ConditionalImage partition;

	public int id;

	private int _reaminBuyCount;

	private int _goldPrice;

	private int _unitId;

	private int _exp;

	private int _soul;

	private bool _isFree;

	private ShopItemData _shopItemData;

	private bool _isSoldOut;

	private bool _isAd;

	private bool _isDailyItem;

	private int _dailyIndex;

	private const int UnitExpShopItemId = 100;

	private const int UnitShopItemId = 200;

	protected ShopItemModel _model;

	private bool _awaked;

	private bool _inited;

	public GameObject newObject;

	public GameObject buyCountObject;

	public GameObject popupBg;

	public Text buyCountText;

	private bool _processing;

	public ShopItemModel model => null;

	public int exp => 0;

	public bool isFree => false;

	public bool isAd => false;

	public int goldPrice => 0;

	public int soul => 0;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void Init(ShopItemModel model)
	{
	}

	public virtual void Init(int id)
	{
	}

	public void InitUnit(int unitId)
	{
	}

	public void InitEventPackagePurchaseConfirm(InventoryItem resInventoryItem, float scale = 1.6f)
	{
	}

	private void CheckAlreadyHasCard()
	{
	}

	public void InitUnitExp(int unitId, int exp)
	{
	}

	private void CheckUnitExpFull()
	{
	}

	public void InitSelectUnitExp(int exp)
	{
	}

	public void InitSelectUnitSoul(int soul)
	{
	}

	public void InitDailyShop(ShopItem from)
	{
	}

	public void InitPackage(ResourceShopItem resourceShopItem)
	{
	}

	public void InitUnitSoul(int unitId, int soul)
	{
	}

	public void InitFrom(ShopItem from)
	{
	}

	private void ReloadExp()
	{
	}

	private void ReloadExp(bool gaugeForce)
	{
	}

	private void ReloadSoul(bool gaugeForce)
	{
	}

	public virtual void ReloadPrice()
	{
	}

	public virtual bool CanBuy(int count = 1, bool checkKeyItem = true)
	{
		return false;
	}

	public static bool CanBuy(int price, int cashPrice, int soulItemPrice, bool isFree, bool checkKeyItem)
	{
		return false;
	}

	public void SetOnce()
	{
	}

	public void SetDaily(bool v, int idx)
	{
	}

	public virtual void SetFree(bool v)
	{
	}

	public virtual void SetAd(bool v)
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__84))]
	public void OnClick()
	{
	}

	private void LogOnClick()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyIAP_003Ed__86))]
	public void BuyIAP()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__88))]
	public void BuyProcess()
	{
	}

	public void ShowBuyCurrencyPopup()
	{
	}

	private void LogBuyItem(BuyResponseModel ret)
	{
	}

	public static void GiveItem(ShopItemData shopItemData)
	{
	}

	private void CheckBuyOnlyOnce()
	{
	}

	protected void SetSoldOut(bool v)
	{
	}

	public void ReloadBuyLimitCount(Text text)
	{
	}

	public bool BuyLimitRemain()
	{
		return false;
	}

	public List<InventoryItem> GetInventoryItems()
	{
		return null;
	}
}
