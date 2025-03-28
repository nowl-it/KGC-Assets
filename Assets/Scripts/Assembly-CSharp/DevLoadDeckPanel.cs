using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class DevLoadDeckPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickInputDataConfirm_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DevLoadDeckPanel _003C_003E4__this;

		private UniTask<PvPMatchResponseModel>.Awaiter _003C_003Eu__1;

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

	public InputField enemyDeckField;

	public InputField myDeckField;

	[ComponentConnect]
	public GameObject inputDataPopup;

	[ComponentConnect]
	public Text popupLabel;

	[ComponentConnect]
	public Text fieldName;

	[ComponentConnect]
	public Toggle myDeckToggle;

	[ComponentConnect]
	public Toggle enemyDeckToggle;

	[ComponentConnect]
	public InputField dataField;

	private int _requestType;

	private int _requestValue;

	private PvPDeckInfo _savedMyDeck;

	private PvPDeckInfo _savedEnemyDeck;

	private const string LoadedFromDatabase = "(DB 에서 로드됨)";

	public void Show()
	{
	}

	public void Close()
	{
	}

	public void OnClickConfirm()
	{
	}

	private void LoadDeck(string data, bool mine)
	{
	}

	public void OnClickLoadFromDeckSet()
	{
	}

	public void OnClickLoadFromDeckPool()
	{
	}

	public void OnClickLoadFromPvPLog()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickInputDataConfirm_003Ed__20))]
	public void OnClickInputDataConfirm()
	{
	}

	public void OnClickInputDataClose()
	{
	}
}
