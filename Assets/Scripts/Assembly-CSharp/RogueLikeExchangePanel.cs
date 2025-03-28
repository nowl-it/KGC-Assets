using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeExchangePanel : MonoBehaviour, IClosable
{
	[Serializable]
	public struct SaveData
	{
		public List<RogueLikeRandomRewardsPanel.RewardDataSaveData> resultDatas;

		public Constants.RogueLikeItemType itemType;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public RogueLikeArtifactModel targetArtifact;

		public Item targetItem;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickExchange_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		public RogueLikeExchangePanel _003C_003E4__this;

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

	private static RogueLikeExchangePanel _instance;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Button _exchangeButton;

	[SerializeField]
	private Text _exchangeButtonText;

	[SerializeField]
	private Transform _inventoryPanelRoot;

	[SerializeField]
	private RogueLikeInventoryIcon _dummyInventoryIconForArtifact;

	private static List<RogueLikeRandomRewardsPanel.RewardData> _resultDatas;

	private static Constants.RogueLikeItemType _itemType;

	private static RogueLikeInventoryIcon _selectedIcon;

	private bool _setBG;

	public static RogueLikeExchangePanel Instance => null;

	private void SetBG()
	{
	}

	public void Show(Constants.RogueLikeItemType itemType)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickExchange_003Ed__16))]
	public void OnClickExchange()
	{
	}

	private void SetResultItems(Action<int> iconSetFunc)
	{
	}

	public void ClearResults()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public static SaveData ToSaveData()
	{
		return default(SaveData);
	}

	public void LoadFromSaveDataAndShow(SaveData saveData)
	{
	}
}
