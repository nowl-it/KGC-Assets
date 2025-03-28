using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class TreasureWishListPanel : BlurPopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickAccept_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureWishListPanel _003C_003E4__this;

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
	private struct _003CSaveWishList_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureWishListPanel _003C_003E4__this;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

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
	private TreasureWishListItem _wishListItemPrefab;

	[SerializeField]
	private RectTransform _wishListItemsRoot;

	private List<TreasureWishListItem> _wishListItems;

	[Space(20f)]
	[SerializeField]
	private TreasureUIItem _selectedWishListItemPrefab;

	[SerializeField]
	private RectTransform _selectedWishListItemsRoot;

	private List<TreasureUIItem> _selectedWishListItems;

	private int[] _selectedWishListTreasures;

	[SerializeField]
	[Space(20f)]
	private ClickOutsideClose _tooltip;

	[SerializeField]
	private UIFitter[] _uiFitters;

	private ResourceTreasure.Rarity _targetRarity;

	private List<ResourceUnit.Role> _targetRoles;

	private Dictionary<ResourceUnit.Role, Dictionary<int, (TreasureModel maxOvercomeTreasure, int allTreasureCount)>> _initialTreasureData;

	private bool _checkCondition;

	private static bool _requestProcess;

	[Obsolete]
	public new void Show()
	{
	}

	public void Show(ResourceTreasure.Rarity rarity)
	{
	}

	private void Initial()
	{
	}

	private void Reload()
	{
	}

	private void Clear()
	{
	}

	private void ReloadElement()
	{
	}

	private void ReloadWishList()
	{
	}

	public void HandleToggleItem(TreasureModel treasure)
	{
	}

	public void OnClickTooltip()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickAccept_003Ed__21))]
	public void OnClickAccept()
	{
	}

	public override bool Close()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CSaveWishList_003Ed__25))]
	public void SaveWishList()
	{
	}
}
