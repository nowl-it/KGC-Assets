using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Coffee.UIEffects;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SkinInfoTab_Old : MonoBehaviour, IClosable, IComponentConnector
{
	public struct SkinInfoTabData
	{
		public CardData cardData;

		public bool ownCard;

		public bool isTransformUnit;

		public bool isSummonedUnit;

		public int transformUnitId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public BuySkinResponseModel ret;

		internal void _003CBuyProcess_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public BuyResponseModel ret;

		internal void _003CConfirmCatalogProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__69 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoTab_Old _003C_003E4__this;

		public bool useSkinToken;

		private _003C_003Ec__DisplayClass69_0 _003C_003E8__1;

		private UniTask<BuySkinResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CConfirmCatalogProcess_003Ed__71 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoTab_Old _003C_003E4__this;

		private _003C_003Ec__DisplayClass71_0 _003C_003E8__1;

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
	private struct _003COnClickConfirmCatalog_003Ed__68 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoTab_Old _003C_003E4__this;

		private bool _003ChasUnit_003E5__2;

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
	private struct _003COnClickEquip_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoTab_Old _003C_003E4__this;

		private int _003Cskin_003E5__2;

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

	public Text nameText;

	public Text descText;

	public UIShadow descOutline;

	public Image skinImage;

	public GameObject skinPrefab;

	[ComponentConnect]
	public GameObject canNotBuy;

	[ComponentConnect]
	public Button cashBuyButton;

	[ComponentConnect]
	public Button skinTokenBuyButton;

	[ComponentConnect]
	public Button confirmCatalogButton;

	[ComponentConnect]
	public Image skinItemPartition;

	[ComponentConnect]
	public ImageTextPair cashPrice;

	[ComponentConnect]
	public ImageTextPair skinTokenPrice;

	[ComponentConnect]
	public List<Button> equipButton;

	[ComponentConnect]
	public List<Text> equipButtonText;

	[ComponentConnect]
	public ImageTextPair skinTokenPair;

	[ComponentConnect]
	public Button passBuyButton;

	public Text passBuyButtonText;

	[ComponentConnect]
	public Button godSkinBuyButton;

	[ComponentConnect]
	public Text mySkinCount;

	[ComponentConnect]
	public GridLayoutGroup catalogItemLayout;

	[ComponentConnect]
	public Button prevChromaButton;

	[ComponentConnect]
	public Button nextChromaButton;

	public UnitIllust unitIllust;

	public SkinGrade skinGrade;

	public GameObject skinInfoTagTab;

	public GameObject skinItemPrefab;

	public GameObject skinInfoTagPrefab;

	public RectTransform skinsLayout;

	public GameObject chromaItemPrefab;

	public RectTransform chromaItemLayout;

	public ConditionalGroup godSkinCond;

	public Toggle showEffectToggle;

	private List<SkinInfoItem> _skins;

	private List<GameObject> _skinInfoTags;

	private List<SkinInfoChromaItem> _chromaItems;

	private CardData _cardData;

	private SkinInfoItem _selectedSkin;

	private SkinInfoChromaItem _selectedChroma;

	private int _selectedChromaIdx;

	private ResourceShopItem _resCatalog;

	private bool _ownCard;

	private string _cachedSkinPrefab;

	private bool _isTransformUnit;

	private bool _isSummonedUnit;

	private int _transformUnitId;

	private int _ownSkinsNum;

	private bool _isIconDescOn;

	private bool _isShowingCatalog;

	public void Awake()
	{
	}

	public void ShowCatalog(ResourceShopItem resCatalog)
	{
	}

	public void Show(SkinInfoTabData data)
	{
	}

	private void ReloadToken()
	{
	}

	private void ReloadEquippedChroma()
	{
	}

	private void AddSkinItem(ResourceSkin resSkin)
	{
	}

	private void ReloadSkinItems()
	{
	}

	private void ClearItems()
	{
	}

	public void OnClickSkin(int skinID)
	{
	}

	public void OnClickSkin(SkinInfoItem item)
	{
	}

	public void OnClickChangeChromaButton(int indexDelta)
	{
	}

	private void SetSelectedChromaItem(int id)
	{
	}

	private void AfterSetSelectedSkin(ResourceUnit resUnit, ResourceSkin resSkin)
	{
	}

	private void InitSkinInfo()
	{
	}

	private void InitShowSkinEffect()
	{
	}

	public void OnToggleShowSkinEffect()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickEquip_003Ed__65))]
	public void OnClickEquip()
	{
	}

	public void OnClickCashBuy()
	{
	}

	public void OnClickTokenBuy()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickConfirmCatalog_003Ed__68))]
	public void OnClickConfirmCatalog()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__69))]
	private void BuyProcess(bool useSkinToken)
	{
	}

	private bool IsSameSkinItem(ResourceSkin skinItem, int skinId)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CConfirmCatalogProcess_003Ed__71))]
	private void ConfirmCatalogProcess()
	{
	}

	public void ShowSkinPrefab(string prefabName)
	{
	}

	public int GetSelectedSkinId()
	{
		return 0;
	}

	public void OnClickBuyPass()
	{
	}

	public void OnClickGodSKin()
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
