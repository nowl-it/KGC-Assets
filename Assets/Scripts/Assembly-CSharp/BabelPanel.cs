using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BabelPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickDevSetCurStage_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BabelPanel _003C_003E4__this;

		private UniTask<BabelResponseModel>.Awaiter _003C_003Eu__1;

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
	private Image _babelBg;

	[SerializeField]
	private Animator _openAnimator;

	[SerializeField]
	private Image _npcUnitSprite;

	[SerializeField]
	private List<Image> _groupUnitSprite;

	[SerializeField]
	private List<GameObject> _unitParents;

	[SerializeField]
	private GameObject _flagParent;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _floorText;

	[SerializeField]
	private Text _disabledText;

	[SerializeField]
	private Text _availableAtText;

	[SerializeField]
	private GameObject _startButton;

	public Button prevButton;

	public Button nextButton;

	private BabelFloorListPanel _babelFloorListPanel;

	private int _currentBabelIdx;

	private List<ResourceBabel> _babelList;

	private GameObject[] _unitObjects;

	private string[] _unitNames;

	private GameObject _flagObject;

	[Header("Test")]
	[SerializeField]
	private InputField _devSetStageInputField;

	private BabelStartPanel _babelStartPanel;

	private BabelDeckSettingPanel _babelDeckSettingPanel;

	private BabelPassPanel _babelPassPanel;

	private static readonly Vector3 LOWERED_TITLE_POS;

	public static BabelPanel Instance => null;

	public Button npcUnitButton => null;

	public Button startButton => null;

	public BabelFloorListPanel babelFloorListPanel => null;

	public BabelResponseModel.BabelModel babelModel => null;

	public BabelStartPanel babelStartPanel => null;

	public BabelDeckSettingPanel babelDeckSettingPanel => null;

	public BabelPassPanel babelPassPanel => null;

	public void Show(int openThemeId = -1)
	{
	}

	public void StopOpeningAnimation()
	{
	}

	private void Reload()
	{
	}

	public void Update()
	{
	}

	private void InstantiateLastUsedDeckUnits(ResourceBabel resBabel)
	{
	}

	public static void InstantiateBabelFlag(GameObject flagParent, ref GameObject flagObject)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	public void ShowBabelPassPanel(int babelId)
	{
	}

	public void OnClickEnter()
	{
	}

	public void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDevSetCurStage_003Ed__53))]
	public void OnClickDevSetCurStage()
	{
	}
}
