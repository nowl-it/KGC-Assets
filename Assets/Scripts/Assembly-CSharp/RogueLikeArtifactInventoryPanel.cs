using System;
using UnityEngine;

public class RogueLikeArtifactInventoryPanel : MonoBehaviour
{
	private static RogueLikeArtifactInventoryPanel _instance;

	[SerializeField]
	private RogueLikeItemUI _itemInfoPanel;

	[SerializeField]
	private ConditionalGroup _selectButtonConditionals;

	[SerializeField]
	private RogueLikeArtifactIcon[] _items;

	[SerializeField]
	private ConditionalGroup[] _selectedConditionals;

	private Action<RogueLikeArtifactIcon> _onClickIcon;

	private RogueLikeArtifactIcon _clickedIcon;

	private Func<RogueLikeArtifactModel, bool> _except;

	private Action _onReload;

	public static RogueLikeArtifactInventoryPanel Instance => null;

	public void Show(Transform parent)
	{
	}

	public void Set(Func<RogueLikeArtifactModel, bool> except, Action<RogueLikeArtifactIcon> onClickIcon, Action onReload)
	{
	}

	public void Reload()
	{
	}

	public void ShowSelectButton()
	{
	}

	public void OnClickSelectButton()
	{
	}

	public void OnClickArtifact(int index)
	{
	}
}
