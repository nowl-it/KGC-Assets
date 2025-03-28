using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BuyHeartPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public bool processed;

		internal void _003CBuyProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int id;

		public BuyHeartPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private ResourceShopItem _003CresShopItem_003E5__2;

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

	[CompilerGenerated]
	private sealed class _003CLoadSceneAfterShortcut_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action shortcut;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadSceneAfterShortcut_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuy_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BuyHeartPanel _003C_003E4__this;

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

	public List<UseVoucherPanel> voucherPanels;

	public Price buyPrice;

	public Text todayRemain;

	public Button adButton;

	public Button buyButton;

	public Image adIcon;

	public Text freeText;

	public Text adText;

	[SerializeField]
	private GameObject _passBenefitObj;

	[SerializeField]
	private GameObject _passBenefitObj_Simple;

	private ResourceShopItem _heartShopItem;

	private List<ResourceInventoryItem> _heartInventoryItems;

	private Action _buyCompleteCallback;

	private bool _adProgress;

	public void Show(Action buyCompleteCallback = null)
	{
	}

	public void Reload()
	{
	}

	public void Hide()
	{
	}

	public void OnClickAdBuy()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__18))]
	public void OnClickBuy()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSceneAfterShortcut_003Ed__19))]
	private IEnumerator LoadSceneAfterShortcut(Action shortcut)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__20))]
	public void BuyProcess(int id)
	{
	}

	private void ReloadWorldPanelMissionBadge()
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
