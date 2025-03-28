using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using PolyNav;
using UnityEngine;

public class TerritoryUnit : DragClickableObject
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCollectLabor_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryUnit _003C_003E4__this;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCollectSkinToken_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryUnit _003C_003E4__this;

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
	private Transform _unitPrefabRoot;

	[SerializeField]
	private PolyNavAgent _navAgent;

	[SerializeField]
	private TerritoryMarker _marker;

	private UnitController _unitController;

	public ResourceUnit resUnit;

	private ResourceSkin _resSkin;

	[HideInInspector]
	public int team;

	private bool _isProcessing;

	private bool _isRunning;

	private readonly List<GameObject> _effects;

	private IDisposable _followDisposable;

	private Animator _dialogue;

	private ulong? _dialogueWorkTimerKey;

	public void Set(ResourceUnit resUnit, ResourceSkin resSkin)
	{
	}

	public void SetPolyNavMap(PolyNavMap map)
	{
	}

	private void ReloadPrefab()
	{
	}

	protected override void Update()
	{
	}

	private void UnitSpecificUpdate(bool showEffects)
	{
	}

	public virtual void SetFlip(bool right)
	{
	}

	private void SetNextMoveDestination(bool once = false)
	{
	}

	public Vector2 GetValidRandomPointFromMap()
	{
		return default(Vector2);
	}

	public override void OnClick(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	public override void OnBeginDrag()
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public override void OnEndDrag()
	{
	}

	public override void OnPress(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	private void ProcessMarkerAction()
	{
	}

	[AsyncStateMachine(typeof(_003CCollectLabor_003Ed__24))]
	private void CollectLabor()
	{
	}

	[AsyncStateMachine(typeof(_003CCollectSkinToken_003Ed__25))]
	private void CollectSkinToken()
	{
	}

	public bool CheckMarkerType(TerritoryMarker.Type type)
	{
		return false;
	}

	public void ShowMarker(TerritoryMarker.Type type)
	{
	}

	protected override void OnDisable()
	{
	}

	private void Follow(TerritoryUnit unit)
	{
	}

	private void StopFollowing()
	{
	}

	private void OnDestroy()
	{
	}

	public void ShowDialogue(float time, TerritoryUnit with = null)
	{
	}
}
