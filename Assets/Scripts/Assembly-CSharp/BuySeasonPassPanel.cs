using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BuySeasonPassPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public bool processed;

		internal void _003CBuyPassUnitProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyPassUnitProcess_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private _003C_003Ec__DisplayClass44_0 _003C_003E8__1;

		public BuySeasonPassPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.BuyResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickBuy_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BuySeasonPassPanel _003C_003E4__this;

		private ResourceShopItem _003CresShopItem_003E5__2;

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

	[Header("Basic")]
	public UnitIllust unitIllust;

	public Text skinName;

	public Image skinImage;

	public Text passNameText;

	public Text remainTimeText;

	public Image passUnitImageInPremiumOption;

	public Text passUnitTextInPremiumOption;

	public GameObject giveSoulInfoPopup;

	public BuySeasonPassCarouselView carouselView;

	public ConditionalGroup pageIdxCond;

	public ConditionalGroup buyPassStateCond;

	public UIFitter scrollViewContentUIFitter;

	public UIFitter[] passBenefitGroupUIFitters;

	public UIFitter[] benefitTextGroupUIFitters;

	public UIFitter[] benefitTextUIFitters;

	[Header("BuySeasonPass")]
	public ConditionalGroup buyButtonCond;

	public Button buyButton;

	public Text priceText;

	[Header("BuyPassUnit")]
	public Image passUnitImage;

	public Image passUnitAvatar;

	public Text passUnitName;

	public Price passUnitPrice;

	public ConditionalGroup buyPassUnitButtonCondition;

	public ConditionalGroup hasPassUnitCondition;

	public GameObject buyPassUnitRoot;

	[SerializeField]
	[Header("NextSeason")]
	private GameObject _nextSeasonObj;

	[SerializeField]
	private Text _nextSeasonRemainText;

	private int _currentPageIdx;

	private int _lastSeason;

	private ResourceSeasonPass _resSeasonPass;

	private void Update()
	{
	}

	private void UpdateNextSeasonStartRemainTimeText()
	{
	}

	public void Show()
	{
	}

	private void Init()
	{
	}

	private void Reload()
	{
	}

	public void OnClickCarouselButton(int idx)
	{
	}

	private void OnCarouselChanged(int idx)
	{
	}

	public void SetCarouselIndex(int idx)
	{
	}

	public void OnClickGiveSoulInfo()
	{
	}

	public void OnClickSkinInfo()
	{
	}

	private void UpdatePassPriceText()
	{
	}

	private int GetCurrentShopItemId()
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__42))]
	public void OnClickBuy()
	{
	}

	public void OnClickPassUnitBuy()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyPassUnitProcess_003Ed__44))]
	public void BuyPassUnitProcess()
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
