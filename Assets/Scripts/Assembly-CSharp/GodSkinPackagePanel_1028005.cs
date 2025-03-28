using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GodSkinPackagePanel_1028005 : PopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuy_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GodSkinPackagePanel_1028005 _003C_003E4__this;

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

	private const int SKIN_ID = 1028005;

	[SerializeField]
	private Text _packageTitle;

	[SerializeField]
	private List<Text> _skinNameText;

	[SerializeField]
	private UnitIllust _unitIllust;

	[SerializeField]
	private Transform _skinPrefabRoot;

	[SerializeField]
	private Text _remainTimeText;

	[SerializeField]
	private List<GodSkinPackageCell> _godSkinShopCells;

	[SerializeField]
	private GodSkinPackageCell _godSkinUpgradeCell;

	[SerializeField]
	[Space(20f)]
	private Button _leftArrowButton;

	[SerializeField]
	private Button _rightArrowButton;

	[SerializeField]
	private Button _leftSlideButton;

	[SerializeField]
	private Button _rightSlideButton;

	[Space(20f)]
	[SerializeField]
	private Button _buyButton;

	[SerializeField]
	private Text _priceText;

	[Space(20f)]
	[SerializeField]
	private GameObject _unSaleObj;

	[SerializeField]
	private Text _unSaleText;

	[SerializeField]
	private Text _saleRemainTimeText;

	[SerializeField]
	private HQIllustPopup _illustPopup;

	[SerializeField]
	private Text _toolTip;

	private List<ResourceShopItem> _godSkinShopItems;

	private int _currentIndex;

	private readonly int _minIndex;

	private ResourceShopItem _targetShopItem;

	private ResourceShopItem _targetUpgradeShopItem;

	private GameObject _skinObj;

	private List<ulong> _workTimers;

	private List<GameObject> _effects;

	private List<Image> _flashEffects;

	[SerializeField]
	private Camera _renCamera;

	private RenderTexture _worldTexture;

	[SerializeField]
	private Shader _distortionShader;

	private float _targetCellsAngle;

	private float _currentCellsAngle;

	private float _rotateDir;

	private bool _saleReloaded;

	private int _maxIndex => 0;

	private Triplet<int, string, bool> godSkinInformation => null;

	private Triplet<int, string, bool> godSkinSaleInformation => null;

	private void OnEnable()
	{
	}

	public override void Show()
	{
	}

	private void Init()
	{
	}

	private void Reload()
	{
	}

	private void SetAnimatorTransform(bool set)
	{
	}

	private void ClearWorkTimer()
	{
	}

	private string GetRemainTimeText(ResourceShopItem shopItem)
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnClickArrowButton(int index)
	{
	}

	private void UpdateCellPosition(bool Immediately)
	{
	}

	private void ReloadTimeTexts()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__52))]
	public void OnClickBuy()
	{
	}

	private void OnClickIllust()
	{
	}

	private void OnCloseIllust()
	{
	}

	public override bool Close()
	{
		return false;
	}

	public override void OnClickClose()
	{
	}
}
