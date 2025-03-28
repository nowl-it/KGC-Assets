using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SkinBundlePackagePanel : PopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuy_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SkinBundlePackagePanel _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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

	[SerializeField]
	private UnitIllust _illust;

	[SerializeField]
	private Text _packageTitleText;

	[SerializeField]
	private Text _efficiencyText;

	[SerializeField]
	private Text _remainTimeText;

	[SerializeField]
	private Image _unitImage;

	[SerializeField]
	private Image _skinImage;

	[SerializeField]
	private Image[] _tokenImage;

	[SerializeField]
	private Text _unitSubName;

	[SerializeField]
	private Text _unitName;

	[SerializeField]
	private Text _skinSubName;

	[SerializeField]
	private Text _skinName;

	[SerializeField]
	private Text _tokenAmountText;

	[SerializeField]
	private Text _skinDesc;

	[SerializeField]
	private Text _priceText;

	private ResourceShopItem _resShopItem;

	private ResourceSkin _resSkin;

	private ResourceUnit _resUnit;

	public void Show(ResourceShopItem resShopItem, ResourceSkin resSkin, ResourceUnit resUnit)
	{
	}

	private void Reload()
	{
	}

	private void Update()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__20))]
	public void OnClickBuy()
	{
	}
}
