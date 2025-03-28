using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class UnitBundlePackagePanel : PopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuy_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UnitBundlePackagePanel _003C_003E4__this;

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
	private List<UnitIllust> _illust;

	[SerializeField]
	private Text _packageTitleText;

	[SerializeField]
	private Text _efficiencyText;

	[SerializeField]
	private List<Image> _unitSprites;

	[SerializeField]
	private List<Text> _unitNames;

	[SerializeField]
	private List<Text> _unitSubNames;

	[SerializeField]
	private List<Button> _unitButtons;

	[SerializeField]
	private Text _priceText;

	private ResourceShopItem _resShopItem;

	public void Show(int index)
	{
	}

	public void Show(ResourceShopItem shopItem)
	{
	}

	private void Reload(List<int> unitIdList)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__12))]
	public void OnClickBuy()
	{
	}

	public override void OnClickClose()
	{
	}
}
