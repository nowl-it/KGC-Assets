using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BuyGachaButtonGroup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public BuyGachaButtonGroup _003C_003E4__this;

		public bool processed;

		public BuyResponseModel ret;

		public int count;

		public int keyStack;

		internal void _003CBuy_003Eb__1()
		{
		}

		internal void _003CBuy_003Eb__2()
		{
		}

		internal void _003CBuy_003Eb__3()
		{
		}

		internal void _003CBuy_003Eb__8()
		{
		}

		internal void _003CBuy_003Eb__11(ResourceGacha.GachaCeil x)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuy_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BuyGachaButtonGroup _003C_003E4__this;

		public int count;

		public int btnIndex;

		public ResourceShopItem resShopItem;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

		private bool _003CisAd_003E5__2;

		private int _003CkeyCount_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private int[] _003CcustomPickups_003E5__4;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__3;

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
	private BuyGachaButton[] _buttons;

	private ResourceGacha _resGacha;

	private int[] _gachaCounts;

	private Action _afterBuyCallback;

	private Action<bool> _setLoadingCallback;

	private Action _onCloseAllCallback;

	private List<ResourceGacha.Pickup> _pickups;

	private bool _isFree;

	private bool _isLoading;

	private bool _currentGachaIsTutorial;

	public BuyGachaButton[] buttons => null;

	public void Set(ResourceGacha resGacha, int[] gachaCounts, Action<bool> setLoadingCallback, Action onCloseAllCallback)
	{
	}

	public void AppendAfterBuyCallback(Action callback)
	{
	}

	public void SetPickupDatas(List<ResourceGacha.Pickup> pickups)
	{
	}

	private void OnDestroy()
	{
	}

	public void ReloadPrice()
	{
	}

	public void OnClickBuy(ResourceShopItem resShopItem, int count, int btnIndex)
	{
	}

	[AsyncStateMachine(typeof(_003CBuy_003Ed__18))]
	public void Buy(ResourceShopItem resShopItem, int count, int btnIndex)
	{
	}

	private void LogBuyGacha(ResourceGacha resGacha, ResourceShopItem resShopItem, BuyResponseModel ret, bool withKey, int usedKeyCount)
	{
	}

	public void SetLoading(bool isLoading)
	{
	}

	public void PrepareWelcomeGacha()
	{
	}

	public void PrepareTutorialGacha()
	{
	}

	public void FinishTutorial()
	{
	}

	public Price GetBuyPrice(int index)
	{
		return null;
	}

	private bool CanSummon20Times(int shopItemId)
	{
		return false;
	}
}
