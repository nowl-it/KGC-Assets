using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BankPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuyCashMine_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BankPanel _003C_003E4__this;

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
	private struct _003COnClickBuyGoldMine_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BankPanel _003C_003E4__this;

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

	public static BankPanel Instance;

	public TabManager tabManager;

	public GameObject goldTab;

	public GameObject cashTab;

	public Text goldTitleText;

	public Text cashTitleText;

	private int currentGoldTier;

	private int currentCashTier;

	private int currentGoldReserve;

	private int currentCashReserve;

	private ResourceShopItem _resourceGoldShopItem;

	private ResourceShopItem _resourceCashShopItem;

	public Gauge goldReserveGauge;

	public Gauge cashReserveGauge;

	public Text goldEfficiencyText;

	public Text cashEfficiencyText;

	public Text goldReserveText;

	public Text cashReserveText;

	public Text goldButtonText;

	public Text cashButtonText;

	public Price goldPrice;

	public Price cashPrice;

	public void Awake()
	{
	}

	public void Show()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuyGoldMine_003Ed__24))]
	public void OnClickBuyGoldMine()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuyCashMine_003Ed__25))]
	public void OnClickBuyCashMine()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
