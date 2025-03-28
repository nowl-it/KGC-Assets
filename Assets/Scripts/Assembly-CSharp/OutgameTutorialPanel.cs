using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class OutgameTutorialPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHide_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OutgameTutorialPanel _003C_003E4__this;

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
	private struct _003COnClickSkip_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OutgameTutorialPanel _003C_003E4__this;

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
	private struct _003CProgressTutorialMission_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OutgameTutorialPanel _003C_003E4__this;

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

	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public GameObject skipPanel;

	[ComponentConnect]
	public InverseBlocker inverseBlocker;

	public TutorialStep[] steps1;

	public TutorialStep[] steps2;

	public TutorialStep[] steps3;

	public TutorialStep[] steps10;

	public TutorialStep[] steps20;

	public TutorialStep[] steps30;

	public TutorialStep[] steps40;

	public TutorialStep[] steps50;

	public TutorialStep[] steps60;

	public TutorialStep[] steps90;

	public TutorialStep[] steps100;

	public TutorialStep[] steps110;

	public TutorialStep[] steps120;

	public TutorialStep[] steps130;

	public TutorialStep[] steps140;

	public TutorialStep[] steps150;

	public TutorialStep[] steps160;

	public TutorialStep[] steps170;

	public TutorialStep[] steps180;

	public TutorialStep[] steps190;

	public TutorialStep[] steps200;

	private TutorialStep[] _curSteps;

	private int _step;

	public int stepsNum;

	public string tutorialType;

	private int _tmpSiblingIdx;

	private bool _isShowing;

	public Button skipButton;

	public Button devSkipButton;

	public Action onTutorialEnd;

	private List<TerritoryBuildingData> _territoryData;

	private List<GameObject> _tutorialObjects;

	public bool removeArtifacts { get; private set; }

	public TutorialStep curStep => null;

	public bool isShowing => false;

	public void StartTutorial(int steps, bool manual, Action onTutorialSuccessfullyShown)
	{
	}

	public void Show(int step, float delay = 0.3f, bool enableOverrideSorting = false, RectTransform customBlocker = null)
	{
	}

	public void ShowSkipPanel()
	{
	}

	public void HideSkipPanel()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickSkip_003Ed__47))]
	public void OnClickSkip()
	{
	}

	[AsyncStateMachine(typeof(_003CHide_003Ed__48))]
	public void Hide()
	{
	}

	[AsyncStateMachine(typeof(_003CProgressTutorialMission_003Ed__49))]
	private void ProgressTutorialMission()
	{
	}

	private Vector2 GetPanelScale()
	{
		return default(Vector2);
	}

	public Vector2 GetPanelSize()
	{
		return default(Vector2);
	}

	public Vector2 ClampTutorialObjectPosition(Vector2 from)
	{
		return default(Vector2);
	}

	public static OutgameTutorialPanel GetActivatedPanel()
	{
		return null;
	}

	private void PrepareTutorial20()
	{
	}

	private void PrepareTutorial100()
	{
	}

	private void PrepareTutorial110()
	{
	}

	private void PrepareTutorial120()
	{
	}

	private void PrepareTutorial130()
	{
	}

	private void PrepareTutorial140()
	{
	}

	private void PrepareTutorial150()
	{
	}

	private void PrepareTutorial160()
	{
	}

	private void PrepareTutorial170()
	{
	}

	private void PrepareTutorial180()
	{
	}

	private void PrepareTutorial190()
	{
	}

	private void PrepareTutorial200()
	{
	}

	private void FindUnitAndFocus(TutorialStep step, int unitId, bool focus = true)
	{
	}
}
