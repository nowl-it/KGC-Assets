using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PotentialButton : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetPotential_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public bool setToAll;

		public PotentialButton _003C_003E4__this;

		private UniTask<Awesomepiece.Model.DeckResponseModel>.Awaiter _003C_003Eu__1;

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
	private Image _buttonImage;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private GameObject _selected;

	private CardData _cardData;

	private bool _comingSoon;

	private string _desc;

	private Action<PotentialButton> _onClick;

	public int potentialSlot { get; private set; }

	public bool comingSoon => false;

	public void Initialize(CardData cardData, bool ownCard, ResourceUnit.Potential potential, Action<PotentialButton> onClick)
	{
	}

	public void Set(bool isSelected)
	{
	}

	public void OnClick()
	{
	}

	public void OnClickAtCardInfoPanel()
	{
	}

	[AsyncStateMachine(typeof(_003CSetPotential_003Ed__18))]
	public void SetPotential(bool setToAll)
	{
	}
}
