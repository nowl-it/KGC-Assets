using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactPolishTab : ArtifactCraftTabBase
{
	private enum PolishMode
	{
		None = 0,
		OptionTierUp = 1,
		ReplaceOptionIdx = 2
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandleSelectOtherOption_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int index;

		public ArtifactPolishTab _003C_003E4__this;

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
	private struct _003COnClickPolish_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactPolishTab _003C_003E4__this;

		private int _003CmaxPolishPoint_003E5__2;

		private int _003CselectedIndex_003E5__3;

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
	private ArtifactCraftSlot _slot;

	[SerializeField]
	private Gauge _polishGauge;

	[SerializeField]
	private ArtifactOptionUI _option;

	[SerializeField]
	private ConditionalGroup _tierUpButton;

	[SerializeField]
	private ConditionalGroup _replaceSlotButton;

	[Header("연마석 선택 패널")]
	[SerializeField]
	private GameObject _selectPolishItemPanel;

	[SerializeField]
	private GameObject _optionTierUpUI;

	[SerializeField]
	private Text _prevLevel;

	[SerializeField]
	private Text _nextLevel;

	[SerializeField]
	private Text _prevValue;

	[SerializeField]
	private Text _nextValue;

	[SerializeField]
	private Image[] _nextIcons;

	[SerializeField]
	private ConditionalGroup _polishButton;

	[Space(15f)]
	[SerializeField]
	private GameObject _replaceOptionIdxUI;

	[SerializeField]
	private SimpleArtifactOptionLine _optionLine;

	[SerializeField]
	private ConditionalGroup[] _optionSlotGroups;

	[SerializeField]
	private Image[] _optionDisableImages;

	[SerializeField]
	[Space(15f)]
	private ArtifactSelectPolishItem _polishItemPrefab;

	[SerializeField]
	private RectTransform _polishItemsRoot;

	public RectTransform[] tutorialObjects;

	private List<ArtifactSelectPolishItem> _polishItems;

	private int _selectedIndex;

	private int _polishPoint;

	private List<int> _replacedOptionIdx;

	private PolishMode _polishMode;

	private int _selectedSlotIdx;

	private bool _replaced;

	private List<(ArtifactModel artifact, int count)> selectedItems => null;

	private ArtifactModel _selectedArtifact => null;

	private ArtifactOptionLine_Polish[] _options => null;

	private int _maxPolishPoint => 0;

	private bool _tierUpButtonEnable => false;

	public override void Init()
	{
	}

	public override void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	public override void ReloadCost()
	{
	}

	public override void ReloadActionButtonInteractable()
	{
	}

	public void ReloadPolishButtonInteractable()
	{
	}

	public override void OnClickSlot(ArtifactCraftSlot slot)
	{
	}

	public override void Clear()
	{
	}

	public void CloseSelectPolishItemPanel()
	{
	}

	public void OnClickOptionTierUp()
	{
	}

	public void OnClickReplaceOptionIdx()
	{
	}

	private void ReloadSelectPolishItemPanel()
	{
	}

	private void ReloadPolishItemPanelOptionLine()
	{
	}

	public void OnClickAutoSelect()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickPolish_003Ed__49))]
	public void OnClickPolish()
	{
	}

	public void MockUpAnimation(int index)
	{
	}

	public void OnClickOptionLine(int index)
	{
	}

	public void OnClickOptionSlotIdx(int idx)
	{
	}

	public void OnClickResetReplacedSlotIdx()
	{
	}

	[AsyncStateMachine(typeof(_003CHandleSelectOtherOption_003Ed__56))]
	private void HandleSelectOtherOption(int index)
	{
	}

	private bool SetOptionIndex(int index)
	{
		return false;
	}

	private void Reload()
	{
	}

	private bool Filter(ArtifactModel artifact)
	{
		return false;
	}
}
