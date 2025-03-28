using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Coffee.UIEffects;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SkinInfoPanel : MonoBehaviour, IClosable, IComponentConnector
{
	public struct SkinInfoPanelData
	{
		public CardData cardData;

		public bool ownCard;

		public bool isTransformUnit;

		public bool isSummonedUnit;

		public int transformUnitId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public BuySkinResponseModel ret;

		internal void _003CBuyProcess_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public BuyResponseModel ret;

		internal void _003CConfirmCatalogProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoPanel _003C_003E4__this;

		public bool useSkinToken;

		private _003C_003Ec__DisplayClass91_0 _003C_003E8__1;

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
	private struct _003CConfirmCatalogProcess_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass93_0 _003C_003E8__1;

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
	private struct _003COnClickConfirmCatalog_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoPanel _003C_003E4__this;

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
	private struct _003COnClickEquip_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinInfoPanel _003C_003E4__this;

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

	private SkinInfoPanelData _data;

	public UnitIllust unitIllust;

	public Text nameText;

	public Text descText;

	public Border descBorder;

	public UIShadow descOutline;

	[ComponentConnect]
	public ClickableShopItemIcon skinTokenCurrencyItem;

	[ComponentConnect]
	public ClickableShopItemIcon cashCurrencyItem;

	public RectTransform unitPrefabRoot;

	public Toggle showEffectToggle;

	[SerializeField]
	private Text _showEffectToggleText;

	[NonSerialized]
	public GameObject skinPrefab;

	[Space(20f)]
	[SerializeField]
	private ProfileAvatar _unitProfileButton;

	public Button transformButton;

	public Image transformIcon;

	public Button summonerButton;

	public Image summonerIcon;

	public ConditionalLocalizedText summonerButtonConditionalLocalizedText;

	[ComponentConnect]
	public Button prevChromaButton;

	[ComponentConnect]
	public Button nextChromaButton;

	[ComponentConnect]
	public GameObject canNotBuy;

	[ComponentConnect]
	public Image skinItemPartition;

	[ComponentConnect]
	public Text mySkinCount;

	[Space(10f)]
	public SkinGrade skinGrade;

	public GameObject skinInfoTagTab;

	public GameObject skinItemPrefab;

	public GameObject skinInfoTagPrefab;

	public HorizontalLayoutGroup skinsLayout;

	public GameObject chromaItemPrefab;

	public RectTransform chromaItemLayout;

	[SerializeField]
	private GameObject _skinsGroup;

	[ComponentConnect]
	[Space(10f)]
	public Button cashBuyButton;

	[ComponentConnect]
	public Button skinTokenBuyButton;

	[ComponentConnect]
	public Button confirmCatalogButton;

	[ComponentConnect]
	public ImageTextPair cashPrice;

	[ComponentConnect]
	public ImageTextPair skinTokenPrice;

	[ComponentConnect]
	public Button equipButton;

	[ComponentConnect]
	public Text equipButtonText;

	[ComponentConnect]
	public Button passBuyButton;

	public Text passBuyButtonText;

	[ComponentConnect]
	public Button godSkinBuyButton;

	[ComponentConnect]
	public ConditionalGroup godSkinBuyButtonsCond;

	[Space(20f)]
	[SerializeField]
	private UnitProfilePanel _profilePanel;

	private List<SkinInfoItem> _skins;

	private List<GameObject> _skinInfoTags;

	private List<SkinInfoChromaItem> _chromaItems;

	private SkinInfoItem _selectedSkin;

	private SkinInfoChromaItem _selectedChroma;

	private int _selectedChromaIdx;

	private ResourceShopItem _resCatalog;

	private string _cachedSkinPrefab;

	private int _ownSkinCount;

	private bool _isShowingCatalog;

	private bool _viewOnly;

	private ResourceSkin _resSkin;

	private ResourceUnit _resUnit;

	public void Awake()
	{
	}

	public void ShowCatalog(ResourceShopItem resCatalog)
	{
	}

	public void Show(SkinInfoPanelData data)
	{
	}

	public void Show(int skinId)
	{
	}

	private void Reload()
	{
	}

	private void ActivateTransformButton()
	{
	}

	private void ActivateSummonerButton()
	{
	}

	private void ShowPersonalInfos(bool show)
	{
	}

	private void SetCurrencyItem(ClickableShopItemIcon icon, ResourceInventoryItem resItem, int itemCount)
	{
	}

	private void ReloadCurrencies()
	{
	}

	private void ReloadEquippedChroma()
	{
	}

	private void AddSkinItem(int idx, ResourceSkin resSkin)
	{
	}

	private void ReloadSkinItems()
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

	private void SetChromaDefault()
	{
	}

	private void SetChromaItem(SkinInfoChromaItem item)
	{
	}

	private void AfterSetSelectedSkin()
	{
	}

	private void ReloadUnitAndDesc()
	{
	}

	private void ReloadBottomButtons()
	{
	}

	private void SetInteractable(Button button, Text buttonText, bool interactable, bool hasCurrency)
	{
	}

	private void ReloadBottomButtons_PassSkin(bool hasSkin)
	{
	}

	private void ReloadBottomButtons_GodSkin(bool hasSkin)
	{
	}

	private List<GameObject> GetAllBottomButtons()
	{
		return null;
	}

	private void SetResources()
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

	[AsyncStateMachine(typeof(_003COnClickEquip_003Ed__87))]
	public void OnClickEquip()
	{
	}

	public void OnClickCashBuy()
	{
	}

	public void OnClickTokenBuy()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickConfirmCatalog_003Ed__90))]
	public void OnClickConfirmCatalog()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__91))]
	private void BuyProcess(bool useSkinToken)
	{
	}

	private bool IsSameSkinItem(ResourceSkin skinItem, int skinId)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CConfirmCatalogProcess_003Ed__93))]
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

	public void OnClickSwitchTransformUnit()
	{
	}

	public void OnClickSwitchSummonedUnit()
	{
	}

	private void SortSkins(List<ResourceSkin> elements, CardData cardData)
	{
	}

	private Sprite GetAvatarSprite(int id)
	{
		return null;
	}

	public void OnClickUnitProfilePanel()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	private int GetSummonerSwitchUnitID(ResourceUnit resUnit)
	{
		return 0;
	}

	private bool IsDefaultSkin(bool containChroma = true)
	{
		return false;
	}
}
