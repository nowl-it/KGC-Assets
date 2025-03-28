using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ReportSubmitPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickSubmit_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ReportSubmitPanel _003C_003E4__this;

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

	[SerializeField]
	private PlayerProfile _playerProfile;

	[SerializeField]
	private InputField _reason;

	[SerializeField]
	private Text _textLengthCounter;

	[SerializeField]
	private Text _typeText;

	[SerializeField]
	private GameObject _dropdownObject;

	private string _selectedType;

	private ColosseumPlayerDataResponseModel.ColosseumPlayerData _playerData;

	private ColosseumReportPopup _parent;

	private const int TEXT_MAX_BYTE = 200;

	public void Set(ColosseumPlayerDataResponseModel.ColosseumPlayerData playerData, ColosseumReportPopup parent)
	{
	}

	public void OnClickDropDown()
	{
	}

	public void OnClickSelectType(string type)
	{
	}

	public void OnClickRollUp()
	{
	}

	public void OnValueChanged()
	{
	}

	public void OnClickBack()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickSubmit_003Ed__15))]
	public void OnClickSubmit()
	{
	}
}
