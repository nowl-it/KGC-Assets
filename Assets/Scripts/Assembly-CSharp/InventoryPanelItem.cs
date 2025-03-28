using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanelItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__29<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InventoryPanelItem _003C_003E4__this;

		private int _003CprevDismantleCount_003E5__2;

		private UniTask<(int count, bool isCanceled)>.Awaiter _003C_003Eu__1;

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
	private Image cellBG;

	[SerializeField]
	private ClickableShopItemIcon _itemIcon;

	public ETCItemModel etcItem;

	[Header("Artifact")]
	[SerializeField]
	private DraggableArtifactCard _artifactCard;

	[SerializeField]
	private Image[] _artifactOptionImages;

	[SerializeField]
	private Image[] _artifactOptionMaxLevelImages;

	public ArtifactModel artifact;

	[SerializeField]
	[Header("Treasure")]
	private TreasureUIItem _treasureItem;

	[NonSerialized]
	public TreasureModel treasure;

	[Header("Accessory")]
	[SerializeField]
	private AccessoryUIItem _accessoryItem;

	[NonSerialized]
	public AccessoryModel accessory;

	private bool _accessorySimpleView;

	[Header("Treasure / Accessory")]
	[SerializeField]
	private Text _newObject;

	[Header("Dismantle UI")]
	[SerializeField]
	private GameObject dismantleObj;

	[SerializeField]
	private Text dismantleAmountText;

	[SerializeField]
	private GameObject dismantleSelectedObj;

	[SerializeField]
	private GameObject highlightObj;

	[NonSerialized]
	public int dismantleCount;

	public int ownCount;

	private bool _dismantleAmountAwaiting;

	public ClickableShopItemIcon itemIcon => null;

	public DraggableArtifactCard ArtifactCard => null;

	private void Clear()
	{
	}

	public void Set(ETCItemModel etcItem)
	{
	}

	public void Set(ArtifactModel artifact, ScrollRect scrollRect)
	{
	}

	public void Set(TreasureModel treasure)
	{
	}

	public void Set(AccessoryModel accessory, bool simpleView)
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__29<>))]
	public void OnClick<T>(T item)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void OnClickRelease()
	{
	}

	public void SetDismantleAmount(int amount, bool max = false)
	{
	}

	public void ShowDismantleHighlight(bool show)
	{
	}

	private bool CheckCanDismantle()
	{
		return false;
	}
}
