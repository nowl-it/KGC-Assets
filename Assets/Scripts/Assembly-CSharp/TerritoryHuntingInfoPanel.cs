using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingInfoPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickStartHunting_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryHuntingInfoPanel _003C_003E4__this;

		private UniTask<TerritoryStartHuntingResponseModel>.Awaiter _003C_003Eu__1;

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
	private TerritoryHuntingInfoUI _infoUI;

	[SerializeField]
	private Text _buildingNameText;

	[SerializeField]
	private Text _buildingLevelText;

	[SerializeField]
	private FlexibleUIElements _assignedUnitElements;

	[SerializeField]
	private Text _predictedRankText;

	[SerializeField]
	private Text _regionBonusText;

	[SerializeField]
	private FlexibleUIElements _rewardItemElements;

	[SerializeField]
	private FlexibleUIElements _difficultyItemElements;

	[SerializeField]
	private Text _heartCostInStartButtonText;

	private TerritoryHuntingUnitAssignPanel _unitAssignPanel;

	private TerritoryHuntingData _huntingData;

	private ResourceTerritoryHunting _resHunting;

	private List<Reward> _predictedRewards;

	private readonly List<int> _assignedUnits;

	private int _maxDifficulty;

	private int _selectedDifficulty;

	private ResourceTerritoryBuilding _resBuilding;

	private Action _onClose;

	private static bool _requestProcess;

	public TerritoryHuntingUnitAssignPanel unitAssignPanel => null;

	public void Show(ResourceTerritoryBuilding resBuilding, TerritoryHuntingData huntingData, float assignmentBenefitPer, Action onClose)
	{
	}

	private void ReloadRewardRelatedUIs()
	{
	}

	public void ReloadAssignedUnits()
	{
	}

	public void ReloadTicketCost()
	{
	}

	private void ReloadHeartCost()
	{
	}

	private ResourceTerritoryHunting.TerritoryHuntingRank GetPredictedRank()
	{
		return default(ResourceTerritoryHunting.TerritoryHuntingRank);
	}

	private void SetAssignedUnitItem(int index, GameObject go, TerritoryHuntingAssignedUnitItem item)
	{
	}

	private void SetRewardItem(int index, GameObject go, TerritoryHuntingRewardItem item)
	{
	}

	private void SetDifficultyItem(int index, GameObject go, TerritoryHuntingDifficultyItem item)
	{
	}

	public void SetDifficulty(int difficulty)
	{
	}

	public void SetAssignedUnits(List<int> units)
	{
	}

	public void OnClickAssignUnits()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStartHunting_003Ed__33))]
	public void OnClickStartHunting()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void ForceClose()
	{
	}

	private void CloseImpl()
	{
	}

	private void OnDestroy()
	{
	}
}
