using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class ChangeProfilePanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnSubmit_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ChangeProfilePanel _003C_003E4__this;

		private int _003Cid_003E5__2;

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

	[ComponentConnect]
	public PlayerProfile playerProfile;

	public UIGridView iconsView;

	public UIGridView nameTagsView;

	public TabManager tabManager;

	private List<(int id, bool hasCard)> _icons;

	private List<(ResourceNameTag resNameTag, bool equipped)> _nameTags;

	private int _selectedIconId;

	private int _equippedIconId;

	private ResourceNameTag _selectedNameTag;

	private ResourceNameTag _equippedNameTag;

	public void Show()
	{
	}

	public void ReloadProfileUI()
	{
	}

	public void LoadIcon()
	{
	}

	private void LoadNameTag()
	{
	}

	private void SetDefaultNameTag()
	{
	}

	private void AddNameTagItem(int idx, GameObject go)
	{
	}

	private void AddIcon(int idx, GameObject go)
	{
	}

	public void OnClickIcon(ProfileIcon icon)
	{
	}

	public void OnClickNameTag(NameTagItem nameTag)
	{
	}

	[AsyncStateMachine(typeof(_003COnSubmit_003Ed__19))]
	public void OnSubmit()
	{
	}

	public void OnClickSetName()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
