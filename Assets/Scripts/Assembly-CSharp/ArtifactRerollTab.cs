using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactRerollTab : ArtifactCraftTabBase
{
	public class RerollInfo
	{
		public bool[] optionLocks;

		public ArtifactModel artifactModel;

		public int materialId;

		public (int catalystId, int catalystTier) catalyst;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchRerolledHistory_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactRerollTab _003C_003E4__this;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CRerollForTutorial_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactRerollTab _003C_003E4__this;

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
	private struct _003CRerollImpl_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactRerollTab _003C_003E4__this;

		public bool useGold;

		private ArtifactRerollConfirmPanel.RerollConfirmInfo _003CrerollConfirmInfo_003E5__2;

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

	[SerializeField]
	private ArtifactCraftSlot[] _slots;

	[SerializeField]
	private ArtifactOptionUI _option;

	[SerializeField]
	private ImageToggle[] _optionLocks;

	[SerializeField]
	private Image[] _optionLockOverlays;

	[SerializeField]
	private ImageTextPair _cashCost;

	[SerializeField]
	private ImageTextPair _goldCost;

	[SerializeField]
	private Text _incrementText;

	[SerializeField]
	private Gauge _polishGauge;

	[SerializeField]
	private ConditionalGroup _actionButton;

	[SerializeField]
	private GameObject[] _materialLines;

	[SerializeField]
	private GameObject[] _catalystLines;

	[SerializeField]
	private Image[] _optionLockOutLines;

	public RectTransform[] tutorialObjects;

	private ArtifactRerollConfirmPanel _artifactRerollConfirmPanel;

	private RerollInfo _rerollInfo;

	private int _step;

	private bool _rerollEventArtifact;

	private float _lineSequenceAlpha;

	private Sequence _lineSequence;

	private List<(ArtifactModel artifact, int count)> _selectedItems => null;

	public ArtifactRerollConfirmPanel artifactRerollConfirmPanel => null;

	public void Awake()
	{
	}

	public override void Init()
	{
	}

	public override void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	private void Reload(ArtifactModel artifact)
	{
	}

	public override void ReloadCost()
	{
	}

	public override void ReloadActionButtonInteractable()
	{
	}

	public override void OnClickSlot(ArtifactCraftSlot slot)
	{
	}

	private void OnClickSlotImpl(int index)
	{
	}

	public override void Clear()
	{
	}

	private void ReloadRerollOptionEffect()
	{
	}

	private void ActiveLineEffects()
	{
	}

	public void Reroll(bool useGold)
	{
	}

	[AsyncStateMachine(typeof(_003CRerollImpl_003Ed__36))]
	private void RerollImpl(bool useGold)
	{
	}

	[AsyncStateMachine(typeof(_003CRerollForTutorial_003Ed__37))]
	public void RerollForTutorial()
	{
	}

	private void ReloadAfterReroll()
	{
	}

	public static int GetRerollCost(RerollInfo rerollInfo, bool useGold)
	{
		return 0;
	}

	public static int GetPolishPointIncrement(RerollInfo rerollInfo)
	{
		return 0;
	}

	private void RemoveSelected(int id)
	{
	}

	private bool Filter(ArtifactModel artifact)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CFetchRerolledHistory_003Ed__43))]
	private void FetchRerolledHistory()
	{
	}

	public void Update()
	{
	}

	public ImageToggle OptionLock(int idx)
	{
		return null;
	}
}
