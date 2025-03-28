using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumTarotItem : MonoBehaviour
{
	[CanBeNull]
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Text _nameText;

	[CanBeNull]
	[SerializeField]
	private Text _roundText;

	[SerializeField]
	private Text _descText;

	[CanBeNull]
	[SerializeField]
	private Button _button;

	[SerializeField]
	[CanBeNull]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private ConditionalGroup _highlightCond;

	[SerializeField]
	private PlayerProfile _playerProfilePrefab;

	[SerializeField]
	private RectTransform _playerProfilesRoot;

	private List<PlayerProfile> _playerProfiles;

	private List<int> _preferUserIndexes;

	public ResourceColosseumTarot resTarot;

	private int _index;

	public void Set(CommonData.ChoiceUserSelectorType type, int index)
	{
	}

	public void Set(ResourceColosseumTarot resTarot, string animationTrigger = null)
	{
	}

	public void OnClick()
	{
	}

	public void SetHighlight(bool highlight)
	{
	}

	public void SetInteractable(bool interactable)
	{
	}

	public void SetAlpha(float a)
	{
	}

	public void HandleUserPreferred(int idx)
	{
	}

	public void Reload()
	{
	}

	public void SetAnimation(bool enabled, string trigger = null)
	{
	}
}
