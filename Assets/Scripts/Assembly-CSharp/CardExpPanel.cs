using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class CardExpPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickConfirm_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CardExpPanel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

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

	public Text levelText;

	public ConditionalImage expButton;

	public ConditionalImage soulToExpButton;

	public ConditionalImage soulItemToExpButton;

	public ConditionalImage soulItemButton;

	public Image soulIcon;

	public Text expText;

	public Text expDesc;

	public Text expHaveText;

	public GameObject expDisabled;

	public GameObject expInfo;

	public Text soulToExpText;

	public Text soulToExpDesc;

	public Text soulHaveText;

	public GameObject soulToExpDisabled;

	public GameObject soulInfo;

	public Text soulItemToExpText;

	public Text soulItemToExpDesc;

	public Text soulItemToExpHaveText;

	public GameObject soulItemToExpDisabled;

	public GameObject soulItemToExpInfo;

	public Text soulItemText;

	public Text soulItemDesc;

	public Text soulItemHaveText;

	public GameObject soulItemDisabled;

	public GameObject soulItemInfo;

	private int selectedButton;

	private CardData cardData;

	private int _needExp;

	private int _needSoul;

	private int _useExpItem;

	private int _useSoulToExp;

	private int _useSoulItemToExp;

	private int _useSoulItem;

	public Gauge expGauge;

	public Gauge soulGauge;

	public ConditionalImageColor expGaugeColor;

	public ConditionalImageColor soulGaugeColor;

	public void Show(CardData cardData)
	{
	}

	public void Reload()
	{
	}

	public void OnClickUseExp()
	{
	}

	public void OnClickUseSoulToExp()
	{
	}

	public void OnClickUseSoulItemToExp()
	{
	}

	public void OnClickUseSoulItem()
	{
	}

	private void ReloadSelected()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickConfirm_003Ed__45))]
	public void OnClickConfirm()
	{
	}

	public void Hide()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	private void ShowInfo(GameObject go)
	{
	}

	public void OnClickExpInfo()
	{
	}

	public void OnClickSoulInfo()
	{
	}

	public void OnClickSoulItemToExpInfo()
	{
	}

	public void OnClickSoulItemInfo()
	{
	}
}
