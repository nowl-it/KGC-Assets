using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class MissionPanel_Base : MonoBehaviour
{
	public enum PanelType
	{
		Normal = 0,
		Clan = 1,
		Beginner = 2,
		ColosseumOpen = 3,
		ThirdHalfAnniversary = 4,
		None = 5,
		Count = 6,
		Starter = 7
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public bool processed;

		internal void _003COnClickReceiveAll_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickReceiveAll_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MissionPanel_Base _003C_003E4__this;

		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		private List<MissionData> _003Cmissions_003E5__2;

		private int _003Ci_003E5__3;

		private TaskAwaiter<MissionRewardResponseModel> _003C_003Eu__1;

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
	private UITableView _tableView;

	[SerializeField]
	protected TabManager _tabManager;

	[SerializeField]
	private Transform _tabRoot;

	[SerializeField]
	protected GameObject _tabPrefab;

	[SerializeField]
	private Color[] _missionTypeImageColors;

	[SerializeField]
	private ConditionalBase[] _receiveAllConditionals;

	[SerializeField]
	private GameObjectPool _artifactIconPool;

	[SerializeField]
	private Text _timeLeftUntilNextMissionText;

	public bool underMissionPanelInHierarchy;

	protected readonly List<MissionPanel_BaseTab> _tabs;

	protected int _currentTabIdx;

	protected List<MissionData>[] _cachedMissionDatas;

	protected Func<int, ResourceMission, bool, bool> _missionShowConditionFunc;

	private bool _isLoading;

	public const int DEFAULT_HEIGHT = 1560;

	public const int DEFAULT_BOX_BOTTOM = 112;

	protected MissionPanel _missionPanel;

	private (Transform parent, int siblingIndex, Vector2 pos) _originParent;

	public TabManager tabManager => null;

	public PanelType currentPanelType { get; private set; }

	public Action<MissionPanel_Base> onReceive { get; set; }

	public Func<int, string> onReloadTimeLeftUntilNextMission { get; set; }

	private List<MissionData> cachedMissionDatas => null;

	public void Show(PanelType panelType, List<MissionData>[] cachedMissionDatas, Func<int, ResourceMission, bool, bool> missionShowConditionFunc, MissionPanel missionPanel)
	{
	}

	public void SetHeight(int height)
	{
	}

	public void InitializeTabs(string[] tabNames, List<int>[] connectedTabs)
	{
	}

	private void Update()
	{
	}

	public void Reload()
	{
	}

	public void ReloadMissionDatas()
	{
	}

	public void ReloadClearedMissionCountBadge(int idx, bool withConnectedTabs = true)
	{
	}

	protected virtual void OnClickTab(int idx)
	{
	}

	private void SetMissionItem(int idx, GameObject go)
	{
	}

	private Color GetMissionTypeColor(MissionData missionData)
	{
		return default(Color);
	}

	public bool HandleMissionItemReceive(MissionItem missionItem)
	{
		return false;
	}

	public void HandleMissionItemReceiveEnd(MissionItem missionItem, MissionRewardResponseModel ret)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReceiveAll_003Ed__47))]
	public void OnClickReceiveAll()
	{
	}

	private void ReloadMissionData(int idx, bool withConnectedTabs = true)
	{
	}

	protected virtual void SortMission(List<MissionData> missionDatas)
	{
	}

	public PackageItemArtifactIcon RentArtifactIcon(int artifactId, int count)
	{
		return null;
	}

	public void ReturnArtifactIcon(GameObject icon)
	{
	}

	public void LockTab(int idx, bool locked)
	{
	}

	public void SetLoading(bool v)
	{
	}

	public bool Close()
	{
		return false;
	}
}
