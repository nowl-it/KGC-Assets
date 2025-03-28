using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class DevAccessoryStatPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSave_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevAccessoryStatPanel _003C_003E4__this;

		private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

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
	private Dropdown _mainDropDown;

	[SerializeField]
	private Text _mainText;

	[SerializeField]
	private List<Dropdown> _subDropDown;

	[SerializeField]
	private List<InputField> _subInputField;

	private AccessoryModel.AccessoryData _accessoryData;

	private AccessoryModel _accessory;

	public void Show(AccessoryModel accessory)
	{
	}

	private void Reload()
	{
	}

	public void MainStatChanged()
	{
	}

	public void SubStatChanged(int dropDownIdx)
	{
	}

	[AsyncStateMachine(typeof(_003CSave_003Ed__10))]
	public void Save()
	{
	}
}
