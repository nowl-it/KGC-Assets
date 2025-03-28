using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class RewardPopup : Popup
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public RewardPopup _003C_003E4__this;

		public Dictionary<int, int> rewards;

		public string text;

		public Type type;

		public string oneOffKey;

		public int goldPrice;

		public int cashPrice;

		public int soulItemPrice;

		public (int id, int count) idCount;

		public int tokenPrice;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public RewardPopup _003C_003E4__this;

		public List<InventoryItem> rewards;

		public string text;

		public Type type;

		public string oneOffKey;

		public int goldPrice;

		public int cashPrice;

		public int soulItemPrice;

		public (int id, int count) idCount;

		public int tokenPrice;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public RewardPopup _003C_003E4__this;

		public string text;

		public Type type;

		public string oneOffKey;

		public int goldPrice;

		public int cashPrice;

		public int soulItemPrice;

		public (int id, int count) idCount;

		public int tokenPrice;

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
	private ClickableShopItemIcon _rewardItemPrefab;

	[SerializeField]
	private RectTransform _rewardItemsRoot;

	private readonly List<ClickableShopItemIcon> _rewardItems;

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__3))]
	public UniTask<bool> ShowAsync(string text, Dictionary<int, int> rewards, Type type = Type.Ok, string oneOffKey = null, int goldPrice = 0, int cashPrice = 0, int soulItemPrice = 0, (int id, int count) idCount = default((int id, int count)), int tokenPrice = 0)
	{
		return default(UniTask<bool>);
	}

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__4))]
	public UniTask<bool> ShowAsync(string text, List<InventoryItem> rewards, Type type = Type.Ok, string oneOffKey = null, int goldPrice = 0, int cashPrice = 0, int soulItemPrice = 0, (int id, int count) idCount = default((int id, int count)), int tokenPrice = 0)
	{
		return default(UniTask<bool>);
	}

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__5))]
	public override UniTask<bool> ShowAsync(string text, Type type = Type.Ok, string oneOffKey = null, int goldPrice = 0, int cashPrice = 0, int soulItemPrice = 0, (int id, int count) idCount = default((int id, int count)), int tokenPrice = 0)
	{
		return default(UniTask<bool>);
	}

	private void SetRewards(Dictionary<int, int> items)
	{
	}
}
