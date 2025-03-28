using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PostListItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CReceivePost_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PostListItem _003C_003E4__this;

		private UniTask<PostReceiveResponseModel>.Awaiter _003C_003Eu__1;

		private GameManager _003C_003E7__wrap1;

		private UniTask<FlagInventoryResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask<NameTagInventoryResponseModel>.Awaiter _003C_003Eu__3;

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

	public Text titleText;

	public Text descText;

	public Text untilAtText;

	public ClickableShopItemIcon rewardIcon;

	public RectMask2D rewardMask;

	public GameObject content;

	public GameObject emptyContent;

	public GameObject rewardBox;

	public Text buttonText;

	public ConditionalGroup adCondition;

	public Image cardRewardBoxBackground;

	public GameObject cardRewardBox;

	public ClickableShopItemIcon unitIcon;

	public UnitSoulItem unitSoulItem;

	public Text soulAmountText;

	private PostResponseModel.PostData _data;

	private int _targetUnit;

	private bool _isAd;

	public void Set(PostResponseModel.PostData data)
	{
	}

	private string Localize(string str)
	{
		return null;
	}

	private void ReloadRewardRegion()
	{
	}

	private void SetUnitSoul(int unitID, int amount)
	{
	}

	private void SetUnit(int unitId, int amount, string type)
	{
	}

	public void SetEmpty(bool v)
	{
	}

	public void OnClickReceive()
	{
	}

	[AsyncStateMachine(typeof(_003CReceivePost_003Ed__25))]
	private void ReceivePost()
	{
	}
}
