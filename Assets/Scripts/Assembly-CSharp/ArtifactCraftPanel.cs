using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using Crystal;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactCraftPanel : MonoBehaviour
{
	public enum Tab
	{
		Craft = 0,
		Merge = 1,
		Reroll = 2,
		Polish = 3,
		None = 4
	}

	public SafeArea safeArea;

	[ComponentConnect]
	public LerpText dustText;

	public GetMoneyEffect getDustEffect;

	[ComponentConnect]
	public TabManager tabManager;

	[ComponentConnect]
	public ArtifactResultPanel artifactResultPanel;

	[SerializeField]
	private Transform _dustEffectTransform;

	[SerializeField]
	private ArtifactCraftTabBase[] _artifactTab;

	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	[SerializeField]
	private Button _closeButton;

	[SerializeField]
	private GameObject _artifactOptionProbButton;

	[Header("Merge / Craft Tab")]
	[SerializeField]
	private Text _mergyCraftTipText;

	[NonSerialized]
	public ArtifactModel lastSelectedArtifact;

	public List<(ArtifactModel artifact, int count)> selectedItems;

	private Tab _currentTab;

	private int _lastDustCount;

	private bool _closable;

	private bool _prevArtifactTabActive;

	public static ArtifactCraftPanel Instance => null;

	public ArtifactCraftTabBase[] artifactTab => null;

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void Show()
	{
	}

	private void PlayTabSound()
	{
	}

	public void Reload()
	{
	}

	public void Reload(bool force)
	{
	}

	public void OnClickTab(int idx)
	{
	}

	private void ReloadTipText()
	{
	}

	public void ReloadActionButtonInteractable()
	{
	}

	public void ReloadCost()
	{
	}

	public void OnClickClose()
	{
	}

	public void Close(bool withReload)
	{
	}

	public void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	public void OnClickSlot(ArtifactCraftSlot slot)
	{
	}

	public void OnClickInfo()
	{
	}

	public void OnClickProbability()
	{
	}

	public void ReloadSelected()
	{
	}

	public void OpenTab(string tabName)
	{
	}

	public void SetOutSideClose(bool v)
	{
	}

	public void SetClosable(bool v)
	{
	}

	public void ShowCloseButton(bool v)
	{
	}

	public void OnClickRerollPolishInfo(GameObject info)
	{
	}
}
