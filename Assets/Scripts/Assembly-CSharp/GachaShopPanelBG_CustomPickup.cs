using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GachaShopPanelBG_CustomPickup : GachaShopPanelBG
{
	[Serializable]
	public struct UnitUIInfo
	{
		public Image unitIllust;

		public Text unitName;

		public Text unitSubName;

		public GameObject unitNoneObj;

		public GameObject hasUnitObj;

		public GameObject selectObj;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLoadPickups_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GachaShopPanelBG_CustomPickup _003C_003E4__this;

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
	private UnitUIInfo[] _unitUis;

	[SerializeField]
	private Button _pickupResetButton;

	public CustomPickupSelectUnitPanel customPickupSelectUnitPanel;

	public List<ResourceGacha.Pickup> pickups;

	private bool _pickupLoaded;

	private bool _isUnitSelected => false;

	public override void Set(ResourceGacha resGacha)
	{
	}

	public override Action GetAfterBuyGachaCallback()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadPickups_003Ed__12))]
	private void LoadPickups()
	{
	}

	public void Reload()
	{
	}

	private void SetUIDefaults()
	{
	}

	public void OnClickUnitDetailButton(int index)
	{
	}

	public void OnClickSelectUnitButton()
	{
	}

	public void OnClickResetButton()
	{
	}
}
