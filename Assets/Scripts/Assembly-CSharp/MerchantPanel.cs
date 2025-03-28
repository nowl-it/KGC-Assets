using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Protocol;
using UnityEngine;
using UnityEngine.UI;

public class MerchantPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnBuyItem_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MerchantPanel _003C_003E4__this;

		public int idx;

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

	public MerchantItem[] items;

	[ComponentConnect]
	public Border ribbon;

	[ComponentConnect]
	public Image icon;

	[ComponentConnect]
	public ImageTextPair myGold;

	[ComponentConnect]
	public Button refreshButton;

	[ComponentConnect]
	public ImageTextPair refreshPrice;

	[ComponentConnect]
	public Text freeRefreshText;

	public Button confirmButton;

	[SerializeField]
	private Image _passMissionImage;

	[SerializeField]
	private PassBenefitMessageObj_Simple _passBenefitObj;

	private List<Tween> _tweens;

	private List<AudioObject> _sounds;

	public static int[] tierPrice;

	private int _adCount;

	private GameCompleteRequestModel.MerchantResult _merchantResult;

	private bool _skipTween;

	private bool _skipAram;

	private int _minTier;

	private int _maxTier;

	private int _refreshCost;

	private bool _artifactRefresh;

	private bool _freeRefresh;

	[NonSerialized]
	public int buyCount;

	public void Init()
	{
	}

	public void Show(int minTier = 1, int maxTier = 3)
	{
	}

	public void Show(GameCompleteRequestModel.MerchantResult data)
	{
	}

	public void Show(MerchantSave data)
	{
	}

	private void ShowImpl(ResourceItem[] pickedItems, List<Item.Option>[] options, bool[] soldOut, bool hasAd)
	{
	}

	public MerchantSave SaveProto()
	{
		return null;
	}

	public void Close()
	{
	}

	[AsyncStateMachine(typeof(_003COnBuyItem_003Ed__30))]
	public void OnBuyItem(int idx)
	{
	}

	private void OnBuyItemWithoutAlert(int idx)
	{
	}

	private void OnBuyItemImpl(int idx)
	{
	}

	private void SaveGameWithMerchant()
	{
	}

	public void OnClickRefresh()
	{
	}

	private void Update()
	{
	}
}
