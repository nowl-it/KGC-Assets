using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BuyGachaConfirmPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public bool processed;

		public BuyResponseModel ret;

		public BuyGachaConfirmPanel _003C_003E4__this;

		internal void _003CBuyFourGacha_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyFourGacha_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BuyGachaConfirmPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

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

	public Image backGround;

	public Sprite[] backGroundImages;

	public ConditionalRoot boxRoot;

	public Text nameText;

	public Image icon;

	public GameObject upObject;

	public Sprite[] stackIcons;

	public Sprite[] stackBGIcons;

	public Image[] stacks;

	public Image[] stackBG;

	public Border border;

	public GameObject[] rewards;

	public Text[] rewardCounts;

	public Price haveKey;

	public Price haveCash;

	public Button buyOneButton;

	public Text buttonOneDesc;

	public Price buyOnePrice;

	public Button buyFourButton;

	public Text buttonFourDesc;

	public Price buyFourPrice;

	private Action _buyCallback;

	private ShopItem _fromShopItem;

	private bool _loading;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(ShopItem from, Action callback)
	{
	}

	public void Reload()
	{
	}

	public void OnClickBuy()
	{
	}

	private void ShowBuyCurrencyPopup()
	{
	}

	public void SetLoading(bool set)
	{
	}

	public void Hide()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyFourGacha_003Ed__34))]
	private void BuyFourGacha()
	{
	}
}
