using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class NicknameChangePopup : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CRequestChangeNickname_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NicknameChangePopup _003C_003E4__this;

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
	public Text castleNamePreview;

	[ComponentConnect]
	public Text userNamePreview;

	[ComponentConnect]
	public InputField castleNameInputField;

	[ComponentConnect]
	public InputField userNameInputField;

	[ComponentConnect]
	public Dropdown castleNameDropdown;

	[ComponentConnect]
	public Dropdown userNameDropdown;

	[ComponentConnect]
	public GameObject priceBox;

	[ComponentConnect]
	public Price price;

	[ComponentConnect]
	public GameObject warningBox;

	[ComponentConnect]
	public RectTransform confirmButton;

	[ComponentConnect]
	public RectTransform cancelButton;

	[ComponentConnect]
	public ConditionalGroup localeConditional;

	private bool _nameBan;

	private const int MAX_NAME_LENGTH = 10;

	public void Show(bool nameBan = false)
	{
	}

	public void OnClickConfirm()
	{
	}

	public void OnClickCancel()
	{
	}

	public void UpdatePreview()
	{
	}

	[AsyncStateMachine(typeof(_003CRequestChangeNickname_003Ed__18))]
	private void RequestChangeNickname()
	{
	}

	public bool Close()
	{
		return false;
	}
}
