using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidBossGuideInfoPanel : BlurPopupPanel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public bool processed;

		internal void _003CShow_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchClanBestDecks_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public ClanRaidBossGuideInfoPanel _003C_003E4__this;

		private UniTask<ClanRaidBestDeckResponseModel>.Awaiter _003C_003Eu__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShow_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRaidBossGuideInfoPanel _003C_003E4__this;

		public int bossId;

		public int difficulty;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

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

	[SerializeField]
	private ClanRaidBossInfoPanel _bossInfo;

	[SerializeField]
	private Text _guideText;

	[SerializeField]
	private DraggableUnitCard[] _recommendedHeroes;

	[SerializeField]
	private GameObject[] _bgObjects;

	[SerializeField]
	private ClanRaidBossGuideDifficultyItem[] _difficultyItems;

	[SerializeField]
	private LayoutFitter _difficultyItemFitter;

	[SerializeField]
	private RectTransform _difficultyItemContent;

	[SerializeField]
	private TabManager _guideTab;

	[SerializeField]
	private RectTransform _bestDeckRect;

	[SerializeField]
	private ClanRaidBestDeckItem _bestDeckPrefab;

	[SerializeField]
	private Text _emptyText;

	[SerializeField]
	private UIFitter[] _fitters;

	private List<ClanRaidBestDeckItem> _bestDeckItems;

	private int _currentBossId;

	private int _currentDifficulty;

	private int _showingBossId;

	private int _showingDifficulty;

	private int _currentRound;

	private bool _init;

	private List<ClanRaidBestDeckModel> _model;

	private bool _processing;

	[AsyncStateMachine(typeof(_003CShow_003Ed__21))]
	public void Show(int bossId, int difficulty)
	{
	}

	private int GetCurrentHp()
	{
		return 0;
	}

	private int GetBossRound(int bossId)
	{
		return 0;
	}

	public void OnClickTab(int idx)
	{
	}

	public void OnClickBossTier(int idx)
	{
	}

	public void OnClickNextBoss(bool right)
	{
	}

	private void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchClanBestDecks_003Ed__28))]
	private UniTask FetchClanBestDecks()
	{
		return default(UniTask);
	}
}
