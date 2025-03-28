using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class InvasionRewardPanelMissionItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public bool processed;

		internal void _003CReceiveReward_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickRewardTutorial_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public InvasionRewardPanelMissionItem _003C_003E4__this;

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
	private struct _003CReceiveReward_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InvasionRewardPanelMissionItem _003C_003E4__this;

		public int pass;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

		private UniTask<Awesomepiece.Model.ReceiveInvasionRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _themeText;

	[SerializeField]
	private Text _difficultyText;

	[SerializeField]
	private Image _themeBossIcon;

	[SerializeField]
	private Image _themeBossIconRhombus;

	[SerializeField]
	private LayoutDistributor _rewardLayoutDistributor;

	[SerializeField]
	private InvasionRewardPanelRewardItem[] _rewardItems;

	[SerializeField]
	private InvasionRewardPanelRewardItem _passRewardItem;

	[SerializeField]
	private GameObject _canReceiveObject;

	[SerializeField]
	private GameObject _receivedAllObject;

	private ResourceTheme _resTheme;

	private int _difficulty;

	private ResourceInvasionReward _resReward;

	private bool _isCleared;

	private bool _receiveProcessing;

	public void Set(ResourceTheme resTheme, int difficulty, ResourceInvasionReward resReward, bool passAvailable, bool isCleared)
	{
	}

	private void Reload()
	{
	}

	private bool HasPass(int pass)
	{
		return false;
	}

	public void OnClickReward(int pass, ClickableShopItemIcon clickedItem)
	{
	}

	[AsyncStateMachine(typeof(_003CReceiveReward_003Ed__18))]
	private void ReceiveReward(int pass)
	{
	}

	public RectTransform GetTutorialRewardFocusRectTransform()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COnClickRewardTutorial_003Ed__20))]
	public UniTask OnClickRewardTutorial()
	{
		return default(UniTask);
	}
}
