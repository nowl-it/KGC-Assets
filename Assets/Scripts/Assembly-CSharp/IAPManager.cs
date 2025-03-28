using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.Purchasing;

public class IAPManager : IStoreListener
{
	private struct PendedPurchaseData
	{
		public string productId;

		public int targetUnit;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public ResourceShopItem buyUnfinishedIAPItem;

		internal bool _003CBuyProduct_003Eb__0(Product x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public ResourceShopItem purchasedItem;

		public BuyResponseModel ret;

		internal bool _003CRequestBuyItem_003Eb__1(ShopItemModel x)
		{
			return false;
		}

		internal bool _003CRequestBuyItem_003Eb__2(ShopItemModel x)
		{
			return false;
		}

		internal bool _003CRequestBuyItem_003Eb__3(ShopItemModel x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProduct_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public IAPManager _003C_003E4__this;

		public int targetUnit;

		public ResourceShopItem resShopItem;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		private Scene_Base _003CcurrentScene_003E5__2;

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
	private struct _003CFetchRestoreNeededIAPs_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

		public IAPManager _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private UniTask<GetRestoreNeededIAPsResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003CRequestBuyItem_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IAPManager _003C_003E4__this;

		public IAPBuyRequestModel model;

		public Product product;

		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		public bool forceRestore;

		private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CRestorePurchases_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IAPManager _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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

	private static readonly IAPManager _singleton;

	private IStoreController _storeController;

	private IExtensionProvider _storeExtensionProvider;

	private ResourceShopItem _purchasedItem;

	private bool _buyRequested;

	private int _targetUnit;

	private List<int> _restoreNeededIAPs;

	private List<int> _restoreNeededIAPUnitIds;

	private readonly HashSet<string> _processedTransactionsAtThisSession;

	private readonly List<PendedPurchaseData> _pendedPurchaseDatas;

	public ResourceShopItem purchasedItem => null;

	public static IAPManager Get()
	{
		return null;
	}

	public void Init()
	{
	}

	private void InitializePurchasing()
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error, string message)
	{
	}

	private bool IsInitialized()
	{
		return false;
	}

	public Product GetProduct(string productId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CBuyProduct_003Ed__21))]
	public UniTask BuyProduct(ResourceShopItem resShopItem, int targetUnit = -1)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CRestorePurchases_003Ed__22))]
	public void RestorePurchases()
	{
	}

	public void ProcessPendedPurchases()
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		return default(PurchaseProcessingResult);
	}

	private void RequestBuyItem(Product product, string signedData, string signature, bool forceRestore = false)
	{
	}

	[AsyncStateMachine(typeof(_003CRequestBuyItem_003Ed__26))]
	private void RequestBuyItem(Product product, bool forceRestore, IAPBuyRequestModel model)
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchRestoreNeededIAPs_003Ed__28))]
	private UniTask<ResponseModel> FetchRestoreNeededIAPs()
	{
		return default(UniTask<ResponseModel>);
	}
}
