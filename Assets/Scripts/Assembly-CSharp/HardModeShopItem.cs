using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class HardModeShopItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public HardModeShopItem _003C_003E4__this;

		private UniTask<int>.Awaiter _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

		private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__3;

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

	public ClickableShopItemIcon itemIcon;

	public Image frameImage;

	public Text itemName;

	public Text remainCount;

	public Button buyButton;

	public ImageTextPair pricePair;

	public GameObject soldOutObject;

	public Text soldOutText;

	public GameObject lockObject;

	public Text lockText;

	private ResourceShopItem _resShopItem;

	private int _unitId;

	public void Set(ShopItemModel item, int tokenLevel)
	{
	}

	public void OnClickBuy()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__14))]
	private void BuyProcess()
	{
	}

	public void OnClickIcon()
	{
	}
}
