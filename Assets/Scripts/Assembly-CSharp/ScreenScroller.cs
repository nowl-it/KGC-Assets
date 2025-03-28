using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenScroller : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSeason11EasterEgg_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ScreenScroller _003C_003E4__this;

		private UniTask<Awesomepiece.Model.PlayerDataResponseModel>.Awaiter _003C_003Eu__1;

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

	public BaseLobbyPanel[] lobbyPanels;

	public Transform background;

	public ScrollRectEx scrollRect;

	public Camera camera;

	public float dragDetectThreshold;

	public int screenCount;

	public int startScreen;

	private int _currentScreen;

	private int _lastScreen;

	private bool _screenMoving;

	private float _screenWidth;

	private float _spacing;

	private Sequence _screenTween;

	private Vector2 _dragStartPos;

	private Vector2 _startMainPos;

	private float _dragStartTime;

	private bool _dragStarted;

	private Action<int> _callback;

	private bool _packageCheatInited;

	public GameObject easterEgg0;

	public GameObject easterEgg1;

	public int cameraMoveOffset => 0;

	public bool dragging => false;

	public int currentScreen => 0;

	public void Init(float screenWidth, Action<int> callback = null)
	{
	}

	public void DereferenceLobbyPanels()
	{
	}

	public void LateUpdate()
	{
	}

	private void ShowPrevCurNextPanels()
	{
	}

	public void SetScreen(int idx, bool force = false)
	{
	}

	private void HideInactivePanels()
	{
	}

	private void ShowActivePanel()
	{
	}

	public float GetPosition(int idx)
	{
		return 0f;
	}

	public float GetCamPosition(int idx)
	{
		return 0f;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	[AsyncStateMachine(typeof(_003CSeason11EasterEgg_003Ed__39))]
	private void Season11EasterEgg()
	{
	}

	public void SetEnable(bool v)
	{
	}
}
