using UnityEngine;

public class TapjoySample : MonoBehaviour
{
	private enum UIState
	{
		Placement = 0,
		Event = 1,
		User = 2
	}

	private UIState uiState;

	private PlacementExample mainUIView;

	private EventExample eventUIView;

	private UserExample userUIView;

	public bool viewIsShowing;

	public bool isConnected;

	public bool isFirebaseInitialized;

	private GUIStyle labelStyle;

	private int fontSize;

	private float centerX;

	private float tabWidth;

	private float tabHeight;

	private float yPadding;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void HandleConnectSuccess()
	{
	}

	public void HandleConnectFailure()
	{
	}

	public void HandleViewWillOpen(int viewType)
	{
	}

	public void HandleViewDidOpen(int viewType)
	{
	}

	public void HandleViewWillClose(int viewType)
	{
	}

	public void HandleViewDidClose(int viewType)
	{
	}

	private void OnGUI()
	{
	}

	private void ChangeState(UIState state)
	{
	}
}
