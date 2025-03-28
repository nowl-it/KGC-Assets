using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class ChangeFlagPanel : MonoBehaviour, IClosable, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickEquip_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ChangeFlagPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

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

	public FlagPreviewTab flagPreview;

	[ComponentConnect]
	public GameObject normalTab;

	[ComponentConnect]
	public GameObject seasonTab;

	[ComponentConnect]
	public TabManager tabManager;

	public GameObject flagInfoItemPrefab;

	public RectTransform flagsLayout;

	private List<FlagInfoItem> _flags;

	private List<FlagInfoItem> _seasonFlags;

	private List<FlagInfoItem> _normalFlags;

	private FlagInfoItem _selectedFlag;

	private FlagInfoItem _equippedFlag;

	private int _normalCount;

	private int _seasonCount;

	public void Show()
	{
	}

	private void LoadFlags()
	{
	}

	private void SetDefaultFlag()
	{
	}

	private void AddFlagItem(ResourceFlag resFlag, bool equipped, bool isSeasonal, int season)
	{
	}

	public void OnClickFlag(FlagInfoItem flagInfoItem)
	{
	}

	private void SetFlagList(List<FlagInfoItem> flagInfoItems)
	{
	}

	private void ClearFlags()
	{
	}

	private void SetFlagInfoUI(ResourceFlag resFlag, int season)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickEquip_003Ed__21))]
	public void OnClickEquip()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
