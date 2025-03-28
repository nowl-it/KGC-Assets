using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameOverRewardBoxPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public HashSet<RewardBoxItem> dismantleAccessories;

		internal bool _003CDismantleAccessories_003Eb__1(RewardBoxItem x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDismantleAccessories_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameOverRewardBoxPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		private UniTask<(Dictionary<int, int>, Awesomepiece.Model.AccessoryResultResponseModel)>.Awaiter _003C_003Eu__1;

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
	private struct _003CLockAccessories_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameOverRewardBoxPanel _003C_003E4__this;

		private HashSet<RewardBoxItem> _003ClockAccessories_003E5__2;

		private UniTask<Awesomepiece.Model.AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CShowAlert_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public int count;

		public GameOverRewardBoxPanel _003C_003E4__this;

		public Dictionary<int, int> rewardItems;

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
	private RectTransform _rewardAreaRect;

	[SerializeField]
	private GameObject _accessoryButtonToggleGroup;

	[SerializeField]
	private Toggle _accessoryButtonToggle;

	[SerializeField]
	private GameObject _buttonGroup;

	[SerializeField]
	private RewardPopup _rewardPopup;

	private bool _toggle;

	private IDisposable _toggleDisposable;

	private static GameOverPanel gameOverPanel => null;

	private static List<RewardBoxItem> rewardBoxItems => null;

	public void Init()
	{
	}

	private void RefreshHeight()
	{
	}

	public void ToggleAccessoryButton()
	{
	}

	[AsyncStateMachine(typeof(_003CDismantleAccessories_003Ed__14))]
	public void DismantleAccessories()
	{
	}

	[AsyncStateMachine(typeof(_003CLockAccessories_003Ed__15))]
	public void LockAccessories()
	{
	}

	public void AfterAction()
	{
	}

	private void AccessoryCleanUpMode()
	{
	}

	private void NormalMode()
	{
	}

	private void FilterAccessoriesAndSetCleanUp()
	{
	}

	private void ActiveAllItemsAndSetNormal()
	{
	}

	[AsyncStateMachine(typeof(_003CShowAlert_003Ed__21))]
	private UniTask<bool> ShowAlert(int count, Dictionary<int, int> rewardItems, bool containsValuable)
	{
		return default(UniTask<bool>);
	}

	public bool IsAccessoryCleanUpMode()
	{
		return false;
	}
}
