using System.Collections.Generic;
using LeTai.Asset.TranslucentImage;
using UnityEngine;

public class PopupManager
{
	public struct PopupInformation
	{
		public MonoBehaviour popup;

		public Transform parent;

		public int siblingIndex;

		public PopupInformation(MonoBehaviour popup, Transform parent, int siblingIndex)
		{
			this.popup = null;
			this.parent = null;
			this.siblingIndex = 0;
		}
	}

	public static PopupManager Instance;

	private List<IClosable> _popups;

	private bool _prevIsMultiTouchEnabled;

	private PopupInformation _activatedBlurPopupInformation;

	private List<PopupInformation> _inActivatedBlurPopups;

	private Dictionary<MonoBehaviour, PopupInformation> _popupsOnBlurPopup;

	private bool _isLobbyOrTerritory => false;

	public bool forceClose { get; private set; }

	public void Clear()
	{
	}

	public void Add(MonoBehaviour popup)
	{
	}

	public bool HasPopupType<T>() where T : IClosable
	{
		return false;
	}

	public void Remove(MonoBehaviour popup)
	{
	}

	public void Close()
	{
	}

	public IClosable Peek()
	{
		return null;
	}

	public void CloseAll()
	{
	}

	public bool CanClose()
	{
		return false;
	}

	public bool Close(MonoBehaviour popup)
	{
		return false;
	}

	public int GetPopupCount()
	{
		return 0;
	}

	public void SetupBlur(GameObject popup)
	{
	}

	private void SetupBlurImpl(TranslucentImage popup)
	{
	}

	public void ReleaseBlur(GameObject popup)
	{
	}

	private void ReleaseBlurImpl(PopupInformation info)
	{
	}

	public void SetPopupParent(PopupInformation info)
	{
	}

	public bool IsBlurPopupActivated()
	{
		return false;
	}
}
