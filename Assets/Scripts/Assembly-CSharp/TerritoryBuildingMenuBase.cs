using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryBuildingMenuBase : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public int labor;

		public int maxLabor;

		public Action _003C_003E9__0;

		internal void _003CCollectLabor_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCollectLabor_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuildingMenuBase _003C_003E4__this;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCollectSkinToken_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuildingMenuBase _003C_003E4__this;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickCollectLabor_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuildingMenuBase _003C_003E4__this;

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
	[Header("Base")]
	private Transform _buttonsRoot;

	[SerializeField]
	private Text _buildingNameText;

	[SerializeField]
	private Text _buildingLevelText;

	[HideInInspector]
	public TerritoryBuilding building;

	private readonly List<TerritoryBuildingMenuButton> _menuButtons;

	private int _activatedButtonCount;

	private bool _isLaborProcessing;

	private bool _isSkinTokenProcessing;

	private bool _canClosedByClickOutside;

	private Action _onBuildingInfoShow;

	private Action _onBuildingInfoClose;

	protected virtual void Awake()
	{
	}

	public virtual void Show(TerritoryBuilding building)
	{
	}

	protected virtual void Update()
	{
	}

	private void ReloadUpdateImmediatelyButtonPrice(TerritoryBuildingMenuButton menuButton)
	{
	}

	private void ReloadCollectLaborButton(TerritoryBuildingMenuButton menuButton)
	{
	}

	private void AddButton(string onClickAction)
	{
	}

	public void ReloadMenuButtonsMarker()
	{
	}

	public void HideMenuButtonsMarker()
	{
	}

	private void OnClickStore()
	{
	}

	private void OnClickRemove()
	{
	}

	private void OnClickReplace()
	{
	}

	private void OnClickUpgrade()
	{
	}

	protected virtual void OnClickInfo()
	{
	}

	protected void SetBuildingInfoCloseCallback(Action onBuildingInfoShow, Action onBuildingInfoClose)
	{
	}

	private void OnClickUpgradeImmediately()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickCollectLabor_003Ed__26))]
	private void OnClickCollectLabor()
	{
	}

	[AsyncStateMachine(typeof(_003CCollectLabor_003Ed__27))]
	public void CollectLabor()
	{
	}

	[AsyncStateMachine(typeof(_003CCollectSkinToken_003Ed__28))]
	public void CollectSkinToken()
	{
	}

	public void TryCloseByClickOutside()
	{
	}

	public virtual void OnClickClose()
	{
	}

	public virtual bool Close()
	{
		return false;
	}

	public Button GetMenuButton(string type)
	{
		return null;
	}

	public void DisableOutsideClose()
	{
	}

	public void EnableOutsideClose()
	{
	}
}
