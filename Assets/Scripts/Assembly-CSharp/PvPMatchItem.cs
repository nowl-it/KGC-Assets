using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class PvPMatchItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CTestRemovePvPDeck_003Ed__16 : IAsyncStateMachine
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

	public Text nameText;

	public Text scoreText;

	public PlayerProfile playerProfile;

	public Image tierIcon;

	public Image starIcon;

	public GameObject selectedObject;

	public DeckPreviewPanel deckPreviewPanel;

	public GameObject content;

	public GameObject emptyText;

	public Text levelText;

	public GameObject blindObj;

	[HideInInspector]
	public PvPDeckInfo deckInfo;

	public void Set(PvPDeckInfo info, bool blind)
	{
	}

	public void SetWaiting()
	{
	}

	public void SetSelected(bool v)
	{
	}

	public void SetBlind(bool blind)
	{
	}

	[AsyncStateMachine(typeof(_003CTestRemovePvPDeck_003Ed__16))]
	public void TestRemovePvPDeck(PvPMatchItem item)
	{
	}
}
