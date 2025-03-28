using System.Collections.Generic;
using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectNewHeroPanelItem : MonoBehaviour
{
	[SerializeField]
	private Image _illust;

	[SerializeField]
	private Image _gradationImage;

	[SerializeField]
	private Image _selectedImage;

	[SerializeField]
	private Transform _unitPrefabRoot;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private ConditionalImage _levelImageConditional;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private ConditionalGroup _selectedConditionals;

	private List<UIEffect> _unitPrefabUIEffects;

	private List<GameObject> _unitPrefabs;

	private GameObject _unitPrefab;

	private Color _gradationColor;

	private RogueLikeCardData _cardData;

	public void Set(RogueLikeCardData card)
	{
	}

	private void ReloadPrefab(ResourceSkin resSkin, string prefab)
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void ClearUnitPrefabs()
	{
	}
}
