using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class DevArtifactPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchInfo_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevArtifactPanel _003C_003E4__this;

		private UniTask<ArtifactInventoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickCrafting_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevArtifactPanel _003C_003E4__this;

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
	private struct _003COnClickDismantle_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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
	private struct _003COnClickEquip_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevArtifactPanel _003C_003E4__this;

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
	private struct _003COnClickGacha_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int gachaLevel;

		public DevArtifactPanel _003C_003E4__this;

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
	private struct _003COnClickMerge_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevArtifactPanel _003C_003E4__this;

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

	public static DevArtifactPanel Instance;

	[ComponentConnect]
	public Text inventoryText;

	[ComponentConnect]
	public InputField craftingField;

	[ComponentConnect]
	public Toggle useDustToggle;

	[ComponentConnect]
	public InputField mergeField1;

	[ComponentConnect]
	public InputField mergeField2;

	[ComponentConnect]
	public InputField dismantleField;

	[ComponentConnect]
	public InputField rerollField;

	[ComponentConnect]
	public InputField rerollMaterialField;

	[ComponentConnect]
	public Toggle lockOption1;

	[ComponentConnect]
	public Toggle lockOption2;

	[ComponentConnect]
	public Toggle lockOption3;

	[ComponentConnect]
	public Toggle lockOption4;

	[ComponentConnect]
	public InputField equipField;

	[ComponentConnect]
	public InputField equipSlotField;

	[ComponentConnect]
	public InputField changeOptionField;

	[ComponentConnect]
	public DevArtifactOptionPanel devArtifactOptionPanel;

	private ArtifactInventoryResponseModel _inventory;

	private string[] colors;

	public void Awake()
	{
	}

	public void Show()
	{
	}

	public void OnClickClose()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchInfo_003Ed__21))]
	public void FetchInfo()
	{
	}

	public void ReloadInventory(ArtifactInventoryResponseModel ret)
	{
	}

	public void ReloadInventory(ArtifactResultResponseModel ret)
	{
	}

	private string GetTargetText(List<int> targets)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COnClickGacha_003Ed__26))]
	public void OnClickGacha(int gachaLevel)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickCrafting_003Ed__27))]
	public void OnClickCrafting()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickMerge_003Ed__28))]
	public void OnClickMerge()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDismantle_003Ed__29))]
	public void OnClickDismantle()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickEquip_003Ed__30))]
	public void OnClickEquip()
	{
	}

	public void OnClickChangeOption()
	{
	}
}
