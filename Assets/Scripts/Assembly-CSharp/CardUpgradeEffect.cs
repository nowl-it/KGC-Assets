using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CardUpgradeEffect : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckNewUnitPackagePopup_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public CardUpgradeEffect _003C_003E4__this;

		private int _003CprevCardPackageCount_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

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
	public UnitIllust unitIllust;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text subnameText;

	[ComponentConnect]
	public GameObject[] levelBox;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	public Gauge expGauge;

	[ComponentConnect]
	public Gauge expGauge_small;

	[ComponentConnect]
	public Gauge soulGauge_small;

	[ComponentConnect]
	public CanvasGroup main;

	[ComponentConnect]
	public List<Button> upgradeButton;

	[ComponentConnect]
	public Button closeButton;

	public Button confirmButton;

	[Header("Card LevelUp Effect")]
	[ComponentConnect]
	public StatType hpBox;

	[ComponentConnect]
	public StatType atkBox;

	[ComponentConnect]
	public StatType matkBox;

	public Text[] potentialLevel;

	public Text[] potentialOption;

	public Image[] statEffects;

	public Image potentialPartition;

	[HideInInspector]
	public GameObject upgradePotential;

	[HideInInspector]
	public Image potentialEffect;

	[Header("Card Potential Effect")]
	public Text unLockPotentialDesc;

	public GameObject potentialBG;

	public Image[] potentialBGLines;

	public PotentialButton[] potentialButtons;

	public Image[] potentialEffects;

	public Text selectPotentialDesc;

	public CardInfoTab[] tabs;

	private Sequence _sequence;

	private bool _confirmed;

	private Tween _potentialSeq;

	private bool _closedByButton;

	public ResourceUnit resUnit => null;

	public CardData cardData => null;

	public int originLevel => 0;

	public int originPotentialTier => 0;

	public void Awake()
	{
	}

	private void SetDefaultInfo()
	{
	}

	public void ShowUpgradeEffect()
	{
	}

	public void ShowPotentialEffect()
	{
	}

	public void ReloadIllust()
	{
	}

	public void OnClickConfirm()
	{
	}

	[AsyncStateMachine(typeof(_003CCheckNewUnitPackagePopup_003Ed__45))]
	public UniTaskVoid CheckNewUnitPackagePopup()
	{
		return default(UniTaskVoid);
	}

	public void OnClickSkip()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
