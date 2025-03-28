using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class DevilPanel : MonoBehaviour, IComponentConnector
{
	public enum Condition
	{
		Damage = 0,
		EnemySpawnRate_1 = 1,
		EnemySpawnRate_2 = 2,
		EnemySpawnRate_3 = 3,
		EnemyLevelUp_1 = 4,
		EnemyLevelUp_2 = 5,
		EnemyLevelUp_3 = 6
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickAccept_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevilPanel _003C_003E4__this;

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
	private struct _003COnClickDecline_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevilPanel _003C_003E4__this;

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
	public Text condText;

	[ComponentConnect]
	public Text rewardText;

	[ComponentConnect]
	public Image icon;

	[ComponentConnect]
	public CanvasGroup condBox;

	[ComponentConnect]
	public CanvasGroup rewardBox;

	[ComponentConnect]
	public CanvasGroup buttons;

	public Image yesWarningImage;

	public Image noWarningImage;

	public ItemInfoPanel itemInfoPanel;

	public Image itemInfoPassIcon;

	private Action<bool> _callback;

	[NonSerialized]
	public bool allAccepted;

	[NonSerialized]
	public bool allDeclined;

	public void Init()
	{
	}

	public void Show(Condition cond, Item reward, Action<bool> callback)
	{
	}

	public static string GetDesc(Condition cond, bool withDetail = true)
	{
		return null;
	}

	public void Close()
	{
	}

	[OnClick("YesButton", false)]
	[AsyncStateMachine(typeof(_003COnClickAccept_003Ed__19))]
	public void OnClickAccept()
	{
	}

	[OnClick("NoButton", false)]
	[AsyncStateMachine(typeof(_003COnClickDecline_003Ed__20))]
	public void OnClickDecline()
	{
	}

	public static int GetTier(Condition cond)
	{
		return 0;
	}

	public static int GetEffectStageCount(Condition cond)
	{
		return 0;
	}

	public static List<Condition> GetConditions(int tier)
	{
		return null;
	}
}
