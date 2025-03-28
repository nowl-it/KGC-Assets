using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactInfoPanel : MonoBehaviour, IClosable, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CChangeCustomType_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactInfoPanel _003C_003E4__this;

		public int targetCustomType;

		private ArtifactModel _003CprevArtifact_003E5__2;

		private int _003CprevId_003E5__3;

		private DraggableArtifactCard _003CdeckArtifactCard_003E5__4;

		private ArtifactModel _003CequippedArtifact_003E5__5;

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
	private struct _003CDoShortcut_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactInfoPanel _003C_003E4__this;

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
	private struct _003COnDirectAction_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArtifactInfoPanel _003C_003E4__this;

		public string tabName;

		private int _003CprevId_003E5__2;

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

	[ComponentConnect]
	public Image box;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text typeLevelText;

	[ComponentConnect]
	public Text mainOptionText;

	[ComponentConnect]
	public Text optionDescText;

	[ComponentConnect]
	public Text descText;

	[ComponentConnect]
	public Image artifactIcon;

	[ComponentConnect]
	public Image frameImage;

	[ComponentConnect]
	public Button equipButton;

	[ComponentConnect]
	public Button unEquipButton;

	[ComponentConnect]
	public GameObject canNotEquip;

	[ComponentConnect]
	public Button useButton;

	[ComponentConnect]
	public Button craftButton;

	[ComponentConnect]
	public Button mergeButton;

	[ComponentConnect]
	public Button rerollButton;

	[ComponentConnect]
	public Button dismantleButton;

	[ComponentConnect]
	public ArtifactOptionUI artifactOptionUI;

	[ComponentConnect]
	public Button sourceShortCutButton;

	[ComponentConnect]
	public ConditionalGroup favoriteConditional;

	[ComponentConnect]
	public Button leftButton;

	[ComponentConnect]
	public Button rightButton;

	public RectTransform[] tutorialObjects;

	private DraggableArtifactCard _artifactCard;

	private ResourceArtifact _resArtifact;

	private bool _processing;

	private Canvas canvas;

	public void Show(DraggableArtifactCard artifactCard, bool ownArtifact = true)
	{
	}

	public void Show(ArtifactModel artifact, bool ownArtifact = true)
	{
	}

	private void Reload(ArtifactModel artifact, bool ownArtifact = true)
	{
	}

	[OnClick("EquipButton", true)]
	public void OnClickEquip()
	{
	}

	[OnClick("UnEquipButton", true)]
	public void OnClickUnEquip()
	{
	}

	[OnClick("CraftButton", true)]
	public void OnClickCraft()
	{
	}

	[OnClick("MergeButton", true)]
	public void OnClickMerge()
	{
	}

	[OnClick("RerollButton", true)]
	public void OnClickReroll()
	{
	}

	public void OnClickDismantle()
	{
	}

	public void OnClickUseCatalystBox()
	{
	}

	public void OnClickStar()
	{
	}

	public void OnClickLock()
	{
	}

	[AsyncStateMachine(typeof(_003CChangeCustomType_003Ed__38))]
	private void ChangeCustomType(int targetCustomType)
	{
	}

	[AsyncStateMachine(typeof(_003COnDirectAction_003Ed__39))]
	private void OnDirectAction(string tabName)
	{
	}

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	public void OnClickSourceShortCut()
	{
	}

	[AsyncStateMachine(typeof(_003CDoShortcut_003Ed__43))]
	private void DoShortcut()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void SetSortingOrder(int order)
	{
	}
}
