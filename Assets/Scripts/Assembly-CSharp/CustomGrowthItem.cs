using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class CustomGrowthItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuy_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CustomGrowthItem _003C_003E4__this;

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

	[SerializeField]
	private Text _stepText;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _unitRewardText;

	[SerializeField]
	private Text _plusIcon;

	[SerializeField]
	private ClickableShopItemIcon _unitExpIcon;

	[SerializeField]
	private ClickableShopItemIcon _goldIcon;

	[SerializeField]
	private ClickableShopItemIcon _soulIcon;

	[SerializeField]
	private Text _remainCountText;

	[SerializeField]
	private Button _buyButton;

	[SerializeField]
	private Text _priceText;

	private ResourceShopItem _resShopItem;

	[CanBeNull]
	private ResourceUnit _resUnit;

	private bool _soldOut;

	public void Init(ResourceShopItem shopItem, ResourceUnit resUnit, string titleText)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__14))]
	public void OnClickBuy()
	{
	}

	public void SetEnabled(bool enabled)
	{
	}
}
