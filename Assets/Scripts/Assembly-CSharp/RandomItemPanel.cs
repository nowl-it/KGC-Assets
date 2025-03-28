using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Protocol;
using UnityEngine;
using UnityEngine.UI;

public class RandomItemPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickOk_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RandomItemPanel _003C_003E4__this;

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

	[ComponentConnect]
	public Border ribbon;

	[ComponentConnect]
	public Text tierText;

	public Button[] buttons;

	[ComponentConnect]
	public Button okButton;

	[ComponentConnect]
	public Button reRollButton;

	[ComponentConnect]
	public Text reRollText;

	[ComponentConnect("RerollButton", false)]
	public ConditionalGroup rerollGroup;

	[ComponentConnect]
	public ConditionalRootGroup randomItemCondGroup;

	[ComponentConnect]
	public ItemInfoPanel itemInfoPanel;

	[ComponentConnect]
	public GameObject noSelectedObject;

	[ComponentConnect]
	public ConditionalImage tierCond;

	[ComponentConnect]
	public Text tooltipText;

	private Tween[] _tweens;

	private Tween[] _tweens2;

	private Item[] _items;

	private Action[] _callBacks;

	private int _rerollMaxCount;

	private int _rerollCount;

	private int _tier;

	private int[][] _tables;

	private int _selectedIdx;

	private GameCompleteRequestModel.CraftResult _craftResult;

	private int GetItemTier(int tier)
	{
		return 0;
	}

	public void ResetItemTierTable()
	{
	}

	public void Show(int tier)
	{
	}

	public void Show(Scene_Game.SaveCraftPopup data)
	{
	}

	public void Show(RandomItemSave data)
	{
	}

	private void ShowImpl(int tier, int maxRerollCount = -1, int remainRerollCount = -1, bool init = true)
	{
	}

	public void SetResult()
	{
	}

	private void Save()
	{
	}

	public RandomItemSave SaveProto()
	{
		return null;
	}

	public void Init(bool reroll = false)
	{
	}

	public void OnClickButton(int idx)
	{
	}

	public void OnClickInfo(int idx)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickOk_003Ed__34))]
	public void OnClickOk()
	{
	}

	private void OnClickOkImpl()
	{
	}

	public void ReRolll()
	{
	}

	private void Update()
	{
	}

	public void ForceSelectItem()
	{
	}
}
