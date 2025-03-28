using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SeasonalEventShopItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public SeasonalEventShopItem _003C_003E4__this;

		public BuyResponseModel ret;

		internal void _003CBuyProcess_003Eb__0(ClickableShopItemIcon icon)
		{
		}

		internal void _003CBuyProcess_003Eb__1()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SeasonalEventShopItem _003C_003E4__this;

		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		private UniTask<int>.Awaiter _003C_003Eu__1;

		private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__2;

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

	public Text itemName;

	public Text remainCount;

	public Button buyButton;

	public ImageTextPair pricePair;

	public Text shortCutText;

	public GameObject soldOutObject;

	public Text soldOutText;

	public Image frameImage;

	public GameObject tokenPriceIcon;

	public GameObject cashPriceIcon;

	public Text limitedText;

	public Text hasIllustText;

	private ResourceShopItem _resShopItem;

	private int _unitId;

	private string _tokenType;

	private int _tokenSalePer;

	private bool _skinBundlePackage;

	private Scene_Base _currentScene => null;

	public void Set(ShopItemModel item, int tokenSalePer = 0, bool skinBundlePackage = false)
	{
	}

	public void OnClickBuy()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__22))]
	private void BuyProcess()
	{
	}

	public void OnClickIcon()
	{
	}

	private int GetCurrentTokenCount()
	{
		return 0;
	}
}
