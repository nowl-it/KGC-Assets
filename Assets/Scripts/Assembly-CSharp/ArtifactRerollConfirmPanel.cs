using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactRerollConfirmPanel : MonoBehaviour
{
	public struct RerollConfirmInfo
	{
		public ArtifactModel before;

		public ArtifactModel after;

		public ArtifactModel material;

		public ArtifactModel catalyst;

		public bool useGold;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public List<int> prevPlayerPackages;

		internal bool _003COnClickConfirm_003Eb__2(ShopItemModel x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickConfirm_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactRerollConfirmPanel _003C_003E4__this;

		public bool takeNew;

		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CRerollImpl_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactRerollConfirmPanel _003C_003E4__this;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

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

	public ArtifactRerollCompareUI before;

	public ArtifactRerollCompareUI after;

	public ArtifactCraftSlot materialSlot;

	public ArtifactCraftSlot catalystSlot;

	public Gauge polishGauge;

	public ConditionalGroup rerollButton;

	public RectTransform[] tutorialObjects;

	[SerializeField]
	private Text _incrementText;

	[SerializeField]
	private ImageTextPair _myCurrency;

	[SerializeField]
	private ImageTextPair _cost;

	private RerollConfirmInfo _rerollConfirmInfo;

	private ArtifactModel _rerollMaterial;

	private ArtifactModel _rerollCatalyst;

	private int _rerollCost;

	private Action _afterRerollCallback;

	private bool _rerollEventArtifact;

	public void Show(RerollConfirmInfo rerollConfirmInfo, Action afterRerollCallback)
	{
	}

	private void Reload()
	{
	}

	public void OnClickClose()
	{
	}

	private void SetMaterial()
	{
	}

	private void SetCatalyst()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickConfirm_003Ed__22))]
	public void OnClickConfirm(bool takeNew)
	{
	}

	public void OnClickReroll()
	{
	}

	[AsyncStateMachine(typeof(_003CRerollImpl_003Ed__24))]
	private void RerollImpl()
	{
	}

	private void ShowPopupChain(List<ShopItemModel> shopItemModels)
	{
	}

	public bool Close()
	{
		return false;
	}
}
