using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSendTutorialSkip_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<Awesomepiece.Model.GameResponseModel>.Awaiter _003C_003Eu__1;

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

	public VolumeControler volumeControler;

	public Border ribbon;

	public GameObject commentObject;

	public Text commentText;

	public GameObject surrenderButton;

	public GameObject rogueLikeSaveAndLobbyButton;

	public RogueLikeMissionButton rogueLikeMissionButton;

	public RectTransform upperPart;

	public GameObject ingameSettingPanel;

	public RectTransform buttonsGroup;

	public ConditionalRootGroup autoBattleInfoGroup;

	public GameObject autoBattleInfoPopup;

	public ConditionalRootGroup sellAreaInfoGroup;

	public GameObject sellAreaInfoPopup;

	public ConditionalRootGroup autoMergeInfoGroup;

	public GameObject autoMergeInfoPopup;

	public ConditionalRootGroup damageShooterInfoGroup;

	public GameObject damageShooterInfoPopup;

	public ConditionalRootGroup rankingStageInfoGroup;

	public GameObject rankingStageInfoPopup;

	public ConditionalRootGroup emojiEnableInfoGroup;

	public GameObject emojiEnableInfoPopup;

	public ConditionalRootGroup sellManyEnableInfoGroup;

	public GameObject sellManyEnableInfoPopup;

	public Image flag;

	public Image rogueLikeSave;

	public Image colosseumSetting;

	public Button reportButton;

	public bool isTutorial;

	public void Show(bool withComment)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickGiveUp()
	{
	}

	public void OnClickAutoBattleOn()
	{
	}

	public void OnClickAutoBattleOff()
	{
	}

	public void OnClickAutoBattle()
	{
	}

	public void OnClickSellAreaBig()
	{
	}

	public void OnClickSellAreaSmall()
	{
	}

	public void OnClickSellArea()
	{
	}

	public void OnClickAutoMergeInclude()
	{
	}

	public void OnClickAutoMergeExclude()
	{
	}

	public void OnClickAutoMerge()
	{
	}

	public void OnClickDamageShooterActive()
	{
	}

	public void OnClickDamageShooterInactive()
	{
	}

	public void OnClickDamageShooter()
	{
	}

	public void OnClickRankingStageActive()
	{
	}

	public void OnClickRankingStageInActive()
	{
	}

	public void OnClickRankingStage()
	{
	}

	public void OnClickEmojiEnable()
	{
	}

	public void OnClickEmojiDisable()
	{
	}

	public void OnClickEmojiState()
	{
	}

	public void OnClickSellManyEnable()
	{
	}

	public void OnClickSellManyDisable()
	{
	}

	public void OnClickSellManyState()
	{
	}

	public void OnClickAutoBattleInfo()
	{
	}

	public void OnClickSellAreaInfo()
	{
	}

	public void OnClickAutoMergeInfo()
	{
	}

	public void OnClickDamageShooterInfo()
	{
	}

	public void OnClickRankingStageInfo()
	{
	}

	public void OnClickEmojiEnableInfo()
	{
	}

	public void OnClickSellManyInfo()
	{
	}

	public void RefreshInGameSettingButtons()
	{
	}

	[AsyncStateMachine(typeof(_003CSendTutorialSkip_003Ed__62))]
	private void SendTutorialSkip()
	{
	}

	public void OnClickRogueLikeSaveAndLobby()
	{
	}

	public void OnClickReport()
	{
	}
}
