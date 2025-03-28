using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GachaShopPanelBG_TreasureCustomPickup : GachaShopPanelBG, IGachaCeilSelectable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLoadPickups_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GachaShopPanelBG_TreasureCustomPickup _003C_003E4__this;

		private UniTask<Awesomepiece.Model.CustomPickupsResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickDevPickupResetButton_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GachaShopPanelBG_TreasureCustomPickup _003C_003E4__this;

		private UniTask<Awesomepiece.Model.CustomPickupsResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _gachaName;

	[SerializeField]
	private Text _pickupDesc;

	[SerializeField]
	private TreasureCardGachaItem[] _treasureCards;

	[SerializeField]
	private GameObject[] _treasureNoneObjs;

	[SerializeField]
	private Button _pickupResetButton;

	[SerializeField]
	private Image _gachaCeilSelectButton;

	public TreasureGachaCeilSelectPanel treasureGachaCeilSelectPanel;

	public CustomPickupSelectTreasurePanel customPickupSelectTreasurePanel;

	private ResourceGacha.Pickup _resPickup;

	public List<ResourceGacha.Pickup> selectedPickups;

	private bool _pickupLoaded;

	private bool _isTreasureSelected => false;

	public override void Set(ResourceGacha resGacha)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadPickups_003Ed__14))]
	private void LoadPickups()
	{
	}

	public override Action GetAfterBuyGachaCallback()
	{
		return null;
	}

	public void Reload()
	{
	}

	private void SetUIDefaults()
	{
	}

	public void OnClickTreasureDetailButton(int index)
	{
	}

	public void OnClickSelectTreasureButton()
	{
	}

	private void ReloadGachaCeilSelectButton()
	{
	}

	public void OnClickSelectGachaCeil()
	{
	}

	private bool ReloadResetButton()
	{
		return false;
	}

	public void OnClickResetButton()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDevPickupResetButton_003Ed__24))]
	public override void OnClickDevPickupResetButton()
	{
	}
}
